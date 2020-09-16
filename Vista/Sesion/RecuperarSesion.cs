using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financiero.Vista
{
    public partial class RecuperarSesion : Form
    {
    
        private Financiero.InicioSesion inicio;
        private Controlador.Usuario controlUsuario;

        public RecuperarSesion(Financiero.InicioSesion inicioSesion)
        {
            InitializeComponent();
            this.inicio = inicioSesion;
            cargando(false);
            controlUsuario = new Controlador.Usuario();
        }

        private void cargando(bool cargando) =>
            this.pictureBoxCargando.Visible = this.labelCargando.Visible = false;

        private async void iconButtonVolver_Click(object sender, System.EventArgs e)
        {

            inicio.abrirHijosEnPanelAsync(this.groupBoxRecuperarUsuario, inicio.groupBoxCargando);
            InicioSesion sesion = await inicio.crearInicioSesion();
            inicio.abrirHijosEnPanelAsync(inicio.groupBoxCargando, sesion.groupBoxInicioSesion);
            Dispose();
        }

        private async void iconButtonEnviarToken_Click(object sender, System.EventArgs e)
        {
            labelCargando.Text = "Revisando Conexion";
            cargando(true);
            if (await CheckForInternetConnection())
            {
                if (string.IsNullOrWhiteSpace(this.textBoxCorreo.Text.Trim()))
                {
                    cargando(false);
                }
                else {                   

                    if (string.IsNullOrWhiteSpace(await controlUsuario.
                        consultarUsuarioCorreo(this.textBoxCorreo.Text))) 
                    {
                        this.textBoxCorreo.ResetText();
                    }
                    else
                    {
                        string token = await controlUsuario.
                        consultarUsuarioCorreo(this.textBoxCorreo.Text);

                        labelCargando.Text = "Enviando....";
                        textBoxCorreo.Enabled = iconButtonEnviarToken.Enabled = false;

                        Modelo.EmailSenderOptions option = new Modelo.EmailSenderOptions();
                        Modelo.EmailSender emailSender = new Modelo.EmailSender(option);

                        this.pictureBoxCargando.Visible = labelCargando.Visible = true;
                        string mensaje = pruebaCorreo(token);
                        
                        await emailSender.SendEmailAsync(this.textBoxCorreo.Text.Trim(), mensaje);
                        
                        textBoxCorreo.ReadOnly = iconButtonEnviarToken.Enabled = !false;
                        textBoxValidarToken.Enabled = iconButtonValidarToken.Enabled = true;
                        textBoxCorreo.Enabled = iconButtonEnviarToken.Enabled = false;
                    }

                    cargando(false);
                }
            }
            else
            {
                this.pictureBoxCargando.Visible = labelCargando.Visible = false;
                labelCargando.Text = "No hay conexion";
                textBoxCorreo.ResetText();
                textBoxValidarToken.ResetText();
                textBoxValidarToken.Enabled =
                    textBoxValidarToken.Enabled =
                    iconButtonEnviarToken.Enabled =
                    iconButtonValidarToken.Enabled = false;
            }
        }


        public async static Task<bool> CheckForInternetConnection()
        {
            bool boolean = false;
            await Task.Run(()=> { 
                try
                {
                    using (var client = new System.Net.WebClient())
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        boolean = true;
                    }
                }
                catch
                {
                    boolean = false;
                }
            });
            return boolean;
        }

        public string pruebaCorreo(string token) {
            return string.Format("El token de su cuenta es: {0} ",token);
        }

        private async void iconButtonValidarToken_Click(object sender, System.EventArgs e)
        {
            string token = this.textBoxValidarToken.Text.Trim();
            if (string.IsNullOrWhiteSpace(token) && string.IsNullOrEmpty(token))
            {
            }
            else {
                this.cargando(true);
                Modelo.Usuario usuario = await controlUsuario.consultarUsuario(token);
                this.cargando(false);

                if (usuario == null)
                {
                    Console.WriteLine("Token invalido");

                }
                else {
                    inicio.abrirHijosEnPanelAsync(this.groupBoxRecuperarUsuario, inicio.groupBoxCargando);
                    Main main = await inicio.crearMain();
                    main.Show();
                    inicio.Hide();
                }
            }

        }
    }
}


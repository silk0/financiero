using System.Windows.Forms;

namespace Financiero.Vista
{
    public partial class InicioSesion : Form
    {
        private Financiero.InicioSesion inicio;
        private Modelo.ValidacionesString validaciones;
        public InicioSesion(Financiero.InicioSesion inicioSesion)
        {
            this.inicio = inicioSesion;
            validaciones = new Modelo.ValidacionesString();

            InitializeComponent();
            visibleObjetos();
        }

        private void visibleObjetos()=>
            this.labelCargando.Visible =
            this.labelUsuarioMensaje.Visible = 
            this.labelContrasenaMensaje.Visible = 
            this.pictureBoxCargando.Visible = false;

        private async void linkLabelNuevoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inicio.abrirHijosEnPanelAsync(this.groupBoxInicioSesion, inicio.groupBoxCargando);
            RegistrarSesion registro = await inicio.CrearRegistrarSesion();
            inicio.abrirHijosEnPanelAsync(inicio.groupBoxCargando, registro.groupBoxNuevoUsuario);
            Dispose();
        }

        private async void linkLabelRecuperarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inicio.abrirHijosEnPanelAsync(this.groupBoxInicioSesion, inicio.groupBoxCargando);
            RecuperarSesion recuperar = await inicio.crearRecuperarSesion();
            inicio.abrirHijosEnPanelAsync(inicio.groupBoxCargando, recuperar.groupBoxRecuperarUsuario);
            Dispose();
        }

        private void iconButtonCancelar_Click(object sender, System.EventArgs e)
        {
            this.textBoxUsuario.ResetText();
            this.textBoxContrasena.ResetText();
        }

        private async void iconButtonIniciar_Click(object sender, System.EventArgs e)
        {
            this.textBoxUsuario.ForeColor = System.Drawing.Color.Black;
            this.textBoxContrasena.ForeColor = System.Drawing.Color.Black;

            visibleObjetos();

            if (string.IsNullOrWhiteSpace(this.textBoxUsuario.Text) &&
                string.IsNullOrEmpty(this.textBoxUsuario.Text))
            {
                this.textBoxContrasena.ResetText();
                this.textBoxUsuario.ForeColor = System.Drawing.Color.Red;
                labelUsuarioMensaje.Text = "Campo de usuario vacio";
                labelUsuarioMensaje.Visible = true;
            }
            else
            {
                if (string.IsNullOrEmpty(this.textBoxContrasena.Text) &&
                    string.IsNullOrWhiteSpace(this.textBoxContrasena.Text))
                {
                    this.textBoxContrasena.ResetText();
                    this.textBoxContrasena.ForeColor = System.Drawing.Color.Red;
                    labelContrasenaMensaje.Text = "Campo de contraseña vacio";
                    labelContrasenaMensaje.Visible = true;
                }
                else
                {
                    Modelo.Usuario usuario =
                        new Modelo.Usuario(this.textBoxUsuario.Text, this.textBoxContrasena.Text);
                    labelCargando.Text = "Cargando";
                    cargando(true);
                    usuario = await new Controlador.Usuario().consultarUsuario(usuario);

                    if (usuario == null)
                    {
                        cargando(false);
                        this.textBoxContrasena.ResetText();
                    }
                    else
                    {
                        inicio.abrirHijosEnPanelAsync(this.groupBoxInicioSesion, inicio.groupBoxCargando);
                        Main main = await inicio.crearMain();
                        main.Show();
                        inicio.Hide();
                    }
                    cargando(false);
                }
            }
        }

        private void cargando(bool cargando) =>
            this.linkLabelRecuperarSesion.Enabled =
            this.linkLabelNuevoUsuario.Enabled =
            !(this.textBoxUsuario.ReadOnly =
            this.textBoxContrasena.ReadOnly =
            this.labelCargando.Visible =
            this.pictureBoxCargando.Visible = cargando);


        private void extBoxUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            string text = this.textBoxUsuario.Text;

            System.Drawing.Color rojo = System.Drawing.Color.Red;
            System.Drawing.Color negro = System.Drawing.Color.Black;

            if (validaciones.contieneEspacioEnBlanco(text))
            {
                labelUsuarioMensaje.Text = validaciones.noEspaciosVacios;
                iconButtonIniciar.Enabled = !(labelUsuarioMensaje.Visible = true);

                this.textBoxUsuario.ForeColor = rojo;
            }
            else
            {
                if (!validaciones.soloLetrasYDigitos(text))
                {
                    labelUsuarioMensaje.Text = validaciones.noCaracteresEspeciales;
                    iconButtonIniciar.Enabled = !(labelUsuarioMensaje.Visible = true);

                    this.textBoxUsuario.ForeColor = rojo;
                }
                else
                {
                    iconButtonIniciar.Enabled = !(labelUsuarioMensaje.Visible = false);
                    this.textBoxUsuario.ForeColor = negro;
                }
            }

        }
    }
}

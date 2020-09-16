using System.Windows.Forms;

namespace Financiero.Vista
{
    public partial class RegistrarSesion : Form
    {
        private Financiero.InicioSesion inicio;
        private Controlador.Usuario controlUsuario;
        public RegistrarSesion(Financiero.InicioSesion inicioSesion)
        {
            InitializeComponent();
            this.inicio = inicioSesion;
            this.pictureBoxCargando.Visible = false;
            cargando(false);
        }

        private void cargando(bool cargando) =>
            this.groupBoxNuevoUsuario.Visible =
            this.labelCargando.Visible = false;

        private async void iconButtonVolver_Click(object sender, System.EventArgs e)
        {
            inicio.abrirHijosEnPanelAsync(this.groupBoxNuevoUsuario, inicio.groupBoxCargando);
            InicioSesion sesion = await inicio.crearInicioSesion();
            inicio.abrirHijosEnPanelAsync(inicio.groupBoxCargando, sesion.groupBoxInicioSesion);
            Dispose();
        }

        private async void iconButtonNuevo_Click(object sender, System.EventArgs e)
        {
            if(this.controlUsuario==null)
                this.controlUsuario = new Controlador.Usuario();

            if (string.IsNullOrWhiteSpace(this.textBoxUsuario.Text.Trim())) 
            { 
                
            } else
            {
                if (string.IsNullOrWhiteSpace(this.textBoxCorreo.Text.Trim()))
                {
                }
                else 
                {
                    if (string.IsNullOrWhiteSpace(this.textBoxContrasena0.Text.Trim()))
                    {
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(this.textBoxContrasena1.Text.Trim()))
                        {
                        }
                        else 
                        {
                            cargando(true);
                            Modelo.Usuario usuario  = new Modelo.Usuario(
                                this.textBoxUsuario.Text.Trim(),
                                this.textBoxContrasena1.Text.Trim(),
                                this.textBoxCorreo.Text.Trim()
                                );
                            pictureBoxCargando.Visible = labelCargando.Visible = true;
                            
                            EnableControles(false);
                            if (await controlUsuario.consultarExiste(usuario)) 
                            {
                                pictureBoxCargando.Visible = labelCargando.Visible = false;
                                EnableControles(true);
                            }
                            else
                            {
                                await controlUsuario.ingresarUsuario(usuario);

                                resetearControles();
                                EnableControles(true);
                            }
                            cargando(false);
                            
                        }
                    }
                }
            }
        }

        private void EnableControles(bool b) =>
            this.textBoxUsuario.Enabled =
            this.textBoxContrasena1.Enabled =
            this.textBoxCorreo.Enabled =
            this.groupBoxNuevoUsuario.Enabled =
            this.iconButtonCancelar.Enabled = b;

        private void resetearControles() {
            this.textBoxContrasena1.ResetText();
            this.textBoxContrasena0.ResetText();
            this.textBoxCorreo.ResetText();
            this.textBoxUsuario.ResetText();
        }

        private void iconButtonCancelar_Click(object sender, System.EventArgs e)
        {
            resetearControles();
        }
    }
}

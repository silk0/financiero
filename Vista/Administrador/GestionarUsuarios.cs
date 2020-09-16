using System;
using System.Windows.Forms;

namespace Financiero
{
    public partial class GestionarUsuarios : Form
    {
        public GestionarUsuarios()
        {
            InitializeComponent();
        }

        private void iconButtonCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentesUsuario();
        }

        private void limpiarComponentesUsuario() {
            this.textBoxUsuario.ResetText();
            this.textBoxContrasena.ResetText();
            this.textBoxContrasena2.ResetText();
            this.comboBoxPersona.SelectedItem = 0;
        }

        private  void IconButtonAgregar_Click(object sender, EventArgs e)
        {
            try {
               /* Modelo.Usuario usuario = 
                    new Modelo.Usuario(
                        this.textBoxUsuario.Text.Trim(),
                        this.textBoxContrasena.Text.Trim());
                await new Controlador.Usuario().ingresarUsuario(usuario);*/
                limpiarComponentesUsuario();
            }
            catch(Exception ex) {
                Console.WriteLine(ex);
            }
        }
    }
}

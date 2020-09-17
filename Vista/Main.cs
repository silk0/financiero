using System;
using System.Drawing;
using System.Windows.Forms;

namespace Financiero.Vista
{
    public partial class Main : Form
    {
        private Form activeForm = null;
        private Financiero.InicioSesion inicio;
        public Main(Financiero.InicioSesion inicio)
        {
            this.inicio = inicio;
            InitializeComponent();
            //Size = new Size(974, 573);
            this.iconButtonVolver.Visible = false;
           // Console.WriteLine("Identificador del usuario: {0}",Modelo.Cryptography.Base64Decode(Modelo.Usuario.identifadorGet()));
        }

        private void abrirHijosEnPanel(Form formularioHijos)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formularioHijos;
            formularioHijos.TopLevel = false;
            formularioHijos.FormBorderStyle = FormBorderStyle.None;
            formularioHijos.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(formularioHijos);
            panelCentral.Tag = formularioHijos;
            formularioHijos.BringToFront();
            formularioHijos.Show();
        }


        private void iconButtonGenero_Click(object sender, EventArgs e)
        {
            abrirHijosEnPanel(new Vista.Generos());
        }

        private void iconButtonEstadoCivil_Click(object sender, EventArgs e)
        {
            abrirHijosEnPanel(new Vista.Estado_Civil());
        }

        private void iconButtonVolver_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

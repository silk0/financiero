using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financiero.Vista.ActivoFijo
{
    public partial class Ley : Form
    {
        private Controlador.Ley ley;
        public Ley()
        {
            InitializeComponent();
            ley = new Controlador.Ley();
        }

        private void habilitarFormulario(bool b)
            => maskedTextBoxPorciento.Enabled = textBoxNombre.Enabled = iconButton1.Enabled = b;
        private async void  iconButton1_Click(object sender, EventArgs e)
        {
            
           habilitarFormulario(false);
           await ley.ingresarLey(new Modelo.Activo.Ley(-1, textBoxNombre.Text,
                float.Parse(maskedTextBoxPorciento.Text.Replace("%"," "))));
            habilitarFormulario(true);
            textBoxNombre.ResetText();
            maskedTextBoxPorciento.ResetText();
        }
    }
}

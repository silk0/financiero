using System.Windows.Forms;

namespace Financiero.Vista
{
    public partial class Generos : Form
    {
        private Controlador.Generos controladorGeneros;
        private int rowSelected = -1;
        public Generos()
        {
            InitializeComponent();
            controladorGeneros = new Controlador.Generos();
            llenarTabla();
        }

        private async void llenarTabla()
        {
            this.dataGridViewGeneros.Rows.Clear();
            foreach (var i in await controladorGeneros.obtenerGeneros())
            {
                this.dataGridViewGeneros.Rows.Add(new object[] { i });
            }

            if (rowSelected != -1)
            {
                this.dataGridViewGeneros.Rows[rowSelected].Selected = false;
            }
        }

        private async void iconButtonAgregar_Click(object sender, System.EventArgs e)
        {
            this.iconButtonAgregar.Enabled = this.textBoxIngresar.Enabled = false;
            await this.controladorGeneros.
                ingresarGenero(new Modelo.Generos() { genero = this.textBoxIngresar.Text.Trim() });
            llenarTabla();
            this.textBoxIngresar.ResetText();
            this.iconButtonAgregar.Enabled = this.textBoxIngresar.Enabled = !false;
        }

        private async void iconButtonModificar_Click(object sender, System.EventArgs e)
        {
            if (iconButtonAgregar.Enabled && rowSelected >= 0)
            {
                iconButtonAgregar.Enabled = iconButtonEliminar.Visible = false;
                this.textBoxIngresar.ResetText();
                this.textBoxIngresar.Text = this.dataGridViewGeneros.Rows[rowSelected].Cells[0].Value.ToString();
            }
            else
            {               
                
                Modelo.Generos nuevo = new Modelo.Generos() { genero = this.textBoxIngresar.Text.Trim() };
                Modelo.Generos anterior = new Modelo.Generos() { genero = this.dataGridViewGeneros.Rows[rowSelected].Cells[0].Value.ToString() };
                await this.controladorGeneros.modificarGenero(nuevo, anterior);
                this.textBoxIngresar.ResetText();
                llenarTabla();
                iconButtonAgregar.Enabled = iconButtonEliminar.Visible = true;
                iconButtonModificar.Enabled = iconButtonEliminar.Enabled = false;
                
            }
        }

        private void dataGridViewGenero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
            this.iconButtonEliminar.Enabled = this.iconButtonModificar.Enabled = this.dataGridViewGeneros.Rows.Count > 0;
        }

        private async void iconButtonEliminar_Click(object sender, System.EventArgs e)
        {
            if (rowSelected >= 0)
            {
                this.iconButtonEliminar.Enabled = !this.iconButtonEliminar.Enabled;
                Modelo.Generos genero = new Modelo.Generos();
                genero.genero = this.dataGridViewGeneros.Rows[rowSelected].Cells[0].Value.ToString();
                await this.controladorGeneros.eliminarGenero(genero);
                llenarTabla();
                this.iconButtonEliminar.Enabled = this.iconButtonModificar.Enabled = this.dataGridViewGeneros.Rows.Count > 0;
            }
        }

        private void Generos_Load(object sender, System.EventArgs e)
        {

        }
    }
}

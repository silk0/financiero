using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Financiero.Vista
{
    public partial class Estado_Civil : Form
    {
        private Controlador.EstadosCivil estados_Civil;
        private int rowSelected = -1;
        public  Estado_Civil()
        {
            InitializeComponent();
            pictureBoxCargando.Visible = false;
            estados_Civil = new Controlador.EstadosCivil();            
            llenarTabla(null);            
        }

        private async void llenarTabla(String estadoCivil) {
            try
            {
                this.dataGridViewEstadoCivil.Rows.Clear();
                this.dataGridViewEstadoCivil.ClearSelection();
                pictureBoxCargando.Visible = true;
                iconButton1.Visible = iconButtonBuscar.Enabled = textBoxBuscar.Enabled = false;
                if (estadoCivil != null)
                {
                    foreach (var i in await estados_Civil.obtenerEstadosCivils(estadoCivil))
                    {
                        this.dataGridViewEstadoCivil.Rows.Add(new object[] { i });
                    }
                }
                else
                {
                    foreach (var i in await estados_Civil.obtenerEstadosCivils())
                    {
                        this.dataGridViewEstadoCivil.Rows.Add(new object[] { i });
                    }
                }
                iconButtonBuscar.Enabled = textBoxBuscar.Enabled = !textBoxBuscar.Enabled;
                pictureBoxCargando.Visible = iconButton1.Visible = !iconButton1.Visible;
            }catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
                this.dataGridViewEstadoCivil
                    .Columns.AddRange(new DataGridViewColumn[] {this.ColumnEstado});
                if(estadoCivil != null){
                    llenarTabla(estadoCivil);
                }else
                {
                    llenarTabla(null);
                }
            }
        }

        private void iconButton1_RefrescarTabla(object sender, EventArgs e)
        {       
            llenarTabla(null);      
        }

        private void dataGridViewEstadoCivil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
            this.iconButtonEliminar.Enabled = this.iconButtonModificar.Enabled = this.dataGridViewEstadoCivil.Rows.Count>0;           
        }
    
        private async void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            if (rowSelected >= 0) {
                this.iconButtonEliminar.Enabled = !this.iconButtonEliminar.Enabled;
                Modelo.EstadoCivil estado_civil = new Modelo.EstadoCivil();
                estado_civil.estadoCivil = this.dataGridViewEstadoCivil.Rows[rowSelected].Cells[0].Value.ToString();
                await this.estados_Civil.eliminarEstadoCivil(estado_civil);
                llenarTabla(null);
                this.iconButtonEliminar.Enabled = this.iconButtonModificar.Enabled = this.dataGridViewEstadoCivil.Rows.Count > 0; 
            }
        }

        private async void iconButtonAgregar_Click(object sender, EventArgs e)
        {
            if (await estados_Civil.existeEstadosCivils(this.textBoxIngresar.Text.Trim()) && 
                this.textBoxIngresar.Text!=null && !String.IsNullOrWhiteSpace(textBoxIngresar.Text)) {
                this.iconButtonAgregar.Enabled = this.textBoxIngresar.Enabled = false;
                var caracter = textBoxIngresar.Text.Trim().ToCharArray()[0];
                textBoxIngresar.Text = textBoxIngresar.Text.Trim().Replace(caracter, Char.ToUpper(caracter));
                await this.estados_Civil.
                    ingresarEstadoCivil(new Modelo.EstadoCivil() { estadoCivil = textBoxIngresar.Text.Trim() });
                llenarTabla(null);
                this.textBoxIngresar.ResetText();
                this.iconButtonAgregar.Enabled = this.textBoxIngresar.Enabled = !false;
            }
            else
            {
                this.textBoxIngresar.ResetText();
                llenarTabla(null);
            }
        }

        private  async void iconButtonModificar_Click(object sender, EventArgs e)
        {
            if (iconButtonAgregar.Enabled && rowSelected >= 0)
            {
                iconButtonAgregar.Enabled = iconButtonEliminar.Visible = false;
                this.textBoxIngresar.ResetText();
                this.textBoxIngresar.Text = this.dataGridViewEstadoCivil.Rows[rowSelected].Cells[0].Value.ToString();
            }
            else {
                Modelo.EstadoCivil nuevo = new Modelo.EstadoCivil() { estadoCivil = this.textBoxIngresar.Text.Trim()};
                Modelo.EstadoCivil anterior = new Modelo.EstadoCivil() { estadoCivil = this.dataGridViewEstadoCivil.Rows[rowSelected].Cells[0].Value.ToString()};
                await this.estados_Civil.modificarEstadoCivil(nuevo,anterior);
                this.textBoxIngresar.ResetText();
                llenarTabla(null);
                iconButtonAgregar.Enabled = iconButtonEliminar.Visible = true;
                iconButtonModificar.Enabled = iconButtonEliminar.Enabled = false;
            }
        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {            
            llenarTabla(textBoxBuscar.Text.Trim());
            textBoxBuscar.ResetText();           
        }
    }
}

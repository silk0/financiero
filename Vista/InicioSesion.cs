using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace Financiero
{
    public partial class InicioSesion : Form
    {

        public InicioSesion()
        {
            InitializeComponent();
            inicioSesion();
        } 

        private async void inicioSesion()
        {
            Vista.InicioSesion inicioSesion = await crearInicioSesion();
            abrirHijosEnPanelAsync(groupBoxCargando, inicioSesion.groupBoxInicioSesion);
        }

        public async Task<Vista.RegistrarSesion> CrearRegistrarSesion() {
            Vista.RegistrarSesion registrar = null;
            await Task.Run(()=> {
                Thread.Sleep(250);
                registrar = new Vista.RegistrarSesion(this);
            });
            return registrar;
        }

        public async Task<Vista.Main> crearMain() {
            Vista.Main main = null;
            await Task.Run(() => {
                main = new Vista.Main(this);
            });
            return main;
        }

        public async Task<Vista.RecuperarSesion> crearRecuperarSesion()
        {
            Vista.RecuperarSesion recuperar = null;
            await Task.Run(() => {
                Thread.Sleep(250);
                recuperar = new Vista.RecuperarSesion(this);
            });
            return recuperar;
        }

        public async Task<Vista.InicioSesion> crearInicioSesion()
        {
            Vista.InicioSesion inicio = null;
            await Task.Run(() => {
                Thread.Sleep(250);
                inicio = new Vista.InicioSesion(this);
            });
            return inicio;
        }

        public void abrirHijosEnPanelAsync(GroupBox groupBoxAnterior, GroupBox groupBoxNuevo)
        {
            if (this.Controls.Contains(groupBoxAnterior))
            {
                groupBoxNuevo.Location = groupBoxAnterior.Location;
                this.Controls.Remove(groupBoxAnterior);                
                this.Controls.Add(groupBoxNuevo);
            }
        }        
    }
}

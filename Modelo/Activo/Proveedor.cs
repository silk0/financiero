using System;

namespace Financiero.Modelo.Activo
{
    public class Proveedor
    {
        private int id { get; }
        private String empresa { get; }
        private String encargado { get; }
        private String telefono { get; }
        private String email { get; }
        private int tipoProveedor { get; }

        public Proveedor(int id, string empresa, string encargado, 
            string telefono, string email, int tipoProveedor)
        {
            this.id = id;
            this.empresa = empresa;
            this.encargado = encargado;
            this.telefono = telefono;
            this.email = email;
            this.tipoProveedor = tipoProveedor;
        }
    }
}

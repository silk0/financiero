using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiero.Modelo.Activo
{
    public class Unidad
    {
        private int id { get; }
        private String codigo { get; }
        private String nombre { get; }

        public Unidad(int id, string codigo, string nombre)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
        }
    }
}

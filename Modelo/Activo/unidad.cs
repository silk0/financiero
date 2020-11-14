using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Activo
{
    class unidad
    {
        private int id { get; }
        private String codigo { get; }
        private String nombre { get; }

        public unidad(int id, string codigo, string nombre)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
        }
    }
}

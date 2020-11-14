using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Activo
{
    class Ley
    {
        private int id { get; }
        private String nombre { get; }
        private float porcentaje { get; }

        public Ley(int id, string nombre, float porcentaje)
        {
            this.id = id;
            this.nombre = nombre;
            this.porcentaje = porcentaje;
        }
    }
}

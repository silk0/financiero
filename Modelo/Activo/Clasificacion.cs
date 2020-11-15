using System;

namespace Financiero.Modelo.Activo
{
    public class Clasificacion
    {
        private int id { get; }
        private Ley ley { get; }
        private String nombre { get; }
        private float porcentaje { get; }

        public Clasificacion(int id, Ley ley, string nombre, float porcentaje)
        {
            this.id = id;
            this.ley = ley;
            this.nombre = nombre;
            this.porcentaje = porcentaje;
        }
    }
}

using Financiero.Modelo;
using System;

namespace Financiero.Modelo.Activo
{
    public class Ley : Fechas
    {
        public int id { get; }
        public String nombre { get; }
        public float porcentaje { get; }

        public Ley(int id, string nombre, float porcentaje)
        {
            this.id = id;
            this.nombre = nombre;
            this.porcentaje = porcentaje;
        }


    }
}

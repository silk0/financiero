using System;

namespace Financiero.Modelo.Activo
{
    public class Activo
    {
        private int id { get; }
        private String codigo { get; }
        private String nombre { get; }
        private String factura { get; }
        private String marca { get; }
        private float precio { get; }
        private String serie { get; }
        private String modelo { get; }
        private String color { get; }
        private String observacion { get; }
        private  Proveedor proveedor { get; }
        private  Clasificacion clasificacion { get; }
        private int tipoActivo { get; }
        private int tipoAdquisicion { get; }
        private int estadoActivo { get; }
        private String justificacionBaja { get; }
        private DateTime fechaBaja { get; }
        private int estadoUsado { get; }
        private int aniosUso { get; }
        private int aniosVida { get; }
        private float valorResidual { get; }

        public Activo(int id, string codigo, string nombre, string factura,
            string marca, float precio, string serie, string modelo, string color, 
            string observacion, Proveedor proveedor, Clasificacion clasificacion, 
            int tipoActivo, int tipoAdquisicion, int estadoActivo, string justificacionBaja,
            DateTime fechaBaja, int estadoUsado, int aniosUso, int aniosVida, float valorResidual)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
            this.factura = factura;
            this.marca = marca;
            this.precio = precio;
            this.serie = serie;
            this.modelo = modelo;
            this.color = color;
            this.observacion = observacion;
            this.proveedor = proveedor;
            this.clasificacion = clasificacion;
            this.tipoActivo = tipoActivo;
            this.tipoAdquisicion = tipoAdquisicion;
            this.estadoActivo = estadoActivo;
            this.justificacionBaja = justificacionBaja;
            this.fechaBaja = fechaBaja;
            this.estadoUsado = estadoUsado;
            this.aniosUso = aniosUso;
            this.aniosVida = aniosVida;
            this.valorResidual = valorResidual;
        }
    }
}

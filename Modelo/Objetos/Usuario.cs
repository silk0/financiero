
using System;

namespace Financiero.Modelo
{
    class Usuario : Fechas
    {
        public string usuario { set;  get; }
        public string contra { set; get; }
        public string correo { set; get; }
        public string token { get; }
        public int estado { get; }
        public int persona { set; get; }

        public Usuario(string usuario, string contra, string correo,
            DateTime fechaCreacion, DateTime fechaModificacion)
        {
            this.usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            this.contra = Cryptography.MD5(contra) ?? throw new ArgumentNullException(nameof(contra));
            this.correo = correo;
            identificador = null;
            this.fechaCreacion = fechaCreacion;
            this.fechaModificacion = fechaModificacion;
        }
        public Usuario(string usuario, string contra, string correo,
            string token, DateTime fechaCreacion, DateTime fechaModificacion)
        {
            this.usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            this.contra = Cryptography.MD5(contra) ?? throw new ArgumentNullException(nameof(contra));
            this.correo = correo;
            identificador = null;
            this.fechaCreacion = fechaCreacion;
            this.fechaModificacion = fechaModificacion;
            this.token = token;
        }
        public Usuario(string usuario, string contra, string correo)
        {
            this.usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            this.contra = Cryptography.MD5(contra) ?? throw new ArgumentNullException(nameof(contra));
            identificador = null;
            this.correo = correo;
        }
        public Usuario(string usuario, string contra)
        {
            this.usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            this.contra = Cryptography.MD5(contra) ?? throw new ArgumentNullException(nameof(contra));
            identificador = null;
        }
        public void limpiarVariables() {
            this.contra = this.usuario = null;            
        }
        
        private static string identificador;
        public static void identifadorSet(string identificador)
        {
            Usuario.identificador = identificador ;
        }
        public static string identifadorGet() {
            return Cryptography.Base64Encode(Usuario.identificador);
        }
    }
}

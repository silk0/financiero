using System;
using System.Data;
using System.Data.SqlClient;

namespace Financiero.Controlador
{
    class Bitacora
    {
        private Conexión conexión;

        public Bitacora()
        {
            this.conexión = new Conexión();
        }

        /*
         * try {
                this.conexión.conectar();
            }
            catch (Exception e) {
                throw e;
            }
            finally {
                this.conexión.desconectar();
            }
        */

        public void ingresarUsuario(Modelo.Bitacora bitacora)
        {

            try
            {
                this.conexión.conectar();
                //Creamos el comando que contendrá la query a ejecutar en el servidor
                using (SqlCommand query = this.conexión.connexion.CreateCommand())
                {

                    //Si vamos a ejecutar una consulta, especificamos como CommandType Text
                    query.CommandType = CommandType.Text;
                    //Si vamos a ejecutar un procedimiento almacenado, especificamos StoredProcedure
                    //query.CommandType= CommandType.StoredProcedure;
                    //query.CommandText="nombreDelProcedimientoAlmacenado";

                    //Especifiamos la query a ejecutar
                    query.CommandText = string.Format("INSERT INTO bitacora(tipo_descripcion,fecha_creacion) VALUES ('{0}',getdate())",bitacora.descripcion);

                    //Como es un INSERT, la query no devuelve resultados, asi que ejecutamos un ExecuteNonQuery que nos
                    //devuelve el número de filas afectadas
                    int fil = query.ExecuteNonQuery();

                    if (fil > 0)
                    {
                        //Todo ha ido bien
                    }
                    else
                    {
                        //No se ha ejecutado correctamente
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                this.conexión.desconectar();
            }
        }
    }
}

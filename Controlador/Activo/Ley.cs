using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Financiero.Controlador
{
    public class Ley
    {
        private Conexión conexión;

        public Ley()
        {
            this.conexión = new Conexión();
        }
        public async Task<bool> ingresarLey(Modelo.Activo.Ley ley)
        {
            bool b = false;

            try
            {
                this.conexión.conectar();
                await Task.Run(() =>
                {
                    //Creamos el comando que contendrá la query a ejecutar en el servidor

                    using (SqlCommand query = this.conexión.connexion.CreateCommand())
                    {                        
                        
                        using (SqlCommand query1 = this.conexión.connexion.CreateCommand())
                        {

                            //Si vamos a ejecutar una consulta, especificamos como CommandType Text
                            query1.CommandType = CommandType.Text;
                            //Especifiamos la query a ejecutar
                            query1.CommandText = string.Format("insert into tipo_ley(nombre,porcentaje,fecha_creacion,fecha_modificacion) values(" +
                                "'{0}',{1},getdate(),getdate())", ley.nombre,ley.porcentaje);

                            //Como es un INSERT, la query no devuelve resultados, asi que ejecutamos un ExecuteNonQuery que nos
                            //devuelve el número de filas afectadas                        

                            int fil = query1.ExecuteNonQuery();

                            b = fil > 0;
                        }
                        
                    }
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                this.conexión.desconectar();
            }
            return b;
        }
    }
}

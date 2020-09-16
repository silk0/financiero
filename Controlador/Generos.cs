using Financiero.Modelo;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Financiero.Controlador
{
    class Generos:Fechas
    {
        public string tipo { set; get; }
        private Conexión conexión;
        public Generos()
        {
            this.conexión = new Conexión();
        }
        public async Task<int> eliminarGenero(Modelo.Generos tipo)
        {
            int operacion = -1;
            await Task.Run(() =>
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
                        query.CommandText = string.Format("delete from generos where nombre = '{0}'", tipo.genero);

                        //Como es un INSERT, la query no devuelve resultados, asi que ejecutamos un ExecuteNonQuery que nos
                        //devuelve el número de filas afectadas
                        operacion = query.ExecuteNonQuery();
                    }
                }catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    this.conexión.desconectar();
                }            
            });
            return operacion;
        }
    
        public async Task<ArrayList> obtenerGeneros()
        {
            ArrayList datos = new ArrayList();
            await Task.Run(() =>
            {

                try
                {
                    this.conexión.conectar();
                    //Creamos el comando que contendrá la query a ejecutar en el servidor 
                    SqlCommand command = new SqlCommand("select nombre from generos " +
                        "order by nombre", this.conexión.connexion);

                    // int ---> command.ExecuteNonQuery();
                    int operacion = command.ExecuteNonQuery();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datos.Add(reader["nombre"]);
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
            });
            return datos;
        }


        public async Task<int> modificarGenero(Modelo.Generos estadoNuevo, Modelo.Generos estadoAnterior)
        {
            int operacion = -1;
            await Task.Run(() =>
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
                        query.CommandText = string.Format("update generos " +
                            "set nombre ='{0}', fecha_actualizacion = getdate() where " +
                            "nombre = '{1}'", estadoNuevo.genero, estadoAnterior.genero);
                        //Como es un INSERT, la query no devuelve resultados, asi que ejecutamos un ExecuteNonQuery que nos
                        //devuelve el número de filas afectadas
                        operacion = query.ExecuteNonQuery();
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
            });
            return operacion;
        }

        public async Task<int> ingresarGenero(Modelo.Generos generos)
        {
            int operacion = -1;

            try
            {
                await Task.Run(() =>
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
                        query.CommandText = string.Format("insert into " +
                            " generos(nombre,fecha_creacion,fecha_actualizacion) " +
                            "values ('{0}',getdate(),getdate())", generos.genero);

                        //Como es un INSERT, la query no devuelve resultados, asi que ejecutamos un ExecuteNonQuery que nos
                        //devuelve el número de filas afectadas
                        operacion = query.ExecuteNonQuery();
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
            return operacion;
        }
    }
}


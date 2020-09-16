using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace Financiero.Controlador
{
    class EstadosCivil
    {
        private Conexión conexión;
        public EstadosCivil()
        {
            this.conexión = new Conexión();
        }
        public async Task<int> eliminarEstadoCivil(Modelo.EstadoCivil estado)
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
                        query.CommandText = string.Format("delete from estado_civils where nombre = '{0}'", estado.estadoCivil);

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
        public async Task<ArrayList> obtenerEstadosCivils()
        {
            ArrayList datos = new ArrayList();
            await Task.Run(() =>
            {                
                try
                {
                    Thread.Sleep(250);
                    this.conexión.conectar();
                    //Creamos el comando que contendrá la query a ejecutar en el servidor 
                    SqlCommand command = new SqlCommand("select nombre from estado_civils " +
                            "order by nombre",this.conexión.connexion);

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

        public async Task<bool> existeEstadosCivils(string estadoCivil)
        {
            bool estadoCivilBool = false;
            await Task.Run(() =>
            {
                try
                {
                    this.conexión.conectar();
                    //Creamos el comando que contendrá la query a ejecutar en el servidor 
                    SqlCommand command = new SqlCommand(String.Format("select nombre from estado_civils " +
                            "where nombre = '{0}' order by nombre",estadoCivil), this.conexión.connexion);

                    // int ---> command.ExecuteNonQuery();
                    int operacion = command.ExecuteNonQuery();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //reader.Read() devuelve true si existe el dato en la consulta
                        estadoCivilBool = !reader.Read();                        
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
            return estadoCivilBool;
        }

        public async Task<ArrayList> obtenerEstadosCivils(String estadoCivil)
        {
            ArrayList datos = new ArrayList();
            await Task.Run(() =>
            {
                try
                {
                    Thread.Sleep(250);
                    this.conexión.conectar();
                    //Creamos el comando que contendrá la query a ejecutar en el servidor 
                    SqlCommand command = new SqlCommand(String.Format("select nombre from estado_civils " +
                            "where nombre like '%{0}%' order by nombre ", estadoCivil), this.conexión.connexion);

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

        public async Task<int> modificarEstadoCivil(Modelo.EstadoCivil estadoNuevo, Modelo.EstadoCivil estadoAnterior)
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
                        query.CommandText = string.Format("update estado_civils " +
                            "set nombre ='{0}', fecha_actualizacion = getdate() where " +
                            "nombre = '{1}'", estadoNuevo.estadoCivil, estadoAnterior.estadoCivil);                            
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

        public async Task<int> ingresarEstadoCivil(Modelo.EstadoCivil estado)
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
                            " estado_civils(nombre,fecha_creacion,fecha_actualizacion) " +
                            "values ('{0}',getdate(),getdate())",estado.estadoCivil);

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

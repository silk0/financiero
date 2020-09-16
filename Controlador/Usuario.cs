using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace Financiero.Controlador
{
    class Usuario
    {
        private Conexión conexión;

        public Usuario()
        {
            this.conexión = new Conexión();
        }
        public async Task<bool> ingresarUsuario(Modelo.Usuario usuario)
        {
            bool b =  false;

            try
            {
                this.conexión.conectar();
                await Task.Run(() =>
                {                    
                    //Creamos el comando que contendrá la query a ejecutar en el servidor

                    using (SqlCommand query = this.conexión.connexion.CreateCommand())
                    {

                        //Si vamos a ejecutar una consulta, especificamos como CommandType Text
                        query.CommandType = CommandType.Text;
                        //Si vamos a ejecutar un procedimiento almacenado, especificamos StoredProcedure
                        //query.CommandType= CommandType.StoredProcedure;
                        //query.CommandText="nombreDelProcedimientoAlmacenado";

                        string token = Modelo.Cryptography.Token();
                        query.CommandText = string.Format("select token from usuarios " +
                            "where token = '{0}'", token);

                        SqlDataReader myReader0 = query.ExecuteReader();                        

                        if (myReader0.HasRows)
                        {                            
                            ingresarUsuario(usuario);
                        }
                        else {
                            this.conexión.desconectar();
                            this.conexión.conectar();
                            using (SqlCommand query1 = this.conexión.connexion.CreateCommand())
                            {
                                
                                //Si vamos a ejecutar una consulta, especificamos como CommandType Text
                                query1.CommandType = CommandType.Text;
                                //Especifiamos la query a ejecutar
                                query1.CommandText = string.Format("insert into " +
                                "usuarios(usuario, contrasena, correo, estado, fecha_creacion, fecha_actualizacion,token) " +
                                "values ('{0}','{1}','{2}',1,getdate(),getdate(),'{3}')", usuario.usuario, usuario.contra, usuario.correo, token);

                                //Como es un INSERT, la query no devuelve resultados, asi que ejecutamos un ExecuteNonQuery que nos
                                //devuelve el número de filas afectadas                        

                                int fil = query1.ExecuteNonQuery();

                                b = fil > 0;
                            }
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

        public async Task<bool> consultarExiste(Modelo.Usuario usuario)
        {
            bool usuar = false;
            try
            {
                this.conexión.conectar();
                //Creamos el comando que contendrá la query a ejecutar en el servidor
                await Task.Run(() => { 
                    using (SqlCommand query = this.conexión.connexion.CreateCommand())
                    {

                        //Si vamos a ejecutar una consulta, especificamos como CommandType Text
                        query.CommandType = CommandType.Text;
                        //Si vamos a ejecutar un procedimiento almacenado, especificamos StoredProcedure
                        //query.CommandType= CommandType.StoredProcedure;
                        //query.CommandText="nombreDelProcedimientoAlmacenado";

                        //Especifiamos la query a ejecutar
                        query.CommandText = string.Format("select usuario FROM usuarios " +
                            "where usuario = '{0}'", usuario.usuario);

                        //Ejecutar el comando SQL
                        SqlDataReader myReader = query.ExecuteReader();

                        usuar = myReader.HasRows;
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
            return usuar;
        }
        public async Task<Modelo.Usuario> consultarUsuario(string token)
        {
            Modelo.Usuario usuar = null;
            try
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(250);
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
                        query.CommandText = string.Format("select id, usuario, contrasena, " +
                            "correo, fecha_actualizacion, fecha_creacion from usuarios " +
                            "where estado = 1 and token = '{0}'", token);

                        //Ejecutar el comando SQL
                        SqlDataReader myReader1 = query.ExecuteReader();

                        if (myReader1.Read())
                        {
                            usuar = new Modelo.Usuario(
                                myReader1.GetString(1),
                                myReader1.GetString(2),
                                myReader1.GetString(3),
                                myReader1.GetDateTime(4),
                                myReader1.GetDateTime(5));
                            Modelo.Usuario.identifadorSet(myReader1.GetInt32(0) + "");
                        }
                        myReader1.Close();

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
            return usuar;
        }

        public async Task<Modelo.Usuario> consultarUsuario(Modelo.Usuario usuario)
        {
            Modelo.Usuario usuar = null;
            try
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(250);
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
                        query.CommandText = string.Format("select id, usuario, contrasena, " +
                            "correo, fecha_actualizacion, fecha_creacion FROM usuarios " +
                            "where estado = 1 and usuario = '{0}' and " +
                            "contrasena = '{1}'", usuario.usuario, usuario.contra);

                        //Ejecutar el comando SQL
                        SqlDataReader myReader1 = query.ExecuteReader();

                        if (myReader1.Read())
                        {
                            usuar = new Modelo.Usuario(
                                myReader1.GetString(1),
                                myReader1.GetString(2),
                                myReader1.GetString(3),
                                myReader1.GetDateTime(4),
                                myReader1.GetDateTime(5));
                            Modelo.Usuario.identifadorSet(myReader1.GetInt32(0) + "");
                        }
                        myReader1.Close();
                        
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
            return usuar;
        }

        public async Task<string> consultarUsuarioCorreo(string correo)
        {
            string token = " ";
            try
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(250);
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
                        query.CommandText = string
                            .Format("select token from usuarios where estado = 1 and correo = '{0}'", correo);

                        //Ejecutar el comando SQL
                        SqlDataReader myReader1 = query.ExecuteReader();

                        if (myReader1.Read())
                        {
                            token =  myReader1.GetString(0);
                        }
                        Console.WriteLine(string.Format("token: {0}",token));
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
            return token;
        }
        public void actualizarUsuario(Modelo.Usuario usuario) { }
    }
}

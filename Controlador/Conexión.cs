
using System.Data.SqlClient;

namespace Financiero.Controlador
{
    class Conexión
    {
        private SqlConnection connection { get; }


        public Conexión()
        {
            this.connection = new SqlConnection("server=DESKTOP-B2L4RGL ; database=financiero ; integrated security = true");
            //this.connection = new SqlConnection("Data Source = SQL5063.site4now.net; Initial Catalog = DB_A65670_firmyn1; User Id = DB_A65670_firmyn1_admin; Password = juancarlos2");
        }

        public void conectar() => this.connection.Open();

        public void desconectar() => this.connection.Close();

        public SqlConnection connexion => this.connection;

    }
}

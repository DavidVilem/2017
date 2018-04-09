using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMySql.Connection
{
    class Conexion
    {
        private String user;
        private String password;
        private String server;
        private String dataBase;
        MySqlConnectionStringBuilder cadenaConection;//variable de coneccion
        MySqlConnection connection;

        public MySqlConnection Connection1
        {
            get { return connection; }
            set { connection = value; }
        }
        MySqlCommand cmd;
        public Conexion()
        {
            user = "root";
            password = "****";
            server = "localhost";
            dataBase = "ejemplo_usuario";
            conectar();
        }
        public void conectar()
        {
            try
            {
                //var connection = new MySqlConnection("DataSource=127.0.0.1;Database=ejemplo_usuario;User Id=prueba;Password=123;SSL Mode=Required");
                cadenaConection = new MySqlConnectionStringBuilder
                {
                    Server = server,
                    UserID = user,
                    Password = password,
                    Database = dataBase

                };
            connection = new MySqlConnection(cadenaConection.ToString());
                cmd = connection.CreateCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "PROBLEMAS EN LA CON: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

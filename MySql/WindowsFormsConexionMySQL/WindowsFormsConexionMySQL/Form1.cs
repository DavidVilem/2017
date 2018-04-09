using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsConexionMySQL
{
    public partial class Form1 : Form
    {
        private MySqlSslMode none;

        public Form1()
        {
            
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var conexion = new MySqlConnectionStringBuilder
                {
                    Server = "localhost",
                    UserID = "root",
                    Password = "gestapo12",
                    Database = "prueba",
                    Port = 3306,
                    PersistSecurityInfo = true,
                    SslMode = none
                };
                var con = new MySqlConnection(conexion.ToString());
                con.Open();
                MessageBox.Show("Conectado a la base de datos");

            }
            catch (Exception)
            {
                MessageBox.Show("NO ESTA Conectado a la base de datos");
            }
        }
    }
}

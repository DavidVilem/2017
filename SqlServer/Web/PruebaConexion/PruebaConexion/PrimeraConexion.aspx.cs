using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaConexion
{
    public partial class PrimeraConexion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // string strConn = "Server=.;Database=Facturacion01, Integrated Security=True";
            string strConn = @"Data Source = BLACKSUNJ-PC; Initial Catalog = Conexion; Integrated Security = True";
            SqlConnection conn = new SqlConnection(strConn);
            string strSQL = "SELECT Nombre, Apellido, Edad FROM Alumno ORDER BY Nombre";
            SqlCommand command = new SqlCommand(strSQL, conn);

            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.Label1.Text += "<br />Nombre:" + reader["Nombre"] + "Apellido: " + reader["Apellido"];
            }
        }
    }
}
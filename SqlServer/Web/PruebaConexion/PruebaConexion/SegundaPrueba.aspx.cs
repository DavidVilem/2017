using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaConexion
{
    public partial class SegundaPrueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strConn = @"Data Source = BLACKSUNJ-PC; Initial Catalog = Conexion; Integrated Security = True";
            SqlConnection conn = new SqlConnection(strConn);
            string strSQL = "SELECT Nombre, Apellido, Edad, Profesion FROM Alumno ORDER BY Nombre";
            SqlCommand command = new SqlCommand(strSQL, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            this.Repeater1.DataSource = reader;
            this.Repeater1.DataBind();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCRUD
{
    public partial class deletebook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Alumno where id_Alumno = @id_Alumno", con);
                cmd.Parameters.AddWithValue("@id_Alumno", txtAlumnoid.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Label1.Text = "Alumno Deleted Successfully!";
                }
                else
                {
                    Label1.Text = "Sorry! Could Not Delete Alumno.";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "Error --> " + ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
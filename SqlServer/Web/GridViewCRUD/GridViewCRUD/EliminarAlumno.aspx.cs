using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewCRUD
{
    public partial class EliminarAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Alumno Where id_Alumno = @id_Alumno", con);
                cmd.Parameters.AddWithValue("@id_Alumno", TextBoxID.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    LabelMensajes.Text = "Alumno borrado exitosamente";
                }
                else
                {
                    LabelMensajes.Text = "Lo siento, no se pudo eliminar";
                }
            }
            catch (Exception ex)
            {
                LabelMensajes.Text = "Error --> " + ex.Message;
                
            }
            finally
            {
                con.Close();
            }
        }
    }
}
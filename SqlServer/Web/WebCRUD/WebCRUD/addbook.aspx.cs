using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCRUD
{
    public partial class addbook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Alumno(Nombre,Apellido,Edad,id_Carrera) values(@Nombre,@Apellido,@Edad,@id_Carrera)", con);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                cmd.Parameters.AddWithValue("@Edad", txtEdad.Text);
                cmd.Parameters.AddWithValue("@id_Carrera", txtCarrera.Text);
                

                int count = cmd.ExecuteNonQuery();
                if (count == 1)
                    lblMsg.Text = "Book [" + txtNombre.Text + "] has been added!";
                else
                    lblMsg.Text = "Could not add Alumno!";
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error --> " + ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
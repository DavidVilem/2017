using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewCRUD
{
    public partial class AgregarAlumno : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("insert into Alumno (Nombre,Apellido,Edad,id_Carrera) values(@Nombre,@Apellido,@Edad,@id_Carrera)", con);
                cmd.Parameters.AddWithValue("@Nombre", TxtBoxNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", TxtBoxApellido.Text);
                cmd.Parameters.AddWithValue("@Edad", TxtBoxEdad.Text);
                cmd.Parameters.AddWithValue("@id_Carrera", txtBoxCarrera.Text);

                int count = cmd.ExecuteNonQuery();
                if (count == 1)
                {
                    lblMensajes.Text = "Alumno [" + TxtBoxNombre.Text + "] ha sido agregado";
                }
                else
                {
                    lblMensajes.Text = "No se puedo agregar al alumno";
                }
            }
            catch (Exception ex)
            {
                lblMensajes.Text ="Error --> "+ ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
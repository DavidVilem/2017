using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewCRUD
{
    public partial class EditarAlumno : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("Select * from Alumno where id_Alumno = @id_Alumno", con);
                cmd.Parameters.AddWithValue("@id_Alumno", TxtBoxId.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TxtBoxNombre.Text = dr["Nombre"].ToString();
                    TxtBoxApellido.Text = dr["Apellido"].ToString();
                    TxtBoxEdad.Text = dr["Edad"].ToString();
                    txtBoxCarrera.Text = dr["id_Carrera"].ToString();
                    Button1.Enabled = true;
                }
                else
                {
                    lblMensajes.Text = "Lo siento, Alumno_id no valido"; 
                    Button1.Enabled=false;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                lblMensajes.Text = "Error -->" + ex.Message;
            }
            finally
            {
                con.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Alumno set Nombre=@Nombre, Apellido = @Apellido, Edad = @Edad, id_Carrera = @id_Carrera where id_Alumno = @id_Alumno", con);
                cmd.Parameters.AddWithValue("@id_Alumno", TxtBoxId.Text);
                cmd.Parameters.AddWithValue("@Nombre", TxtBoxNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", TxtBoxApellido.Text);
                cmd.Parameters.AddWithValue("@Edad", TxtBoxEdad.Text);
                cmd.Parameters.AddWithValue("@id_Carrera", txtBoxCarrera.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    lblMensajes.Text = "Actualizacion correcta";
                }
                else
                {
                    lblMensajes.Text = "Lo siento, no se puede actualizar";
                }
            }
            catch (Exception ex)
            {
                lblMensajes.Text = "Error -->" + ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
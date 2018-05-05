using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCRUD
{
    public partial class updatebooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetDetails_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Alumno where id_Alumno = @id_Alumno", con);
                cmd.Parameters.AddWithValue("@id_Alumno", TextBox1.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // display data in textboxes
                    TextBox2.Text = dr["Nombre"].ToString();
                    TextBox3.Text = dr["Apellido"].ToString();
                    TextBox4.Text = dr["Edad"].ToString();
                    TextBox5.Text = dr["id_Carrera"].ToString();
                    btnUpdate.Enabled = true;
                }
                else
                {
                    Label2.Text = "Sorry! Invalid Book Id";
                    btnUpdate.Enabled = false;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Label2.Text = "Error --> " + ex.Message;
            }
            finally
            {
                con.Close();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Alumno set Nombre=@Nombre, Apellido = @Apellido, Edad = @Edad, id_Carrera = @id_Carrera where id_Alumno = @id_Alumno", con);
                cmd.Parameters.AddWithValue("@id_Alumno", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Nombre", TextBox2.Text);
                cmd.Parameters.AddWithValue("@Apellido", TextBox3.Text);
                cmd.Parameters.AddWithValue("@Edad", TextBox4.Text);
                cmd.Parameters.AddWithValue("@id_Carrera", TextBox5.Text);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    Label2.Text = "Updated Successfully!";
                }
                else
                {
                    Label2.Text = "Sorry! Could not update";
                }
            }
            catch (Exception ex)
            {
                Label2.Text = "Error --> " + ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
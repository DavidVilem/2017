using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewCRUD
{
    public partial class FromGridCRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection(Database.ConnectionString);
                SqlDataAdapter da = new SqlDataAdapter("select * from Alumno order by Nombre", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "books");
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditarAlumno.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarAlumno.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarAlumno.aspx");
        }
    }
}
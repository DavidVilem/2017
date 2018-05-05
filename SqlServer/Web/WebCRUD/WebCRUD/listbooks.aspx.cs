using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCRUD
{
    public partial class listbooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("select * from Alumno order by Nombre", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "books");
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}
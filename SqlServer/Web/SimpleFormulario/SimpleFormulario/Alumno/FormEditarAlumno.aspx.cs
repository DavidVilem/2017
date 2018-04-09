using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SimpleFormulario.Alumno;
using SimpleFormulario.Models;

namespace SimpleFormulario.Alumno
{
    public partial class FormEditarAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                String IdUser = (String)Request.Params["IdUser"];
                //this.txtNombre.Text = IdUser;
                AlumnoDAO ud = new AlumnoDAO();
                Alumnos u = new Alumnos();
                u = ud.EditarId(Convert.ToInt32(IdUser));
                this.txtId.Text = u.Id.ToString();
                this.txtNombre.Text = u.Nombre;
                this.txtApellido.Text = u.Apellido;
                this.txtEdad.Text = u.Edad.ToString();
                this.TextProfesion.Text = u.Profesion;

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            AlumnoDAO ud = new AlumnoDAO();
            String IdUser = (String)Request.Params["IdUser"];
            //(Convert.ToInt32(IdUser))
            if (ud.eliminar((Convert.ToInt32(IdUser))))
            {
                Response.Redirect("FormListaAlumnos.aspx");
            }
            else
            {
                Label1.Text = "Error";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SimpleFormulario.Models.Alumnos u = new SimpleFormulario.Models.Alumnos();
            this.txtId.Text = u.Id.ToString();
            this.txtNombre.Text = u.Nombre;
            this.txtApellido.Text = u.Apellido;
            this.txtEdad.Text = u.Edad.ToString();
            this.TextProfesion.Text = u.Profesion;
            AlumnoDAO ud = new AlumnoDAO();
            String IdUser = (String)Request.Params["IdUser"];
            //u = ud.actualizar(Convert.ToInt32(IdUser));
            if (ud.actualizar(u))
            {
                Response.Redirect("FormListaAlumnos.aspx");
            }
            else
            {
                Label1.Text = "Error";
            }
        }


    }
}
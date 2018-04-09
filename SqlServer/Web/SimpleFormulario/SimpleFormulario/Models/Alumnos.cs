using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleFormulario.Models
{
    public class Alumnos
    {
        private int id;
        private String nombre;
        private String apellido;
        private int edad;
        private String profesion;

        public Alumnos()
        {

        }

        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        public String Nombre
        {
            set { this.Nombre = value; }
            get { return this.Nombre; }
        }
        public String Apellido
        {
            set { this.Apellido = value; }
            get { return this.Apellido; }
        }
        public int Edad
        {
            set { this.Edad = value; }
            get { return this.Edad; }
        }
        public String Profesion
        {
            set { this.Profesion = value; }
            get { return this.Profesion; }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SimpleFormulario.DBase
{
    public class Conexion
    {
        public SqlConnection conn;
        public Conexion()
        {
            conn = new SqlConnection(@"Data Source = BLACKSUNJ-PC; Initial Catalog = Alumno; Integrated Security = True");
        }
        public SqlConnection Conn { get; set; }
    }
}
using FormMySql.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMySql.Controller
{
    class Usuario_controller : Controller
    {
        private Usuario_modelo modelo;
        private string tabla;

        public Usuario_controller()
        {
            modelo = new Usuario_modelo();
            tabla = "usuario";
        }
        //Metodos
        public override bool Eliminar()
        {
            string sql = GenerarEliminarSql(tabla, new Parametro("idUsuario", modelo.IdUsuario.ToString()));
            return ExecuteQuery(sql, -1);
        }

        public override bool Guardar()
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("idTipo", modelo.IdTipo.ToString()),
                new Parametro("nombre", modelo.Nombre, 0),
                new Parametro("apelliod", modelo.Apellido, 0),
                new Parametro("telefono", modelo.Telefono, 0),
                new Parametro("correo", modelo.Correo, 0)
            };
            string sql = GenerarInsertarSql(tabla, parametros);
            return ExecuteQuery(sql, 0);
        }

        public override bool Modificar()
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("idTipo", modelo.IdTipo.ToString()),
                new Parametro("nombre", modelo.Nombre, 0),
                new Parametro("apelliod", modelo.Apellido, 0),
                new Parametro("telefono", modelo.Telefono, 0),
                new Parametro("correo", modelo.Correo, 0)
            };
            string sql = GenerarActualizarSql(tabla, parametros, new Parametro("idUsuario", modelo.IdUsuario.ToString()));
            return ExecuteQuery(sql, 1);
        }

        public string Tabla { get => tabla; set => tabla = value; }
        internal Usuario_modelo Modelo { get => modelo; set => modelo = value; }

        
    }
}

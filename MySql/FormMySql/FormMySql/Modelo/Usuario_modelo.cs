using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMySql.Modelo
{
    class Usuario_modelo
    {
        private int idUsuario;
        private int idTipo;
        private string nombre;
        private string telefono;
        private string apellido;
        private string correo;

        public Usuario_modelo()
        {

        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }

    }
}

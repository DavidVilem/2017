using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMySql.Controller
{
    class Parametro
    {
        private String campo;
        private String valor;
        private String comparador;

        //Constructores**************************************************************************************************
        public Parametro()
        {
            Comparador = " = ";
        }
        public Parametro(String campo, String valor)
        {
            Campo = campo;
            Valor = valor;
            Comparador = " = ";
        }
        public Parametro(String campo, String valor, int campoString)
        {
            Campo = campo;
            Valor = string.Format("'{0}'", valor);
            Comparador = " = ";
        }
        public Parametro(String campo, String valor, String comparador)
        {
            Campo = campo;
            Valor = valor;
            Comparador = comparador;
        }
        //Propiedades***************************************************************************************************
        public String Comparador
        {
            get { return comparador; }
            set { comparador = value; }
        }

        public String Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public String ValorString
        {
            get { return valor; }
            set { valor = "'" + value + "'"; }
        }
        public String Campo
        {
            get { return campo; }
            set { campo = value; }
        }


    }
}

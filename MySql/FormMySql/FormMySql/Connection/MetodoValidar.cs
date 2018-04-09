using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMySql.Connection
{
    class MetodoValidar
    {
        //Metodo para validar campos**************************************************************************************************
        public static void Validar_Numero(KeyPressEventArgs e)
        {
            e.Handled = false;
            if (Char.IsDigit(e.KeyChar)) { }
            else if (Char.IsControl(e.KeyChar)) { }
            else if (Char.IsSeparator(e.KeyChar)) { }
            else { e.Handled = true; }
        }

        public static void Validar_Texto(KeyPressEventArgs e)
        {
            e.Handled = false;
            if (Char.IsLetter(e.KeyChar)) { }
            else if (Char.IsControl(e.KeyChar)) { }
            else if (Char.IsSeparator(e.KeyChar)) { }
            else if (Char.IsDigit(e.KeyChar)) { }
            else { e.Handled = true; }
        }
        public static void ValidarTexto(System.Windows.Forms.TextBox vTextBox, KeyPressEventArgs e, int num)
        {
            e.Handled = false;
            if (vTextBox.Text.Length <= num - 1)
            {
                if (Char.IsLetter(e.KeyChar)) { }
                else if (Char.IsControl(e.KeyChar)) { }
                else if (Char.IsSeparator(e.KeyChar)) { }
                else if (Char.IsDigit(e.KeyChar)) { }
                else { e.Handled = true; }
            }
            else
            {
                e.Handled = true;
            }
        }
        public static void ValidarCorreo(System.Windows.Forms.TextBox vTextBox, KeyPressEventArgs e, int num)
        {
            e.Handled = false;
            if (vTextBox.Text.Length <= num - 1)
            {
                if (e.KeyChar == '@') { }
                else if (e.KeyChar == '.') { }
                else if (e.KeyChar == '_') { }
                else if (Char.IsLetter(e.KeyChar)) { }
                else if (Char.IsControl(e.KeyChar)) { }
                else if (Char.IsSeparator(e.KeyChar)) { }
                else if (Char.IsDigit(e.KeyChar)) { }

                else { e.Handled = true; }
            }
            else
            {
                e.Handled = true;
            }
        }
        public static void ValidarNumero(System.Windows.Forms.TextBox vTextBox, KeyPressEventArgs e, int num)
        {
            e.Handled = false;
            if (vTextBox.Text.Length <= num - 1)
            {
                if (Char.IsDigit(e.KeyChar)) { }
                else if (Char.IsControl(e.KeyChar)) { }
                else if (Char.IsSeparator(e.KeyChar)) { }
                else { e.Handled = true; }
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void ValidarDecimales(System.Windows.Forms.TextBox vTextBox, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < vTextBox.Text.Length; i++)
            {
                if (vTextBox.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }
        public static Boolean ValidarCorreo(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool Pregunta(string detalle, string titulo)
        {
            bool resp = false;
            var respuesta = MessageBox.Show(detalle, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.No)
            {
                resp = false;
            }
            else if (respuesta == DialogResult.Yes)
            {
                resp = true;
            }
            return resp;
        }
    }
}

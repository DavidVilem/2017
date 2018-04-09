using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormMySql.Connection;
using System.IO;

namespace FormMySql.Controller
{
    abstract class Controller
    {
        protected String sql;
        protected MySqlConnection conection;
        protected MySqlCommandBuilder cmb;
        protected DataSet ds;
        protected MySqlDataAdapter da;
        protected MySqlCommand comando;
        //propiedades*********************************************************************************************************
        public String Sql
        {
            get { return sql; }
            set { sql = value; }
        }
        public DataSet DataSetResult
        {
            get { return ds; }
            set { ds = value; }
        }
        //contrcutor*********************************************************************************************************
        public Controller()
        {
            ds = new DataSet();
            Conexion cnn = new Conexion();
            conection = cnn.Connection1;
        }
        //metodos abstractos*********************************************************************************************************
        public abstract bool Guardar();
        public abstract bool Modificar();
        public abstract bool Eliminar();
        //*********************************************************************************************************
        //metodos interactivos con BD*********************************************************************************************************

        public virtual bool ExecuteQuery(String sqlQuery, int mensaje)//0- Guardar,1 - Modificar, -1 - Eliminar
        {//inserta,elimina  modifica
            String mensajeSalida = "DATOS GUARDADOS CON EXITO";
            if (mensaje > 0) { mensajeSalida = "DATOS MOFICADOS CON EXITO"; }
            else if (mensaje < 0) { mensajeSalida = "DATOS ELIMINADOS CON EXITO"; }
            bool resp = false;
            try
            {
                conection.Open();
                comando = new MySqlCommand(sqlQuery, conection);
                int num = comando.ExecuteNonQuery();
                if (num > 0)
                {
                    resp = true;
                    MessageBox.Show(mensajeSalida, "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "PROBLEMAS CON LA TRANSACCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "PROBLEMAS CON LA TRANSACCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("" + sqlQuery, "Sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conection.Close();
            return resp;
        }

        public DataTable ConsultarTabla()//realiza una consulta SQL y la muestra en DataSource
        {
            try
            {
                ds.Tables.Clear();
                da = new MySqlDataAdapter(sql, conection);
                cmb = new MySqlCommandBuilder(da);
                da.Fill(ds, "Consulta");
                return DataSetResult.Tables["Consulta"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "ERROR EN LA INSTRUCCION A LA BASE DE DATOS \n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        //*********************************************************************************************************
        //metodos de ayuda para consultas ( generadores de consultas SQL )
        //*********************************************************************************************************
        public String GenerarInsertarSql(String tabla, List<Parametro> parametros)
        {
            String query = "";
            if (parametros.Count > 0)
            {
                query = string.Format("INSERT INTO {0} ", tabla);
                query += " (";
                for (int i = 0; i < parametros.Count; i++)
                {
                    query += string.Format("{0}", parametros[i].Campo);
                    if (i < parametros.Count - 1) { query += ","; }
                }
                query += " )";
                query += " value (";
                for (int i = 0; i < parametros.Count; i++)
                {
                    query += string.Format("{0}", parametros[i].Valor);
                    if (i < parametros.Count - 1) { query += ","; }
                }
                query += " )";
            }
            else
            {
                MessageBox.Show("No hay parametros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return query;
        }
        public String GenerarActualizarSql(String tabla, List<Parametro> parametros, Parametro id)
        {
            String query = "";
            if (parametros.Count > 0)
            {
                query = string.Format("UPDATE {0} set ", tabla);
                for (int i = 0; i < parametros.Count; i++)
                {
                    query += string.Format("{0} {1} {2}", parametros[i].Campo, parametros[i].Comparador, parametros[i].Valor);
                    if (i < parametros.Count - 1) { query += " , "; }
                }
                query += string.Format(" WHERE {0} {1} {2}", id.Campo, id.Comparador, id.Valor);
            }
            else
            {
                MessageBox.Show("No hay parametros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return query;
        }
        public String GenerarEliminarSql(String tabla, Parametro id)
        {
            String query = "";
            query = string.Format("DELETE FROM {0} WHERE ", tabla);
            query += string.Format("{0} {1} {2}", id.Campo, id.Comparador, id.Valor);
            return query;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Conexion
/// </summary>
public class Conexion
{

    private SqlConnection conexion;

    public Conexion()
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["conectar"].ConnectionString;
        this.conexion = new SqlConnection(s);
    }
    public void Conectar()
    {
        this.conexion.Open();
    }
    public void Cerrar()
    {
        this.conexion.Close();
    }
    public SqlConnection GetConnection()
    {
        return this.conexion;
    }
}
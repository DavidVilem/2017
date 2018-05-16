using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;

/// <summary>
/// Descripción breve de Usuarios
/// </summary>
public class Usuarios : Conexion
{
    private SqlDataReader registro;
    private SqlConnection con;

    public Usuarios()
    {
        this.con = GetConnection();
    }

    public void jquery()
    {
        ScriptManager.ScriptResourceMapping.AddDefinition
            (
                "jquery", new ScriptResourceDefinition
                {
                    Path = "~/public/js/jquery.js",
                    DebugPath = "~/public/js/jquery.js",
                    CdnSupportsSecureConnection = true,
                    LoadSuccessExpression = "window.JQuery"
                }
            );
    }

    public SqlDataReader getUsuarios()
    {
        Conectar();
        String sql = "select * from usuarios order by nombre";
        SqlCommand cm = new SqlCommand(sql, this.con);
        this.registro = cm.ExecuteReader();
        return this.registro;
    }

    public void Insertar(String nombre, String correo)
    {
        Conectar();
        String sql = "insert into usuarios " + 
            "values " + 
            "('" + nombre + "','" + correo + "')";
        SqlCommand comando = new SqlCommand(sql, this.con);
        comando.ExecuteNonQuery();
        Cerrar();
    }
}
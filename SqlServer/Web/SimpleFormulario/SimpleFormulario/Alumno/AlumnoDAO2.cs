using SimpleFormulario.DBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SimpleFormulario.Alumno
{
    public class AlumnoDAO2 : Conexion
    {
        SqlCommand comm;
        SqlDataReader reader;
        public UsuariosDAO() : base()
        {

        }
        public SqlDataReader listaRs()
        {
            reader = null;
            try
            {
                conn.Open();
                comm = new SqlCommand("SELECT * FROM Usuarios ORDER BY Nombre", conn);
                reader = comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine("Es la escepcion. ", e.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return reader;
        }
        public List<Usuarios> listar()
        {
            List<Usuarios> lp = new List<Usuarios>();

            try
            {
                conn.Open();
                comm = new SqlCommand("SELECT * from Usuarios", conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Usuarios p = new Usuarios();
                    p.IdUsuario = Convert.ToInt32((reader["idUsuario"].ToString()));
                    p.Identificacion = (reader["identificacion"].ToString());
                    p.Nombre = (reader["nombre"].ToString());
                    p.Email = (reader["email"].ToString());
                    p.Password = (reader["password"].ToString());

                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Es la escepcion. ", e.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return lp;
        }
        public bool insertar(Usuarios usuario)
        {
            bool res = false;
            comm = new SqlCommand("insert into usuarios (identificacion, nombre, email, password) values (@id, @nom,@ema,HASHBYTES('MD5',@pass))", conn);
            try
            {
                conn.Open();
                comm.Parameters.AddWithValue("@id", usuario.Identificacion);
                comm.Parameters.AddWithValue("@nom", usuario.Nombre);
                comm.Parameters.AddWithValue("@ema", usuario.Email);
                comm.Parameters.AddWithValue("@pass", usuario.Password);


                int i = comm.ExecuteNonQuery();
                if (i > 0)
                {
                    res = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Es la escepcion.", e.Message);
            }
            finally
            {
                conn.Close();
            }
            return res;
        }
        public bool actualizar(Usuarios usuario)
        {
            bool res = false;
            comm = new SqlCommand("UPDATE Usuarios set Identificacion=@id, Nombre=@nom, Email = @ema, Password=@pass where IdUsuario = @idusu", conn);

            try
            {
                conn.Open();
                comm.Parameters.AddWithValue("@id", usuario.Identificacion);
                comm.Parameters.AddWithValue("@nom", usuario.Nombre);
                comm.Parameters.AddWithValue("@ema", usuario.Email);
                comm.Parameters.AddWithValue("@pass", usuario.Password);
                comm.Parameters.AddWithValue("@idusu", usuario.IdUsuario);


                int i = comm.ExecuteNonQuery();
                if (i > 0)
                {
                    res = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Es la escepcion.", e.Message);
            }
            finally
            {
                conn.Close();
            }
            return res;

        }
        public bool eliminar(int IdUsuario)
        {
            bool res = false;
            comm = new SqlCommand("DELETE FROM Usuarios where idUsuario =" + IdUsuario, conn);
            try
            {
                conn.Open();
                int i = comm.ExecuteNonQuery();
                if (i > 0)
                {
                    res = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Es la escepcion.", e.Message);
            }
            finally
            {
                conn.Close();
            }
            return res;

        }
        public Usuarios Validar(string email, string password)
        {
            Usuarios u = null;
            try
            {
                conn.Open();
                string sql = "select* from Usuarios where Email = '" + email + "' and Password = '" + password + "'";
                //comm = new SqlCommand("Select * from Usuarios where email=" + email + " And password = HASHBYTES('MD5','"+ password +"')");
                comm = new SqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    u = new Usuarios();
                    u.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    u.Identificacion = reader["Identificacion"].ToString();
                    u.Nombre = reader["Nombre"].ToString();
                    u.Email = reader["Email"].ToString();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Es la escepcion.", e.Message);
            }
            finally
            {
                conn.Close();
            }
            return u;
        }
        public Usuarios EditarId(int IdUsuario)
        {
            Usuarios u = null;
            try
            {
                conn.Open();
                string sql = "select * from Usuarios where IdUsuario = " + IdUsuario;
                //comm = new SqlCommand("Select * from Usuarios where email=" + email + " And password = HASHBYTES('MD5','"+ password +"')");
                comm = new SqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    u = new Usuarios();
                    u.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    u.Identificacion = reader["Identificacion"].ToString();
                    u.Nombre = reader["Nombre"].ToString();
                    u.Email = reader["Email"].ToString();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Es la escepcion.", e.Message);
            }
            finally
            {
                conn.Close();
            }
            return u;
        }
    }
}
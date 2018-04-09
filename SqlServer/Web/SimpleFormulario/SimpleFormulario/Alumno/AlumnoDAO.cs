using SimpleFormulario.DBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SimpleFormulario.Models;

namespace SimpleFormulario.Alumno
{
    public class AlumnoDAO : Conexion
    {
        SqlCommand comm;
        SqlDataReader reader;
        public AlumnoDAO() : base()
        {

        }

        public Alumnos EditarId(int Id)
        {
            Alumnos u = null;
            try
            {
                conn.Open();
                string sql = "select * from Alumnos where Id = " + Id;
                //comm = new SqlCommand("Select * from Usuarios where email=" + email + " And password = HASHBYTES('MD5','"+ password +"')");
                comm = new SqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    u = new Alumnos();
                    u.Id = Convert.ToInt32(reader["Id"]);
                    u.Nombre = reader["Nombre"].ToString();
                    u.Apellido = reader["Apellido"].ToString();
                    u.Edad = Convert.ToInt32(reader["Edad"]);
                    u.Profesion = reader["Profesion"].ToString();;

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
        public bool insertar(SimpleFormulario.Models.Alumnos alumno)
        {
            bool res = false;
            comm = new SqlCommand("insert into alumno (id, nombre, apellido, edad, profesion) values (@i, @nom,@ape,@eda,@pro)", conn);
            try
            {
                conn.Open();
                comm.Parameters.AddWithValue("@i", alumno.Id);
                comm.Parameters.AddWithValue("@nom", alumno.Nombre);
                comm.Parameters.AddWithValue("@ape", alumno.Apellido);
                comm.Parameters.AddWithValue("@eda", alumno.Edad);
                comm.Parameters.AddWithValue("@pro", alumno.Profesion);

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
        public bool eliminar(int Id)
        {
            bool res = false;
            comm = new SqlCommand("DELETE FROM Alumno where Id =" + Id, conn);
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
        public bool actualizar(SimpleFormulario.Models.Alumnos alumno)
        {
            bool res = false;
            comm = new SqlCommand("UPDATE Alumnos set Nombre=@nom, Apellido = @ape, Edad=@eda, Profesion=@pro where Id = @i", conn);

            try
            {
                conn.Open();
                comm.Parameters.AddWithValue("@i", alumno.Id);
                comm.Parameters.AddWithValue("@nom", alumno.Nombre);
                comm.Parameters.AddWithValue("@ape", alumno.Apellido);
                comm.Parameters.AddWithValue("@eda", alumno.Edad);
                comm.Parameters.AddWithValue("@pro", alumno.Profesion);


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
    }
}
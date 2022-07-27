using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ClienteDBManager
    {
        static string cadenaConexion;
        static SqlConnection conexion;
        static SqlCommand comando;

        static ClienteDBManager()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=BEAUTY_LIFE_DB;Integrated Security = True";
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static Controlador<Cliente> Leer(int estaActivo)
        {
            Cliente cliente = null;
            Controlador<Cliente> controladorCliente = new Controlador<Cliente>();

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM CLIENTES WHERE ESTA_ACTIVO = {estaActivo}";
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    cliente = new Cliente((DateTime)lector["TURNO"], lector["NOMBRE"].ToString(), lector["APELLIDO"].ToString(), lector["DNI"].ToString(), lector["DIRECCION"].ToString());
                    _ = controladorCliente + cliente;
                }

                lector.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return controladorCliente;
        }

        public static void Cargar(Cliente cliente)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO CLIENTES(NOMBRE, APELLIDO, DNI, DIRECCION, TURNO, ESTA_ACTIVO)" +
                                      $"VALUES(@nombre, @apellido, @dni, @direccion, @turno, {1})";
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@dni", cliente.Dni);
                comando.Parameters.AddWithValue("@direccion", cliente.Direccion);
                comando.Parameters.AddWithValue("@turno", cliente.Turno);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Eliminar(int ID)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"DELETE FROM CLIENTES WHERE ID_CLIENTE = {ID}";

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Alta(int ID)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE CLIENTES SET ESTA_ACTIVO = 1 WHERE ID_CLIENTE = {ID}";

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Baja(int ID)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE CLIENTES SET ESTA_ACTIVO = 0 WHERE ID_CLIENTE = {ID}";

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Modificacion(Cliente cliente)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE CLIENTES SET NOMBRE = @nombre, APELLIDO = @apellido, DNI = @dni, DIRECCION = @direccion, TURNO = @turno WHERE ID_CLIENTE = {cliente.Id}";
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@dni", cliente.Dni);
                comando.Parameters.AddWithValue("@direccion", cliente.Direccion);
                comando.Parameters.AddWithValue("@turno", cliente.Turno);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}

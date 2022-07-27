using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ProductoDBManager
    {
        static string cadenaConexion;
        static SqlConnection conexion;
        static SqlCommand comando;

        static ProductoDBManager()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=BEAUTY_LIFE_DB;Integrated Security = True";
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static Controlador<Producto> Leer()
        {
            Producto producto = null;
            Controlador<Producto> controladorProducto = new Controlador<Producto>();

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM PRODUCTOS";
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    producto = new Producto(lector["MARCA"].ToString(), (float)Convert.ToDouble(lector["PRECIO"]), lector["DESCRIPCION"].ToString());
                    _ = controladorProducto + producto;
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

            return controladorProducto;
        }

        public static void Cargar(Producto producto)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO PRODUCTOS(MARCA, DESCRIPCION, PRECIO)" +
                                      $"VALUES(@marca, @descripcion, @precio)";
                comando.Parameters.AddWithValue("@marca", producto.Marca);
                comando.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@precio", producto.Precio);

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
                comando.CommandText = $"DELETE FROM PRODUCTOS WHERE ID_PRODUCTO = {ID}";

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

        public static void Modificacion(Producto producto)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE PRODUCTOS SET MARCA = @marca, DESCRIPCION = @descripcion, PRECIO = @precio, CANTIDAD = @cantidad WHERE ID_PRODUCTO = {producto.Id}";
                comando.Parameters.AddWithValue("@marca", producto.Marca);
                comando.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@precio", producto.Precio);
                comando.Parameters.AddWithValue("@cantidad", producto.Cantidad);

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


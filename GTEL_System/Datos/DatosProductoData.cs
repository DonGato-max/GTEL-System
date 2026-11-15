
using System;
using System.Data;
using System.Data.SqlClient;

namespace GTEL_System.Datos
{
    public class ProductoData
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public DataTable ListarProductos(string busqueda = "")
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(
                string.IsNullOrWhiteSpace(busqueda)
                    ? "sp_ListarProductos"
                    : "sp_BuscarProducto", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (!string.IsNullOrWhiteSpace(busqueda))
                    cmd.Parameters.AddWithValue("@NombreProducto", busqueda.Trim());

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tabla = new DataTable();
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }

        public DataTable ListarCategorias()
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ListarCategorias", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tabla = new DataTable();
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }

        public bool RegistrarProducto(
            string nombre, decimal compra, decimal venta,
            int existencias, int stockMinimo, int idCategoria,
            out string mensaje)
        {
            return EjecutarProcedimiento(
                "sp_RegistrarProducto",
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@NombreProducto", nombre);
                    cmd.Parameters.AddWithValue("@PrecioCompra", compra);
                    cmd.Parameters.AddWithValue("@PrecioVenta", venta);
                    cmd.Parameters.AddWithValue("@Existencias", existencias);
                    cmd.Parameters.AddWithValue("@StockMinimo", stockMinimo);
                    cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                }, out mensaje);
        }

        public bool ActualizarProducto(
            int id, string nombre, decimal compra, decimal venta,
            int stockMinimo, int idCategoria, out string mensaje)
        {
            return EjecutarProcedimiento(
                "sp_ActualizarProducto",
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@IdProducto", id);
                    cmd.Parameters.AddWithValue("@NombreProducto", nombre);
                    cmd.Parameters.AddWithValue("@PrecioCompra", compra);
                    cmd.Parameters.AddWithValue("@PrecioVenta", venta);
                    cmd.Parameters.AddWithValue("@StockMinimo", stockMinimo);
                    cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                }, out mensaje);
        }

        private bool EjecutarProcedimiento(
            string procedimiento, Action<SqlCommand> parametros,
            out string mensaje)
        {
            mensaje = "";

            try
            {
                using (SqlConnection cn = conexion.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand(procedimiento, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    parametros(cmd);
                    cn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int codigo = Convert.ToInt32(reader["Codigo"]);
                            mensaje = reader["Mensaje"].ToString();
                            return codigo == 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error de base de datos: " + ex.Message;
            }

            return false;
        }
    }
}


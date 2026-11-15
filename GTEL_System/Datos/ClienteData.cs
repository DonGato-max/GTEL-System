
using System;
using System.Data;
using System.Data.SqlClient;
using GTEL_System.Modelos;

namespace GTEL_System.Datos
{
    public class ClienteData
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ListarClientes", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }

            return tabla;
        }

        public ClienteModel BuscarPorCedula(string cedula)
        {
            ClienteModel cliente = null;

            using (SqlConnection cn = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_BuscarClientePorCedula", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Cedula", SqlDbType.VarChar, 20)
                    .Value = cedula;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        cliente = new ClienteModel
                        {
                            IdCliente = Convert.ToInt32(dr["IdCliente"]),
                            Nombres = dr["Nombres"].ToString(),
                            Cedula = dr["Cedula"].ToString(),
                            Telefono = dr["Telefono"] == DBNull.Value
                                ? string.Empty
                                : dr["Telefono"].ToString()
                        };
                    }
                }
            }

            return cliente;
        }

        public (int Codigo, string Mensaje) Registrar(ClienteModel cliente)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarCliente", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Nombres", SqlDbType.VarChar, 100)
                    .Value = cliente.Nombres;

                cmd.Parameters.Add("@Cedula", SqlDbType.VarChar, 20)
                    .Value = cliente.Cedula;

                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 20)
                    .Value = string.IsNullOrWhiteSpace(cliente.Telefono)
                        ? (object)DBNull.Value
                        : cliente.Telefono;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return (
                            Convert.ToInt32(dr["Codigo"]),
                            dr["Mensaje"].ToString()
                        );
                    }
                }
            }

            return (0, "No se pudo registrar el cliente.");
        }

        public (int Codigo, string Mensaje) Actualizar(ClienteModel cliente)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ActualizarCliente", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@IdCliente", SqlDbType.Int)
                    .Value = cliente.IdCliente;

                cmd.Parameters.Add("@Nombres", SqlDbType.VarChar, 100)
                    .Value = cliente.Nombres;

                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 20)
                    .Value = string.IsNullOrWhiteSpace(cliente.Telefono)
                        ? (object)DBNull.Value
                        : cliente.Telefono;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return (
                            Convert.ToInt32(dr["Codigo"]),
                            dr["Mensaje"].ToString()
                        );
                    }
                }
            }

            return (0, "No se pudo actualizar el cliente.");
        }
    }
}



using System.Data;
using System.Data.SqlClient;
using GTEL_System.Modelos;

namespace GTEL_System.Datos
{
    public class UsuarioData
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public UsuarioModel ValidarAcceso(
            string nombreUsuario,
            string contrasena,
            out int codigo,
            out string mensaje)
        {
            UsuarioModel usuario = null;

            codigo = 0;
            mensaje = string.Empty;

            using (SqlConnection cn = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ValidarAcceso", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 50)
                    .Value = nombreUsuario;

                cmd.Parameters.Add("@Contrasena", SqlDbType.VarChar, 100)
                    .Value = contrasena;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        codigo = dr["Codigo"] != System.DBNull.Value
                            ? System.Convert.ToInt32(dr["Codigo"])
                            : 0;

                        mensaje = dr["Mensaje"] != System.DBNull.Value
                            ? dr["Mensaje"].ToString()
                            : "No se pudo validar el acceso.";

                        if (codigo == 1)
                        {
                            usuario = new UsuarioModel
                            {
                                IdUsuario = System.Convert.ToInt32(dr["IdUsuario"]),
                                NombreUsuario = dr["NombreUsuario"].ToString(),
                                IdRol = System.Convert.ToInt32(dr["IdRol"]),
                                NombreRol = dr["NombreRol"].ToString(),
                                IntentosFallidos = System.Convert.ToInt32(dr["IntentosFallidos"]),
                                Bloqueado = System.Convert.ToBoolean(dr["Bloqueado"])
                            };
                        }
                    }
                }
            }

            return usuario;
        }
    }
}



using System;
using System.Data;
using System.Data.SqlClient;

namespace GTEL_System.Datos
{
    public class InicioData
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public int ObtenerTotal(string tabla)
        {
            string consulta;

            switch (tabla)
            {
                case "Producto":
                    consulta = "SELECT COUNT(*) FROM dbo.Producto";
                    break;

                case "Cliente":
                    consulta = "SELECT COUNT(*) FROM dbo.Cliente";
                    break;

                case "Factura":
                    consulta = "SELECT COUNT(*) FROM dbo.Factura";
                    break;

                default:
                    throw new ArgumentException("Consulta no válida.");
            }

            using (SqlConnection cn = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(consulta, cn))
            {
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}


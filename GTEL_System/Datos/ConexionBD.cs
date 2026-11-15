
using System.Configuration;
using System.Data.SqlClient;

namespace GTEL_System.Datos
{
    public class ConexionBD
    {
        private readonly string cadenaConexion;

        public ConexionBD()
        {
            cadenaConexion = ConfigurationManager
                .ConnectionStrings["ConexionGTEL"].ConnectionString;
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}


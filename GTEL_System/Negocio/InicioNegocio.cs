
using GTEL_System.Datos;

namespace GTEL_System.Negocio
{
    public class InicioNegocio
    {
        private readonly InicioData inicioData = new InicioData();

        public int ObtenerTotalProductos()
        {
            return inicioData.ObtenerTotal("Producto");
        }

        public int ObtenerTotalClientes()
        {
            return inicioData.ObtenerTotal("Cliente");
        }

        public int ObtenerTotalVentas()
        {
            return inicioData.ObtenerTotal("Factura");
        }
    }
}


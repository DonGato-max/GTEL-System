
using System.Data;
using GTEL_System.Datos;

namespace GTEL_System.Negocio
{
    public class InventarioNegocio
    {
        private readonly InventarioData inventarioData =
            new InventarioData();

        public DataTable ListarProductos()
        {
            return inventarioData.ListarProductos();
        }

        public DataTable ListarProductosStockBajo()
        {
            return inventarioData.ListarProductosStockBajo();
        }

        public DataTable BuscarProducto(string nombre)
        {
            return inventarioData.BuscarProducto(nombre);
        }
    }
}


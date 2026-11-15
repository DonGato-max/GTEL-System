using System.Data;
using GTEL_System.Datos;

namespace GTEL_System.Negocio
{
    public class ProductoNegocio
    {
        private readonly ProductoData datos = new ProductoData();

        public DataTable ListarProductos(string busqueda = "")
        {
            return datos.ListarProductos(busqueda);
        }

        public DataTable ListarCategorias()
        {
            return datos.ListarCategorias();
        }

        public bool RegistrarProducto(
            string nombre,
            decimal compra,
            decimal venta,
            int existencias,
            int stockMinimo,
            int idCategoria,
            out string mensaje)
        {
            return datos.RegistrarProducto(
                nombre, compra, venta,
                existencias, stockMinimo, idCategoria,
                out mensaje);
        }

        public bool ActualizarProducto(
            int idProducto,
            string nombre,
            decimal compra,
            decimal venta,
            int stockMinimo,
            int idCategoria,
            out string mensaje)
        {
            return datos.ActualizarProducto(
                idProducto, nombre, compra,
                venta, stockMinimo, idCategoria,
                out mensaje);
        }
    }
}

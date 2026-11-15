
using System;
using System.Data;
using GTEL_System.Datos;
using GTEL_System.Modelos;

namespace GTEL_System.Negocio
{
    public class ClienteNegocio
    {
        private readonly ClienteData clienteData = new ClienteData();

        public DataTable ListarClientes()
        {
            return clienteData.Listar();
        }

        public ClienteModel BuscarPorCedula(string cedula)
        {
            if (string.IsNullOrWhiteSpace(cedula))
                throw new ArgumentException("Ingrese la cédula del cliente.");

            return clienteData.BuscarPorCedula(cedula.Trim());
        }

        public (int Codigo, string Mensaje) RegistrarCliente(ClienteModel cliente)
        {
            ValidarCliente(cliente);
            return clienteData.Registrar(cliente);
        }

        public (int Codigo, string Mensaje) ActualizarCliente(ClienteModel cliente)
        {
            if (cliente == null || cliente.IdCliente <= 0)
                throw new ArgumentException("Seleccione un cliente válido.");

            ValidarCliente(cliente);
            return clienteData.Actualizar(cliente);
        }

        private void ValidarCliente(ClienteModel cliente)
        {
            if (cliente == null)
                throw new ArgumentException("Los datos del cliente son obligatorios.");

            if (string.IsNullOrWhiteSpace(cliente.Nombres))
                throw new ArgumentException("Ingrese el nombre del cliente.");

            if (string.IsNullOrWhiteSpace(cliente.Cedula))
                throw new ArgumentException("Ingrese la cédula del cliente.");
        }
    }
}


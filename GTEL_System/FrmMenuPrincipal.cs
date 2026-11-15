
using System;
using System.Windows.Forms;
using GTEL_System.Modelos;
using GTEL_System.Negocio;

namespace GTEL_System
{



    /// <summary>
    //


    public partial class FrmMenuPrincipal : Form
    {
        private UsuarioModel usuarioActual;
        private readonly InicioNegocio inicioNegocio = new InicioNegocio();

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        public FrmMenuPrincipal(UsuarioModel usuario)
        {
            InitializeComponent();

            btnInventario.Click += btnInventario_Click;


            if (usuario == null)
                throw new ArgumentNullException("usuario");

            usuarioActual = usuario;
            ConfigurarMenuPorRol();
        }

        private void ConfigurarMenuPorRol()
        {
            lblUsuarioActivo.Text =
                "Usuario: " + usuarioActual.NombreUsuario;

            string rol = usuarioActual.NombreRol.Trim();

            bool esAdministrador = string.Equals(
                rol, "Administrador",
                StringComparison.OrdinalIgnoreCase);

            bool esCajero = string.Equals(
                rol, "Cajero",
                StringComparison.OrdinalIgnoreCase);

            btnInicio.Enabled = esAdministrador || esCajero;
            btnUsuarios.Enabled = esAdministrador;
            btnClientes.Enabled = esAdministrador || esCajero;
            btnCategorias.Enabled = esAdministrador;
            btnProductos.Enabled = esAdministrador || esCajero;
            btnFacturacion.Enabled = esAdministrador || esCajero;
            btnInventario.Enabled = esAdministrador || esCajero;

            if (!esAdministrador && !esCajero)
            {
                MessageBox.Show(
                    "El rol del usuario no está autorizado.",
                    "GTEL SYSTEM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();
            }
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarResumen();
        }

        private void CargarResumen()
        {
            try
            {
                lblCantidadProd.Text =
                    "Total registrado: " +
                    inicioNegocio.ObtenerTotalProductos();

                lblCantidadClientes.Text =
                    "Total registrado: " +
                    inicioNegocio.ObtenerTotalClientes();

                lblCantidadVentas.Text =
                    "Total registrado: " +
                    inicioNegocio.ObtenerTotalVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar el resumen.\n\n" + ex.Message,
                    "GTEL SYSTEM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblProductos_Click(object sender, EventArgs e)
        { 
       

        }

        ///
        private void btnClientes_Click(object sender, EventArgs e)
        {
            using (FrmClientes formulario = new FrmClientes())
            {
                formulario.ShowDialog(); 
            }

            CargarResumen();
        }


        private void btnInventario_Click(object sender, EventArgs e)
        {
            using (FrmInventario formulario = new FrmInventario())
            {
                formulario.ShowDialog();
            }

            CargarResumen();
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            using (FrmProductos formulario = new FrmProductos())
            {
                formulario.ShowDialog();
            }

            CargarResumen();

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

        }
    }

    
}


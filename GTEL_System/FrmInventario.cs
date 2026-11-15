
using System;
using System.Windows.Forms;
using GTEL_System.Negocio;

namespace GTEL_System
{
    public partial class FrmInventario : Form
    {
        private readonly InventarioNegocio inventarioNegocio =
            new InventarioNegocio();

        public FrmInventario()
        {
            InitializeComponent();

            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            Load += FrmInventario_Load;

            txtBuscar.TextChanged += txtBuscar_TextChanged;

            btnBuscar.Click += btnBuscar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void CargarInventario()
        {
            try
            {
                dgvInventario.DataSource =
                    inventarioNegocio.ListarProductos();

                ConfigurarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar el inventario.\n\n" + ex.Message,
                    "GTEL SYSTEM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnas()
        {
            if (dgvInventario.Columns.Contains("IdProducto"))
                dgvInventario.Columns["IdProducto"].Visible = false;

            if (dgvInventario.Columns.Contains("NombreProducto"))
                dgvInventario.Columns["NombreProducto"].HeaderText = "Producto";

            if (dgvInventario.Columns.Contains("NombreCategoria"))
                dgvInventario.Columns["NombreCategoria"].HeaderText = "Categoría";

            if (dgvInventario.Columns.Contains("Existencias"))
                dgvInventario.Columns["Existencias"].HeaderText = "Existencias";

            if (dgvInventario.Columns.Contains("StockMinimo"))
                dgvInventario.Columns["StockMinimo"].HeaderText = "Stock mínimo";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    CargarInventario();
                    return;
                }

                dgvInventario.DataSource =
                    inventarioNegocio.BuscarProducto(txtBuscar.Text.Trim());

                ConfigurarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al filtrar productos.\n\n" + ex.Message,
                    "GTEL SYSTEM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar_TextChanged(sender, e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarInventario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarInventario();
            txtBuscar.Focus();
        }
    }
}


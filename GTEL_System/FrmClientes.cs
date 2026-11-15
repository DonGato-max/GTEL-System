
using System;
using System.Data;
using System.Windows.Forms;
using GTEL_System.Negocio;
using GTEL_System.Modelos;

namespace GTEL_System
{
    public partial class FrmClientes : Form
    {
        private readonly ClienteNegocio clienteNegocio =
            new ClienteNegocio();

        private int idClienteSeleccionado = 0;

        public FrmClientes()
        {
            InitializeComponent();

            // Configuración de la tabla
            ConfigurarTabla();

            // Evitar conexiones duplicadas del diseñador
            this.Load -= FrmClientes_Load;
            this.Load -= FrmClientes_Load_1;
            this.Load += FrmClientes_Load;

            btnNuevo.Click -= btnNuevo_Click;
            btnNuevo.Click += btnNuevo_Click;

            btnGuardar.Click -= btnGuardar_Click;
            btnGuardar.Click -= btnGuardar_Click_1;
            btnGuardar.Click += btnGuardar_Click;

            btnActualizar.Click -= btnActualizar_Click;
            btnActualizar.Click += btnActualizar_Click;

            btnBuscar.Click -= btnBuscar_Click;
            btnBuscar.Click += btnBuscar_Click;

            btnLimpiar.Click -= btnLimpiar_Click;
            btnLimpiar.Click += btnLimpiar_Click;

            dgvClientes.CellClick -= dgvClientes_CellClick;
            dgvClientes.CellClick += dgvClientes_CellClick;
        }

        private void ConfigurarTabla()
        {
            dgvClientes.BackgroundColor =
                System.Drawing.Color.White;

            dgvClientes.ForeColor =
                System.Drawing.Color.FromArgb(45, 45, 45);

            dgvClientes.GridColor =
                System.Drawing.Color.FromArgb(220, 220, 220);

            dgvClientes.BorderStyle = BorderStyle.FixedSingle;
            dgvClientes.ReadOnly = true;
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AllowUserToOrderColumns = false;

            dgvClientes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvClientes.MultiSelect = false;

            dgvClientes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvClientes.RowHeadersVisible = false;
            dgvClientes.AutoGenerateColumns = true;
            dgvClientes.EnableHeadersVisualStyles = false;

            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(38, 59, 85);

            dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;

            dgvClientes.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI", 9,
                    System.Drawing.FontStyle.Bold);

            dgvClientes.DefaultCellStyle.BackColor =
                System.Drawing.Color.White;

            dgvClientes.DefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(45, 45, 45);

            dgvClientes.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(70, 105, 140);

            dgvClientes.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.White;

            dgvClientes.DefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI", 9,
                    System.Drawing.FontStyle.Regular);

            dgvClientes.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(240, 244, 248);
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
            LimpiarCampos();
        }

        private void CargarClientes()
        {
            try
            {
                dgvClientes.DataSource =
                    clienteNegocio.ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los clientes.\n\n" + ex.Message,
                    "GTEL SYSTEM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            idClienteSeleccionado = 0;

            txtNombres.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();

            txtCedula.Enabled = true;
            txtNombres.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteModel cliente = new ClienteModel
                {
                    Nombres = txtNombres.Text.Trim(),
                    Cedula = txtCedula.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim()
                };

                var resultado =
                    clienteNegocio.RegistrarCliente(cliente);

                MessageBox.Show(
                    resultado.Mensaje,
                    "GTEL SYSTEM",
                    MessageBoxButtons.OK,
                    resultado.Codigo == 1
                        ? MessageBoxIcon.Information
                        : MessageBoxIcon.Warning);

                if (resultado.Codigo == 1)
                {
                    CargarClientes();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "GTEL SYSTEM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccioná un cliente para actualizar.",
                    "GTEL SYSTEM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            try
            {
                ClienteModel cliente = new ClienteModel
                {
                    IdCliente = idClienteSeleccionado,
                    Nombres = txtNombres.Text.Trim(),
                    Cedula = txtCedula.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim()
                };

                var resultado =
                    clienteNegocio.ActualizarCliente(cliente);

                MessageBox.Show(
                    resultado.Mensaje,
                    "GTEL SYSTEM",
                    MessageBoxButtons.OK,
                    resultado.Codigo == 1
                        ? MessageBoxIcon.Information
                        : MessageBoxIcon.Warning);

                if (resultado.Codigo == 1)
                {
                    CargarClientes();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "GTEL SYSTEM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteModel cliente =
                    clienteNegocio.BuscarPorCedula(
                        txtCedula.Text.Trim());

                if (cliente == null)
                {
                    MessageBox.Show(
                        "No se encontró ningún cliente.",
                        "GTEL SYSTEM",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                idClienteSeleccionado = cliente.IdCliente;

                txtNombres.Text = cliente.Nombres;
                txtCedula.Text = cliente.Cedula;
                txtTelefono.Text = cliente.Telefono ?? "";

                txtCedula.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "GTEL SYSTEM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvClientes.Rows[e.RowIndex];

            idClienteSeleccionado =
                Convert.ToInt32(fila.Cells["IdCliente"].Value);

            txtNombres.Text =
                Convert.ToString(fila.Cells["Nombres"].Value);

            txtCedula.Text =
                Convert.ToString(fila.Cells["Cedula"].Value);

            txtTelefono.Text =
                fila.Cells["Telefono"].Value == DBNull.Value
                    ? ""
                    : Convert.ToString(fila.Cells["Telefono"].Value);

            txtCedula.Enabled = false;
        }

        private void FrmClientes_Load_1(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
        }
    }
}


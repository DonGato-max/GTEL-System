
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using GTEL_System.Negocio;

namespace GTEL_System
{
    public partial class FrmProductos : Form
    {
        private readonly ProductoNegocio negocio = new ProductoNegocio();
        private int idProductoSeleccionado = 0;

        private Label lblTitulo, lblNombre, lblPrecioCompra;
        private Label lblPrecioVenta, lblExistencias, lblStockMinimo;
        private Label lblCategoria, lblBuscar;
        private TextBox txtNombre, txtPrecioCompra, txtPrecioVenta;
        private TextBox txtExistencias, txtStockMinimo, txtBuscar;
        private ComboBox cmbCategoria;
        private Button btnNuevo, btnGuardar, btnActualizar;
        private Button btnEliminar, btnLimpiar, btnBuscar;
        private DataGridView dgvProductos;

        public FrmProductos()
        {
            InitializeComponent();

            ConstruirInterfaz();
            CargarCategorias();
            CargarProductos();
        }

        private void ConstruirInterfaz()
        {
            Controls.Clear();

            Text = "Gestión de productos - GTEL SYSTEM";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1000, 680);
            MinimumSize = new Size(1000, 680);
            MaximumSize = new Size(1000, 680);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            BackColor = Color.White;
            Font = new Font("Segoe UI", 9F);

            lblTitulo = CrearLabel(
                "GESTIÓN DE PRODUCTOS", 30, 20, 450, 35, 16, true);

            lblNombre = CrearLabel("Nombre del producto:", 30, 85, 180, 22, 9, true);
            txtNombre = CrearTexto(30, 110, 300, 30, 120);

            lblPrecioCompra = CrearLabel("Precio de compra:", 370, 85, 180, 22, 9, true);
            txtPrecioCompra = CrearTexto(370, 110, 180, 30, 10);

            lblPrecioVenta = CrearLabel("Precio de venta:", 590, 85, 180, 22, 9, true);
            txtPrecioVenta = CrearTexto(590, 110, 180, 30, 10);

            lblExistencias = CrearLabel("Existencias:", 30, 160, 180, 22, 9, true);
            txtExistencias = CrearTexto(30, 185, 180, 30, 8);

            lblStockMinimo = CrearLabel("Stock mínimo:", 250, 160, 180, 22, 9, true);
            txtStockMinimo = CrearTexto(250, 185, 180, 30, 8);

            lblCategoria = CrearLabel("Categoría:", 470, 160, 180, 22, 9, true);

            cmbCategoria = new ComboBox
            {
                Name = "cmbCategoria",
                Location = new Point(470, 185),
                Size = new Size(250, 30),
                Font = new Font("Segoe UI", 10F),
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(45, 45, 45),
                FlatStyle = FlatStyle.Standard
            };

            Controls.Add(cmbCategoria);

            btnNuevo = CrearBoton("Nuevo", 30, 245, 110, Color.FromArgb(108, 117, 125));
            btnGuardar = CrearBoton("Guardar", 155, 245, 110, Color.FromArgb(0, 105, 160));
            btnActualizar = CrearBoton("Actualizar", 280, 245, 120, Color.FromArgb(25, 135, 84));
            btnEliminar = CrearBoton("Eliminar", 415, 245, 110, Color.FromArgb(200, 55, 55));
            btnLimpiar = CrearBoton("Limpiar", 540, 245, 110, Color.FromArgb(108, 117, 125));

            lblBuscar = CrearLabel("Buscar producto:", 30, 310, 150, 22, 9, true);
            txtBuscar = CrearTexto(30, 335, 300, 30, 120);
            btnBuscar = CrearBoton("Buscar", 350, 332, 110, Color.FromArgb(0, 105, 160));

            dgvProductos = new DataGridView
            {
                Name = "dgvProductos",
                Location = new Point(30, 390),
                Size = new Size(920, 235),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                AutoGenerateColumns = true,
                EnableHeadersVisualStyles = false,
                Font = new Font("Segoe UI", 9F),
                GridColor = Color.LightGray
            };

            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(38, 59, 85);
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvProductos.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(240, 244, 248);
            dgvProductos.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(205, 225, 240);
            dgvProductos.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(45, 45, 45);
            dgvProductos.RowTemplate.Height = 28;

            Controls.Add(dgvProductos);

            btnNuevo.Click += btnNuevo_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnBuscar.Click += btnBuscar_Click;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            dgvProductos.CellClick += dgvProductos_CellClick;
        }

        private Label CrearLabel(
            string texto, int x, int y, int ancho, int alto,
            float tamano, bool negrita)
        {
            Label label = new Label
            {
                Text = texto,
                Location = new Point(x, y),
                Size = new Size(ancho, alto),
                AutoSize = false,
                Font = new Font(
                    "Segoe UI", tamano,
                    negrita ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = Color.FromArgb(38, 59, 85),
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Controls.Add(label);
            return label;
        }

        private TextBox CrearTexto(
            int x, int y, int ancho, int alto, int maxLength)
        {
            TextBox txt = new TextBox
            {
                Location = new Point(x, y),
                Size = new Size(ancho, alto),
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(45, 45, 45),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                MaxLength = maxLength
            };

            Controls.Add(txt);
            return txt;
        }

        private Button CrearBoton(
            string texto, int x, int y, int ancho, Color color)
        {
            Button boton = new Button
            {
                Text = texto,
                Location = new Point(x, y),
                Size = new Size(ancho, 38),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = color,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            boton.FlatAppearance.BorderSize = 0;
            Controls.Add(boton);
            return boton;
        }

        private void CargarCategorias()
        {
            try
            {
                DataTable tabla = negocio.ListarCategorias();

                cmbCategoria.DataSource = tabla;
                cmbCategoria.DisplayMember = "NombreCategoria";
                cmbCategoria.ValueMember = "IdCategoria";
                cmbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar las categorías.\n" + ex.Message,
                    "GTEL SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos(string busqueda = "")
        {
            try
            {
                dgvProductos.DataSource = negocio.ListarProductos(busqueda);

                if (dgvProductos.Columns.Contains("IdProducto"))
                    dgvProductos.Columns["IdProducto"].Visible = false;

                if (dgvProductos.Columns.Contains("IdCategoria"))
                    dgvProductos.Columns["IdCategoria"].Visible = false;

                ConfigurarEncabezados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los productos.\n" + ex.Message,
                    "GTEL SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarEncabezados()
        {
            if (dgvProductos.Columns.Contains("NombreProducto"))
                dgvProductos.Columns["NombreProducto"].HeaderText = "Producto";

            if (dgvProductos.Columns.Contains("PrecioCompra"))
                dgvProductos.Columns["PrecioCompra"].HeaderText = "Precio compra";

            if (dgvProductos.Columns.Contains("PrecioVenta"))
                dgvProductos.Columns["PrecioVenta"].HeaderText = "Precio venta";

            if (dgvProductos.Columns.Contains("Existencias"))
                dgvProductos.Columns["Existencias"].HeaderText = "Existencias";

            if (dgvProductos.Columns.Contains("StockMinimo"))
                dgvProductos.Columns["StockMinimo"].HeaderText = "Stock mínimo";

            if (dgvProductos.Columns.Contains("NombreCategoria"))
                dgvProductos.Columns["NombreCategoria"].HeaderText = "Categoría";
        }

        private bool ValidarDatos(out decimal compra, out decimal venta,
            out int existencias, out int minimo,out int idCategoria)
        {
            compra = 0;
            venta = 0;
            existencias = 0;
            minimo = 0;
            idCategoria = 0;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresá el nombre del producto.");
                txtNombre.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecioCompra.Text, NumberStyles.Number,
                CultureInfo.CurrentCulture, out compra) || compra < 0)
            {
                MessageBox.Show("Ingresá un precio de compra válido.");
                txtPrecioCompra.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecioVenta.Text, NumberStyles.Number,
                CultureInfo.CurrentCulture, out venta) || venta < 0)
            {
                MessageBox.Show("Ingresá un precio de venta válido.");
                txtPrecioVenta.Focus();
                return false;
            }

            if (!int.TryParse(txtExistencias.Text, out existencias) || existencias < 0)
            {
                MessageBox.Show("Ingresá existencias válidas.");
                txtExistencias.Focus();
                return false;
            }

            if (!int.TryParse(txtStockMinimo.Text, out minimo) || minimo < 0)
            {
                MessageBox.Show("Ingresá un stock mínimo válido.");
                txtStockMinimo.Focus();
                return false;
            }

            if (cmbCategoria.SelectedValue == null ||
                cmbCategoria.SelectedValue is DataRowView)
            {
                MessageBox.Show("Seleccioná una categoría.");
                cmbCategoria.Focus();
                return false;
            }

            

            idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);


            return true;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos(out decimal compra, out decimal venta,
                out int existencias, out int stockMinimo, out int idCategoria))
                return;

            string mensaje;

            bool resultado = negocio.RegistrarProducto(
                txtNombre.Text.Trim(), compra, venta,
                existencias, stockMinimo, idCategoria, out mensaje);

            MessageBox.Show(mensaje, "GTEL SYSTEM",
                MessageBoxButtons.OK,
                resultado ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (resultado)
            {
                CargarProductos();
                LimpiarCampos();
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            if (!ValidarDatos(out decimal compra, out decimal venta,
                out int existencias, out int stockMinimo, out int idCategoria))
                return;

            string mensaje;

            bool resultado = negocio.ActualizarProducto(
                idProductoSeleccionado, txtNombre.Text.Trim(),
                compra, venta, stockMinimo, idCategoria, out mensaje);

            MessageBox.Show(mensaje, "GTEL SYSTEM",
                MessageBoxButtons.OK,
                resultado ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (resultado)
            {
                CargarProductos();
                LimpiarCampos();
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtBuscar.Clear();
            CargarProductos();
        }

        private void LimpiarCampos()
        {
            idProductoSeleccionado = 0;
            txtNombre.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtExistencias.Clear();
            txtStockMinimo.Clear();
            cmbCategoria.SelectedIndex = -1;
            dgvProductos.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarProductos(txtBuscar.Text.Trim());
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtBuscar.Text.Trim());
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

            idProductoSeleccionado = Convert.ToInt32(
                fila.Cells["IdProducto"].Value);

            txtNombre.Text = fila.Cells["NombreProducto"].Value.ToString();
            txtPrecioCompra.Text = fila.Cells["PrecioCompra"].Value.ToString();
            txtPrecioVenta.Text = fila.Cells["PrecioVenta"].Value.ToString();
            txtExistencias.Text = fila.Cells["Existencias"].Value.ToString();
            txtStockMinimo.Text = fila.Cells["StockMinimo"].Value.ToString();

            cmbCategoria.SelectedValue =
                Convert.ToInt32(fila.Cells["IdCategoria"].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "La base de datos todavía no tiene un procedimiento seguro " +
                "para eliminar productos. No se eliminarán registros que " +
                "puedan estar relacionados con facturas o movimientos.",
                "GTEL SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


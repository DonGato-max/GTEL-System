namespace GTEL_System
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.lblSubtituloSistema = new System.Windows.Forms.Label();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.plnEncabezado = new System.Windows.Forms.Panel();
            this.pnlResumenProductos = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblCantidadProd = new System.Windows.Forms.Label();
            this.pnlResumenClientes = new System.Windows.Forms.Panel();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.pnlResumenVentas = new System.Windows.Forms.Panel();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.plnEncabezado.SuspendLayout();
            this.pnlResumenProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnlResumenClientes.SuspendLayout();
            this.pnlResumenVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.pnlMenuLateral.Controls.Add(this.lblSubtituloSistema);
            this.pnlMenuLateral.Controls.Add(this.lblNombreSistema);
            this.pnlMenuLateral.Controls.Add(this.btnInventario);
            this.pnlMenuLateral.Controls.Add(this.btnProductos);
            this.pnlMenuLateral.Controls.Add(this.btnFacturacion);
            this.pnlMenuLateral.Controls.Add(this.btnCategorias);
            this.pnlMenuLateral.Controls.Add(this.btnClientes);
            this.pnlMenuLateral.Controls.Add(this.btnUsuarios);
            this.pnlMenuLateral.Controls.Add(this.btnInicio);
            this.pnlMenuLateral.Controls.Add(this.pnlEncabezado);
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(240, 661);
            this.pnlMenuLateral.TabIndex = 0;
            // 
            // lblSubtituloSistema
            // 
            this.lblSubtituloSistema.AutoSize = true;
            this.lblSubtituloSistema.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtituloSistema.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtituloSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.lblSubtituloSistema.Location = new System.Drawing.Point(3, 69);
            this.lblSubtituloSistema.Name = "lblSubtituloSistema";
            this.lblSubtituloSistema.Size = new System.Drawing.Size(193, 21);
            this.lblSubtituloSistema.TabIndex = 9;
            this.lblSubtituloSistema.Text = "Gestion Electrodomesticos";
            // 
            // lblNombreSistema
            // 
            this.lblNombreSistema.AutoSize = true;
            this.lblNombreSistema.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreSistema.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSistema.ForeColor = System.Drawing.Color.White;
            this.lblNombreSistema.Location = new System.Drawing.Point(2, 23);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(237, 46);
            this.lblNombreSistema.TabIndex = 8;
            this.lblNombreSistema.Text = "GTEL SYSTEM";
            this.lblNombreSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(120)))), ((int)(((byte)(209)))));
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(75)))));
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Location = new System.Drawing.Point(10, 420);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(220, 45);
            this.btnInventario.TabIndex = 7;
            this.btnInventario.Text = "INVENTARIO";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(120)))), ((int)(((byte)(209)))));
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(75)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(10, 320);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(220, 45);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(120)))), ((int)(((byte)(209)))));
            this.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(75)))));
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.Color.White;
            this.btnFacturacion.Location = new System.Drawing.Point(10, 370);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFacturacion.Size = new System.Drawing.Size(220, 45);
            this.btnFacturacion.TabIndex = 5;
            this.btnFacturacion.Text = "FACTURACION";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.UseVisualStyleBackColor = false;
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(120)))), ((int)(((byte)(209)))));
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(75)))));
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Location = new System.Drawing.Point(10, 270);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(220, 45);
            this.btnCategorias.TabIndex = 4;
            this.btnCategorias.Text = "CATEGORIAS";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(120)))), ((int)(((byte)(209)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(75)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(10, 220);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(220, 45);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(120)))), ((int)(((byte)(209)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(75)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(7, 171);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(220, 45);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(47)))), ((int)(((byte)(91)))));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(120)))), ((int)(((byte)(209)))));
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(75)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(10, 120);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(220, 45);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.White;
            this.pnlEncabezado.Location = new System.Drawing.Point(240, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(844, 75);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.pnlResumenVentas);
            this.pnlContenido.Controls.Add(this.pnlResumenClientes);
            this.pnlContenido.Controls.Add(this.pnlResumenProductos);
            this.pnlContenido.Controls.Add(this.lblDescripcion);
            this.pnlContenido.Controls.Add(this.lblBienvenida);
            this.pnlContenido.Location = new System.Drawing.Point(240, 75);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(849, 568);
            this.pnlContenido.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblDescripcion.Location = new System.Drawing.Point(38, 95);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(700, 35);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Sistema de Gestion de Tienda de Electrodomesticos.";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.lblBienvenida.Location = new System.Drawing.Point(35, 35);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(650, 55);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "BIENVENIDO A GTEL SYSTEM";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.Location = new System.Drawing.Point(30, 10);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(264, 55);
            this.lblTituloPrincipal.TabIndex = 2;
            this.lblTituloPrincipal.Text = "Principal";
            this.lblTituloPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plnEncabezado
            // 
            this.plnEncabezado.BackColor = System.Drawing.Color.White;
            this.plnEncabezado.Controls.Add(this.lblUsuarioActivo);
            this.plnEncabezado.Controls.Add(this.lblTituloPrincipal);
            this.plnEncabezado.Location = new System.Drawing.Point(240, 0);
            this.plnEncabezado.Name = "plnEncabezado";
            this.plnEncabezado.Size = new System.Drawing.Size(849, 75);
            this.plnEncabezado.TabIndex = 3;
            // 
            // pnlResumenProductos
            // 
            this.pnlResumenProductos.BackColor = System.Drawing.Color.White;
            this.pnlResumenProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResumenProductos.Controls.Add(this.lblCantidadProd);
            this.pnlResumenProductos.Controls.Add(this.lblProductos);
            this.pnlResumenProductos.Location = new System.Drawing.Point(35, 170);
            this.pnlResumenProductos.Name = "pnlResumenProductos";
            this.pnlResumenProductos.Size = new System.Drawing.Size(220, 130);
            this.pnlResumenProductos.TabIndex = 2;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblProductos
            // 
            this.lblProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.lblProductos.Location = new System.Drawing.Point(15, 15);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(190, 30);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Productos";
            this.lblProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProductos.Click += new System.EventHandler(this.lblProductos_Click);
            // 
            // lblCantidadProd
            // 
            this.lblCantidadProd.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadProd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.lblCantidadProd.Location = new System.Drawing.Point(15, 55);
            this.lblCantidadProd.Name = "lblCantidadProd";
            this.lblCantidadProd.Size = new System.Drawing.Size(190, 35);
            this.lblCantidadProd.TabIndex = 1;
            this.lblCantidadProd.Text = "Total registrado";
            this.lblCantidadProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlResumenClientes
            // 
            this.pnlResumenClientes.BackColor = System.Drawing.Color.White;
            this.pnlResumenClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResumenClientes.Controls.Add(this.lblCantidadClientes);
            this.pnlResumenClientes.Controls.Add(this.lblClientes);
            this.pnlResumenClientes.Location = new System.Drawing.Point(275, 170);
            this.pnlResumenClientes.Name = "pnlResumenClientes";
            this.pnlResumenClientes.Size = new System.Drawing.Size(220, 130);
            this.pnlResumenClientes.TabIndex = 3;
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadClientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.lblCantidadClientes.Location = new System.Drawing.Point(15, 55);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(190, 35);
            this.lblCantidadClientes.TabIndex = 1;
            this.lblCantidadClientes.Text = "Total registrado";
            this.lblCantidadClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClientes
            // 
            this.lblClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.lblClientes.Location = new System.Drawing.Point(15, 15);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(190, 30);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClientes.Click += new System.EventHandler(this.lblClientes_Click);
            // 
            // pnlResumenVentas
            // 
            this.pnlResumenVentas.BackColor = System.Drawing.Color.White;
            this.pnlResumenVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResumenVentas.Controls.Add(this.lblCantidadVentas);
            this.pnlResumenVentas.Controls.Add(this.lblVentas);
            this.pnlResumenVentas.Location = new System.Drawing.Point(515, 170);
            this.pnlResumenVentas.Name = "pnlResumenVentas";
            this.pnlResumenVentas.Size = new System.Drawing.Size(220, 130);
            this.pnlResumenVentas.TabIndex = 4;
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadVentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.lblCantidadVentas.Location = new System.Drawing.Point(15, 55);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(190, 35);
            this.lblCantidadVentas.TabIndex = 1;
            this.lblCantidadVentas.Text = "Total registrado";
            this.lblCantidadVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVentas
            // 
            this.lblVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.lblVentas.Location = new System.Drawing.Point(15, 15);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(190, 30);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "Ventas";
            this.lblVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblUsuarioActivo.Location = new System.Drawing.Point(620, 20);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(220, 35);
            this.lblUsuarioActivo.TabIndex = 3;
            this.lblUsuarioActivo.Text = "Usuario: Administrador";
            this.lblUsuarioActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1091, 524);
            this.Controls.Add(this.plnEncabezado);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlMenuLateral);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GTEL System Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlMenuLateral.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.plnEncabezado.ResumeLayout(false);
            this.pnlResumenProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.pnlResumenClientes.ResumeLayout(false);
            this.pnlResumenVentas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Panel plnEncabezado;
        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.Label lblSubtituloSistema;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel pnlResumenProductos;
        private System.Windows.Forms.Label lblProductos;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblCantidadProd;
        private System.Windows.Forms.Panel pnlResumenClientes;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Panel pnlResumenVentas;
        private System.Windows.Forms.Label lblCantidadVentas;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblUsuarioActivo;
    }
}
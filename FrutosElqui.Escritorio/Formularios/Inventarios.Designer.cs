
namespace FrutosElqui.Escritorio.Formularios
{
    partial class Inventarios
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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainOpcionesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.ProductosInventarioView = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusquedasGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SucursalLabel = new System.Windows.Forms.Label();
            this.SucursalesCombo = new System.Windows.Forms.ComboBox();
            this.BuscarProductosDeInventarioButton = new System.Windows.Forms.Button();
            this.OpcionesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.IngresarProductoButton = new System.Windows.Forms.Button();
            this.RefrescarButton = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            this.MainOpcionesLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosInventarioView)).BeginInit();
            this.BusquedasGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.OpcionesLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.MainOpcionesLayout, 0, 3);
            this.mainLayout.Controls.Add(this.ProductosInventarioView, 0, 1);
            this.mainLayout.Controls.Add(this.BusquedasGroupBox, 0, 0);
            this.mainLayout.Controls.Add(this.OpcionesLayout, 0, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 5;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.05251F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.591886F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.069212F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.Size = new System.Drawing.Size(1598, 838);
            this.mainLayout.TabIndex = 0;
            // 
            // MainOpcionesLayout
            // 
            this.MainOpcionesLayout.ColumnCount = 3;
            this.MainOpcionesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainOpcionesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainOpcionesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainOpcionesLayout.Controls.Add(this.CerrarButton, 1, 0);
            this.MainOpcionesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainOpcionesLayout.Location = new System.Drawing.Point(3, 722);
            this.MainOpcionesLayout.Name = "MainOpcionesLayout";
            this.MainOpcionesLayout.RowCount = 1;
            this.MainOpcionesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainOpcionesLayout.Size = new System.Drawing.Size(1592, 70);
            this.MainOpcionesLayout.TabIndex = 3;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CerrarButton.Location = new System.Drawing.Point(533, 3);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(524, 64);
            this.CerrarButton.TabIndex = 0;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarForm);
            // 
            // ProductosInventarioView
            // 
            this.ProductosInventarioView.AllowUserToAddRows = false;
            this.ProductosInventarioView.AllowUserToDeleteRows = false;
            this.ProductosInventarioView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosInventarioView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.NombreProducto,
            this.CategoriaProducto,
            this.Medida,
            this.Proveedor,
            this.Cantidad});
            this.ProductosInventarioView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductosInventarioView.Location = new System.Drawing.Point(3, 129);
            this.ProductosInventarioView.Name = "ProductosInventarioView";
            this.ProductosInventarioView.ReadOnly = true;
            this.ProductosInventarioView.RowHeadersWidth = 82;
            this.ProductosInventarioView.RowTemplate.Height = 41;
            this.ProductosInventarioView.Size = new System.Drawing.Size(1592, 515);
            this.ProductosInventarioView.TabIndex = 0;
            // 
            // IdProducto
            // 
            this.IdProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdProducto.HeaderText = "Id";
            this.IdProducto.MinimumWidth = 10;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.MinimumWidth = 10;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // CategoriaProducto
            // 
            this.CategoriaProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoriaProducto.HeaderText = "Categoria";
            this.CategoriaProducto.MinimumWidth = 10;
            this.CategoriaProducto.Name = "CategoriaProducto";
            this.CategoriaProducto.ReadOnly = true;
            // 
            // Medida
            // 
            this.Medida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medida.HeaderText = "Medida";
            this.Medida.MinimumWidth = 10;
            this.Medida.Name = "Medida";
            this.Medida.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 10;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 10;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // BusquedasGroupBox
            // 
            this.BusquedasGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.BusquedasGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BusquedasGroupBox.Location = new System.Drawing.Point(3, 3);
            this.BusquedasGroupBox.Name = "BusquedasGroupBox";
            this.BusquedasGroupBox.Size = new System.Drawing.Size(1592, 120);
            this.BusquedasGroupBox.TabIndex = 1;
            this.BusquedasGroupBox.TabStop = false;
            this.BusquedasGroupBox.Text = "Inventarios por sucursales";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.SucursalLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SucursalesCombo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BuscarProductosDeInventarioButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.07407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.92593F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1586, 82);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SucursalLabel
            // 
            this.SucursalLabel.AutoSize = true;
            this.SucursalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SucursalLabel.Location = new System.Drawing.Point(3, 0);
            this.SucursalLabel.Name = "SucursalLabel";
            this.SucursalLabel.Size = new System.Drawing.Size(522, 60);
            this.SucursalLabel.TabIndex = 0;
            this.SucursalLabel.Text = "Seleccione sucursal";
            this.SucursalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SucursalesCombo
            // 
            this.SucursalesCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SucursalesCombo.FormattingEnabled = true;
            this.SucursalesCombo.Location = new System.Drawing.Point(531, 3);
            this.SucursalesCombo.Name = "SucursalesCombo";
            this.SucursalesCombo.Size = new System.Drawing.Size(522, 40);
            this.SucursalesCombo.TabIndex = 1;
            // 
            // BuscarProductosDeInventarioButton
            // 
            this.BuscarProductosDeInventarioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuscarProductosDeInventarioButton.Location = new System.Drawing.Point(1059, 3);
            this.BuscarProductosDeInventarioButton.Name = "BuscarProductosDeInventarioButton";
            this.BuscarProductosDeInventarioButton.Size = new System.Drawing.Size(524, 54);
            this.BuscarProductosDeInventarioButton.TabIndex = 2;
            this.BuscarProductosDeInventarioButton.Text = "Buscar";
            this.BuscarProductosDeInventarioButton.UseVisualStyleBackColor = true;
            this.BuscarProductosDeInventarioButton.Click += new System.EventHandler(this.CargarProductosDeSucursal);
            // 
            // OpcionesLayout
            // 
            this.OpcionesLayout.ColumnCount = 5;
            this.OpcionesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.OpcionesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.OpcionesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.OpcionesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.OpcionesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.OpcionesLayout.Controls.Add(this.IngresarProductoButton, 3, 0);
            this.OpcionesLayout.Controls.Add(this.RefrescarButton, 1, 0);
            this.OpcionesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpcionesLayout.Location = new System.Drawing.Point(3, 650);
            this.OpcionesLayout.Name = "OpcionesLayout";
            this.OpcionesLayout.RowCount = 1;
            this.OpcionesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OpcionesLayout.Size = new System.Drawing.Size(1592, 66);
            this.OpcionesLayout.TabIndex = 2;
            // 
            // IngresarProductoButton
            // 
            this.IngresarProductoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IngresarProductoButton.Location = new System.Drawing.Point(1100, 3);
            this.IngresarProductoButton.Name = "IngresarProductoButton";
            this.IngresarProductoButton.Size = new System.Drawing.Size(296, 60);
            this.IngresarProductoButton.TabIndex = 0;
            this.IngresarProductoButton.Text = "Ingresar producto";
            this.IngresarProductoButton.UseVisualStyleBackColor = true;
            this.IngresarProductoButton.Click += new System.EventHandler(this.IngresarProductoClick);
            // 
            // RefrescarButton
            // 
            this.RefrescarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefrescarButton.Location = new System.Drawing.Point(194, 3);
            this.RefrescarButton.Name = "RefrescarButton";
            this.RefrescarButton.Size = new System.Drawing.Size(296, 60);
            this.RefrescarButton.TabIndex = 1;
            this.RefrescarButton.Text = "Refrescar";
            this.RefrescarButton.UseVisualStyleBackColor = true;
            // 
            // Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 838);
            this.Controls.Add(this.mainLayout);
            this.Name = "Inventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventarios";
            this.Load += new System.EventHandler(this.CargarInventariosLoad);
            this.mainLayout.ResumeLayout(false);
            this.MainOpcionesLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosInventarioView)).EndInit();
            this.BusquedasGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.OpcionesLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.DataGridView ProductosInventarioView;
        private System.Windows.Forms.GroupBox BusquedasGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label SucursalLabel;
        private System.Windows.Forms.ComboBox SucursalesCombo;
        private System.Windows.Forms.Button BuscarProductosDeInventarioButton;
        private System.Windows.Forms.TableLayoutPanel OpcionesLayout;
        private System.Windows.Forms.TableLayoutPanel MainOpcionesLayout;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button IngresarProductoButton;
        private System.Windows.Forms.Button RefrescarButton;
    }
}
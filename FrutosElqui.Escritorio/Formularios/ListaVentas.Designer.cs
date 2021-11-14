namespace FrutosElqui.Escritorio.Formularios
{
    partial class ListaVentas
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
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DAtaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.VentasView = new System.Windows.Forms.DataGridView();
            this.IdIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpcionesGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.VerDetalleButton = new System.Windows.Forms.Button();
            this.TotalVentasLabel = new System.Windows.Forms.Label();
            this.TotalVentaInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalProveedorInput = new System.Windows.Forms.TextBox();
            this.InfoDinerosButton = new System.Windows.Forms.Button();
            this.FiltroBusquedaGroup = new System.Windows.Forms.GroupBox();
            this.BusquedaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FechaHastaPicker = new System.Windows.Forms.DateTimePicker();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.SucursalLabel = new System.Windows.Forms.Label();
            this.SucursalesBox = new System.Windows.Forms.ComboBox();
            this.FechaDesdePicker = new System.Windows.Forms.DateTimePicker();
            this.ProveedorLabel = new System.Windows.Forms.Label();
            this.ProveedoresBox = new System.Windows.Forms.ComboBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.MainLayout.SuspendLayout();
            this.DAtaLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasView)).BeginInit();
            this.OpcionesGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.FiltroBusquedaGroup.SuspendLayout();
            this.BusquedaLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.03007F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.96993F));
            this.MainLayout.Controls.Add(this.DAtaLayout, 1, 0);
            this.MainLayout.Controls.Add(this.FiltroBusquedaGroup, 0, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Size = new System.Drawing.Size(1563, 839);
            this.MainLayout.TabIndex = 2;
            // 
            // DAtaLayout
            // 
            this.DAtaLayout.ColumnCount = 1;
            this.DAtaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DAtaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DAtaLayout.Controls.Add(this.VentasView, 0, 1);
            this.DAtaLayout.Controls.Add(this.OpcionesGroupBox, 0, 2);
            this.DAtaLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DAtaLayout.Location = new System.Drawing.Point(488, 3);
            this.DAtaLayout.Name = "DAtaLayout";
            this.DAtaLayout.RowCount = 3;
            this.DAtaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.272727F));
            this.DAtaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.62665F));
            this.DAtaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.17047F));
            this.DAtaLayout.Size = new System.Drawing.Size(1072, 833);
            this.DAtaLayout.TabIndex = 0;
            // 
            // VentasView
            // 
            this.VentasView.AllowUserToAddRows = false;
            this.VentasView.AllowUserToDeleteRows = false;
            this.VentasView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentasView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIngreso,
            this.FechaIngreso,
            this.Cantidad,
            this.CantidadProductos});
            this.VentasView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VentasView.Location = new System.Drawing.Point(3, 63);
            this.VentasView.Name = "VentasView";
            this.VentasView.ReadOnly = true;
            this.VentasView.RowHeadersVisible = false;
            this.VentasView.RowHeadersWidth = 82;
            this.VentasView.RowTemplate.Height = 41;
            this.VentasView.Size = new System.Drawing.Size(1066, 548);
            this.VentasView.TabIndex = 1;
            // 
            // IdIngreso
            // 
            this.IdIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdIngreso.FillWeight = 128.2051F;
            this.IdIngreso.HeaderText = "ID";
            this.IdIngreso.MinimumWidth = 10;
            this.IdIngreso.Name = "IdIngreso";
            this.IdIngreso.ReadOnly = true;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FechaIngreso.FillWeight = 90.59829F;
            this.FechaIngreso.HeaderText = "Fecha";
            this.FechaIngreso.MinimumWidth = 10;
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 121;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.FillWeight = 90.59829F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 10;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 154;
            // 
            // CantidadProductos
            // 
            this.CantidadProductos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CantidadProductos.FillWeight = 90.59829F;
            this.CantidadProductos.HeaderText = "Cantidad de productos";
            this.CantidadProductos.MinimumWidth = 10;
            this.CantidadProductos.Name = "CantidadProductos";
            this.CantidadProductos.ReadOnly = true;
            this.CantidadProductos.Width = 276;
            // 
            // OpcionesGroupBox
            // 
            this.OpcionesGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.OpcionesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpcionesGroupBox.Location = new System.Drawing.Point(3, 617);
            this.OpcionesGroupBox.Name = "OpcionesGroupBox";
            this.OpcionesGroupBox.Size = new System.Drawing.Size(1066, 213);
            this.OpcionesGroupBox.TabIndex = 2;
            this.OpcionesGroupBox.TabStop = false;
            this.OpcionesGroupBox.Text = "Opciones";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.VerDetalleButton, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.TotalVentasLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TotalVentaInput, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.TotalProveedorInput, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.InfoDinerosButton, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1060, 175);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // VerDetalleButton
            // 
            this.VerDetalleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VerDetalleButton.Location = new System.Drawing.Point(586, 89);
            this.VerDetalleButton.Name = "VerDetalleButton";
            this.VerDetalleButton.Size = new System.Drawing.Size(259, 37);
            this.VerDetalleButton.TabIndex = 0;
            this.VerDetalleButton.Text = "Ver detalle";
            this.VerDetalleButton.UseVisualStyleBackColor = true;
            // 
            // TotalVentasLabel
            // 
            this.TotalVentasLabel.AutoSize = true;
            this.TotalVentasLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalVentasLabel.Location = new System.Drawing.Point(109, 0);
            this.TotalVentasLabel.Name = "TotalVentasLabel";
            this.TotalVentasLabel.Size = new System.Drawing.Size(259, 43);
            this.TotalVentasLabel.TabIndex = 1;
            this.TotalVentasLabel.Text = "Total de ventas";
            this.TotalVentasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalVentaInput
            // 
            this.TotalVentaInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TotalVentaInput.Location = new System.Drawing.Point(374, 3);
            this.TotalVentaInput.Name = "TotalVentaInput";
            this.TotalVentaInput.ReadOnly = true;
            this.TotalVentaInput.Size = new System.Drawing.Size(206, 39);
            this.TotalVentaInput.TabIndex = 2;
            this.TotalVentaInput.Text = "$0";
            this.TotalVentaInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(586, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total del proveedor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalProveedorInput
            // 
            this.TotalProveedorInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TotalProveedorInput.Location = new System.Drawing.Point(851, 3);
            this.TotalProveedorInput.Name = "TotalProveedorInput";
            this.TotalProveedorInput.ReadOnly = true;
            this.TotalProveedorInput.Size = new System.Drawing.Size(206, 39);
            this.TotalProveedorInput.TabIndex = 4;
            this.TotalProveedorInput.Text = "$0";
            this.TotalProveedorInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InfoDinerosButton
            // 
            this.InfoDinerosButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoDinerosButton.Location = new System.Drawing.Point(109, 89);
            this.InfoDinerosButton.Name = "InfoDinerosButton";
            this.InfoDinerosButton.Size = new System.Drawing.Size(259, 37);
            this.InfoDinerosButton.TabIndex = 5;
            this.InfoDinerosButton.Text = "Info. dineros";
            this.InfoDinerosButton.UseVisualStyleBackColor = true;
            // 
            // FiltroBusquedaGroup
            // 
            this.FiltroBusquedaGroup.Controls.Add(this.BusquedaLayout);
            this.FiltroBusquedaGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiltroBusquedaGroup.Location = new System.Drawing.Point(3, 3);
            this.FiltroBusquedaGroup.Name = "FiltroBusquedaGroup";
            this.FiltroBusquedaGroup.Size = new System.Drawing.Size(479, 833);
            this.FiltroBusquedaGroup.TabIndex = 1;
            this.FiltroBusquedaGroup.TabStop = false;
            this.FiltroBusquedaGroup.Text = "Filtros de búsqueda";
            // 
            // BusquedaLayout
            // 
            this.BusquedaLayout.ColumnCount = 2;
            this.BusquedaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.47423F));
            this.BusquedaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.52577F));
            this.BusquedaLayout.Controls.Add(this.FechaHastaPicker, 1, 3);
            this.BusquedaLayout.Controls.Add(this.HastaLabel, 0, 3);
            this.BusquedaLayout.Controls.Add(this.DesdeLabel, 0, 2);
            this.BusquedaLayout.Controls.Add(this.SucursalLabel, 0, 1);
            this.BusquedaLayout.Controls.Add(this.SucursalesBox, 1, 1);
            this.BusquedaLayout.Controls.Add(this.FechaDesdePicker, 1, 2);
            this.BusquedaLayout.Controls.Add(this.ProveedorLabel, 0, 4);
            this.BusquedaLayout.Controls.Add(this.ProveedoresBox, 1, 4);
            this.BusquedaLayout.Controls.Add(this.BuscarButton, 1, 9);
            this.BusquedaLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BusquedaLayout.Location = new System.Drawing.Point(3, 35);
            this.BusquedaLayout.Name = "BusquedaLayout";
            this.BusquedaLayout.RowCount = 11;
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.202881F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.722689F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.923169F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.842737F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.92437F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.BusquedaLayout.Size = new System.Drawing.Size(473, 795);
            this.BusquedaLayout.TabIndex = 2;
            // 
            // FechaHastaPicker
            // 
            this.FechaHastaPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FechaHastaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaHastaPicker.Location = new System.Drawing.Point(156, 288);
            this.FechaHastaPicker.Name = "FechaHastaPicker";
            this.FechaHastaPicker.Size = new System.Drawing.Size(314, 39);
            this.FechaHastaPicker.TabIndex = 10;
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HastaLabel.Location = new System.Drawing.Point(3, 285);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(147, 63);
            this.HastaLabel.TabIndex = 7;
            this.HastaLabel.Text = "Hasta";
            this.HastaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesdeLabel.Location = new System.Drawing.Point(3, 222);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(147, 63);
            this.DesdeLabel.TabIndex = 6;
            this.DesdeLabel.Text = "Desde";
            this.DesdeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SucursalLabel
            // 
            this.SucursalLabel.AutoSize = true;
            this.SucursalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SucursalLabel.Location = new System.Drawing.Point(3, 159);
            this.SucursalLabel.Name = "SucursalLabel";
            this.SucursalLabel.Size = new System.Drawing.Size(147, 63);
            this.SucursalLabel.TabIndex = 1;
            this.SucursalLabel.Text = "Sucursal";
            this.SucursalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SucursalesBox
            // 
            this.SucursalesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SucursalesBox.FormattingEnabled = true;
            this.SucursalesBox.Location = new System.Drawing.Point(156, 162);
            this.SucursalesBox.Name = "SucursalesBox";
            this.SucursalesBox.Size = new System.Drawing.Size(314, 40);
            this.SucursalesBox.TabIndex = 2;
            // 
            // FechaDesdePicker
            // 
            this.FechaDesdePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FechaDesdePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDesdePicker.Location = new System.Drawing.Point(156, 225);
            this.FechaDesdePicker.Name = "FechaDesdePicker";
            this.FechaDesdePicker.Size = new System.Drawing.Size(314, 39);
            this.FechaDesdePicker.TabIndex = 3;
            // 
            // ProveedorLabel
            // 
            this.ProveedorLabel.AutoSize = true;
            this.ProveedorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProveedorLabel.Location = new System.Drawing.Point(3, 348);
            this.ProveedorLabel.Name = "ProveedorLabel";
            this.ProveedorLabel.Size = new System.Drawing.Size(147, 57);
            this.ProveedorLabel.TabIndex = 11;
            this.ProveedorLabel.Text = "Proveedor";
            this.ProveedorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProveedoresBox
            // 
            this.ProveedoresBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProveedoresBox.FormattingEnabled = true;
            this.ProveedoresBox.Location = new System.Drawing.Point(156, 351);
            this.ProveedoresBox.Name = "ProveedoresBox";
            this.ProveedoresBox.Size = new System.Drawing.Size(314, 40);
            this.ProveedoresBox.TabIndex = 12;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuscarButton.Location = new System.Drawing.Point(162, 671);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(9);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(302, 45);
            this.BuscarButton.TabIndex = 13;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarVentas);
            // 
            // ListaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 839);
            this.Controls.Add(this.MainLayout);
            this.Name = "ListaVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de ventas";
            this.Load += new System.EventHandler(this.LoadFrame);
            this.MainLayout.ResumeLayout(false);
            this.DAtaLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VentasView)).EndInit();
            this.OpcionesGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.FiltroBusquedaGroup.ResumeLayout(false);
            this.BusquedaLayout.ResumeLayout(false);
            this.BusquedaLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel DAtaLayout;
        private System.Windows.Forms.DataGridView VentasView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProductos;
        private System.Windows.Forms.GroupBox FiltroBusquedaGroup;
        private System.Windows.Forms.TableLayoutPanel BusquedaLayout;
        private System.Windows.Forms.DateTimePicker FechaHastaPicker;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.Label SucursalLabel;
        private System.Windows.Forms.ComboBox SucursalesBox;
        private System.Windows.Forms.DateTimePicker FechaDesdePicker;
        private System.Windows.Forms.Label ProveedorLabel;
        private System.Windows.Forms.ComboBox ProveedoresBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.GroupBox OpcionesGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button VerDetalleButton;
        private System.Windows.Forms.Label TotalVentasLabel;
        private System.Windows.Forms.TextBox TotalVentaInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalProveedorInput;
        private System.Windows.Forms.Button InfoDinerosButton;
    }
}
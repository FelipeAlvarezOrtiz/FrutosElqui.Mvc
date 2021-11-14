
namespace FrutosElqui.Escritorio.Formularios
{
    partial class CrearCotizacion
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
            this.productosEnOfertaView = new System.Windows.Forms.DataGridView();
            this.CodeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabeceraLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ConfiguracionVentaGroupBox = new System.Windows.Forms.GroupBox();
            this.configuracionVentaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CostoTotalLabel = new System.Windows.Forms.Label();
            this.CodigoProductoInput = new System.Windows.Forms.TextBox();
            this.DescuentoLabel = new System.Windows.Forms.Label();
            this.CodigoBarraLabel = new System.Windows.Forms.Label();
            this.NombreCotizacionInput = new System.Windows.Forms.TextBox();
            this.DescuentoInput = new System.Windows.Forms.TextBox();
            this.ClienteLabel = new System.Windows.Forms.Label();
            this.RutClienteInput = new System.Windows.Forms.TextBox();
            this.NombreClienteLabel = new System.Windows.Forms.Label();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.NombreClienteInput = new System.Windows.Forms.TextBox();
            this.RegionInput = new System.Windows.Forms.TextBox();
            this.SectorLabel = new System.Windows.Forms.Label();
            this.SectorInput = new System.Windows.Forms.TextBox();
            this.ComunaLabel = new System.Windows.Forms.Label();
            this.ComunaInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BotonesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BorrarProductoButton = new System.Windows.Forms.Button();
            this.ResetBuscador = new System.Windows.Forms.Button();
            this.GuardarOfertaButton = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosEnOfertaView)).BeginInit();
            this.cabeceraLayout.SuspendLayout();
            this.ConfiguracionVentaGroupBox.SuspendLayout();
            this.configuracionVentaLayout.SuspendLayout();
            this.BotonesLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.productosEnOfertaView, 0, 1);
            this.mainLayout.Controls.Add(this.cabeceraLayout, 0, 0);
            this.mainLayout.Controls.Add(this.BotonesLayout, 0, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 4;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.09706F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.38697F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.045977F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.342273F));
            this.mainLayout.Size = new System.Drawing.Size(1549, 783);
            this.mainLayout.TabIndex = 2;
            // 
            // productosEnOfertaView
            // 
            this.productosEnOfertaView.AllowUserToAddRows = false;
            this.productosEnOfertaView.AllowUserToDeleteRows = false;
            this.productosEnOfertaView.AllowUserToResizeColumns = false;
            this.productosEnOfertaView.AllowUserToResizeRows = false;
            this.productosEnOfertaView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productosEnOfertaView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosEnOfertaView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeID,
            this.NombreProducto,
            this.Cantidad,
            this.Precio});
            this.productosEnOfertaView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productosEnOfertaView.Location = new System.Drawing.Point(3, 223);
            this.productosEnOfertaView.Name = "productosEnOfertaView";
            this.productosEnOfertaView.RowHeadersVisible = false;
            this.productosEnOfertaView.RowHeadersWidth = 82;
            this.productosEnOfertaView.RowTemplate.Height = 41;
            this.productosEnOfertaView.Size = new System.Drawing.Size(1543, 459);
            this.productosEnOfertaView.TabIndex = 0;
            // 
            // CodeID
            // 
            this.CodeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CodeID.HeaderText = "Codigo de Barra";
            this.CodeID.MinimumWidth = 200;
            this.CodeID.Name = "CodeID";
            this.CodeID.Width = 200;
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreProducto.HeaderText = "Nombre de Producto";
            this.NombreProducto.MinimumWidth = 560;
            this.NombreProducto.Name = "NombreProducto";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 10;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 154;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Precio.HeaderText = "Precio";
            this.Precio.MaxInputLength = 64000;
            this.Precio.MinimumWidth = 10;
            this.Precio.Name = "Precio";
            this.Precio.Width = 124;
            // 
            // cabeceraLayout
            // 
            this.cabeceraLayout.ColumnCount = 1;
            this.cabeceraLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cabeceraLayout.Controls.Add(this.ConfiguracionVentaGroupBox, 0, 0);
            this.cabeceraLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cabeceraLayout.Location = new System.Drawing.Point(3, 3);
            this.cabeceraLayout.Name = "cabeceraLayout";
            this.cabeceraLayout.RowCount = 1;
            this.cabeceraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.87533F));
            this.cabeceraLayout.Size = new System.Drawing.Size(1543, 214);
            this.cabeceraLayout.TabIndex = 1;
            // 
            // ConfiguracionVentaGroupBox
            // 
            this.ConfiguracionVentaGroupBox.Controls.Add(this.configuracionVentaLayout);
            this.ConfiguracionVentaGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfiguracionVentaGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ConfiguracionVentaGroupBox.Name = "ConfiguracionVentaGroupBox";
            this.ConfiguracionVentaGroupBox.Size = new System.Drawing.Size(1537, 208);
            this.ConfiguracionVentaGroupBox.TabIndex = 1;
            this.ConfiguracionVentaGroupBox.TabStop = false;
            this.ConfiguracionVentaGroupBox.Text = "Configuración de cotización";
            this.ConfiguracionVentaGroupBox.Enter += new System.EventHandler(this.ConfiguracionVentaGroupBox_Enter);
            // 
            // configuracionVentaLayout
            // 
            this.configuracionVentaLayout.ColumnCount = 6;
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.79085F));
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.03268F));
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.81046F));
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.05229F));
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.35947F));
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.95425F));
            this.configuracionVentaLayout.Controls.Add(this.CostoTotalLabel, 0, 0);
            this.configuracionVentaLayout.Controls.Add(this.CodigoProductoInput, 0, 0);
            this.configuracionVentaLayout.Controls.Add(this.DescuentoLabel, 4, 0);
            this.configuracionVentaLayout.Controls.Add(this.CodigoBarraLabel, 0, 0);
            this.configuracionVentaLayout.Controls.Add(this.NombreCotizacionInput, 1, 0);
            this.configuracionVentaLayout.Controls.Add(this.DescuentoInput, 5, 0);
            this.configuracionVentaLayout.Controls.Add(this.ClienteLabel, 0, 1);
            this.configuracionVentaLayout.Controls.Add(this.RutClienteInput, 1, 1);
            this.configuracionVentaLayout.Controls.Add(this.NombreClienteLabel, 2, 1);
            this.configuracionVentaLayout.Controls.Add(this.RegionLabel, 4, 1);
            this.configuracionVentaLayout.Controls.Add(this.NombreClienteInput, 3, 1);
            this.configuracionVentaLayout.Controls.Add(this.RegionInput, 5, 1);
            this.configuracionVentaLayout.Controls.Add(this.SectorLabel, 0, 2);
            this.configuracionVentaLayout.Controls.Add(this.SectorInput, 1, 2);
            this.configuracionVentaLayout.Controls.Add(this.ComunaLabel, 2, 2);
            this.configuracionVentaLayout.Controls.Add(this.ComunaInput, 3, 2);
            this.configuracionVentaLayout.Controls.Add(this.label1, 4, 2);
            this.configuracionVentaLayout.Controls.Add(this.textBox1, 5, 2);
            this.configuracionVentaLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configuracionVentaLayout.Location = new System.Drawing.Point(3, 35);
            this.configuracionVentaLayout.Name = "configuracionVentaLayout";
            this.configuracionVentaLayout.RowCount = 3;
            this.configuracionVentaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.configuracionVentaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.configuracionVentaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.configuracionVentaLayout.Size = new System.Drawing.Size(1531, 170);
            this.configuracionVentaLayout.TabIndex = 0;
            // 
            // CostoTotalLabel
            // 
            this.CostoTotalLabel.AutoSize = true;
            this.CostoTotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CostoTotalLabel.Location = new System.Drawing.Point(444, 0);
            this.CostoTotalLabel.Name = "CostoTotalLabel";
            this.CostoTotalLabel.Size = new System.Drawing.Size(190, 56);
            this.CostoTotalLabel.TabIndex = 9;
            this.CostoTotalLabel.Text = "Nombre";
            this.CostoTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodigoProductoInput
            // 
            this.CodigoProductoInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodigoProductoInput.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodigoProductoInput.Location = new System.Drawing.Point(214, 10);
            this.CodigoProductoInput.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.CodigoProductoInput.Name = "CodigoProductoInput";
            this.CodigoProductoInput.Size = new System.Drawing.Size(224, 43);
            this.CodigoProductoInput.TabIndex = 8;
            // 
            // DescuentoLabel
            // 
            this.DescuentoLabel.AutoSize = true;
            this.DescuentoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescuentoLabel.Location = new System.Drawing.Point(1008, 0);
            this.DescuentoLabel.Name = "DescuentoLabel";
            this.DescuentoLabel.Size = new System.Drawing.Size(229, 56);
            this.DescuentoLabel.TabIndex = 4;
            this.DescuentoLabel.Text = "Descuento";
            this.DescuentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodigoBarraLabel
            // 
            this.CodigoBarraLabel.AutoSize = true;
            this.CodigoBarraLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodigoBarraLabel.Location = new System.Drawing.Point(3, 0);
            this.CodigoBarraLabel.Name = "CodigoBarraLabel";
            this.CodigoBarraLabel.Size = new System.Drawing.Size(205, 56);
            this.CodigoBarraLabel.TabIndex = 0;
            this.CodigoBarraLabel.Text = "Código de barra";
            this.CodigoBarraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NombreCotizacionInput
            // 
            this.NombreCotizacionInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombreCotizacionInput.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NombreCotizacionInput.Location = new System.Drawing.Point(640, 10);
            this.NombreCotizacionInput.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.NombreCotizacionInput.Name = "NombreCotizacionInput";
            this.NombreCotizacionInput.Size = new System.Drawing.Size(362, 43);
            this.NombreCotizacionInput.TabIndex = 5;
            // 
            // DescuentoInput
            // 
            this.DescuentoInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescuentoInput.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescuentoInput.Location = new System.Drawing.Point(1243, 9);
            this.DescuentoInput.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.DescuentoInput.Name = "DescuentoInput";
            this.DescuentoInput.Size = new System.Drawing.Size(285, 46);
            this.DescuentoInput.TabIndex = 10;
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClienteLabel.Location = new System.Drawing.Point(3, 56);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(205, 56);
            this.ClienteLabel.TabIndex = 11;
            this.ClienteLabel.Text = "R.U.T Cliente";
            this.ClienteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RutClienteInput
            // 
            this.RutClienteInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RutClienteInput.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RutClienteInput.Location = new System.Drawing.Point(214, 59);
            this.RutClienteInput.Name = "RutClienteInput";
            this.RutClienteInput.Size = new System.Drawing.Size(224, 46);
            this.RutClienteInput.TabIndex = 12;
            // 
            // NombreClienteLabel
            // 
            this.NombreClienteLabel.AutoSize = true;
            this.NombreClienteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombreClienteLabel.Location = new System.Drawing.Point(444, 56);
            this.NombreClienteLabel.Name = "NombreClienteLabel";
            this.NombreClienteLabel.Size = new System.Drawing.Size(190, 56);
            this.NombreClienteLabel.TabIndex = 13;
            this.NombreClienteLabel.Text = "Nombre Cliente";
            this.NombreClienteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegionLabel.Location = new System.Drawing.Point(1008, 56);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(229, 56);
            this.RegionLabel.TabIndex = 14;
            this.RegionLabel.Text = "Región";
            this.RegionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NombreClienteInput
            // 
            this.NombreClienteInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombreClienteInput.Location = new System.Drawing.Point(640, 59);
            this.NombreClienteInput.Name = "NombreClienteInput";
            this.NombreClienteInput.Size = new System.Drawing.Size(362, 39);
            this.NombreClienteInput.TabIndex = 15;
            // 
            // RegionInput
            // 
            this.RegionInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegionInput.Location = new System.Drawing.Point(1243, 59);
            this.RegionInput.Name = "RegionInput";
            this.RegionInput.Size = new System.Drawing.Size(285, 39);
            this.RegionInput.TabIndex = 16;
            // 
            // SectorLabel
            // 
            this.SectorLabel.AutoSize = true;
            this.SectorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectorLabel.Location = new System.Drawing.Point(3, 112);
            this.SectorLabel.Name = "SectorLabel";
            this.SectorLabel.Size = new System.Drawing.Size(205, 58);
            this.SectorLabel.TabIndex = 17;
            this.SectorLabel.Text = "Sector";
            this.SectorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SectorInput
            // 
            this.SectorInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectorInput.Location = new System.Drawing.Point(214, 115);
            this.SectorInput.Name = "SectorInput";
            this.SectorInput.Size = new System.Drawing.Size(224, 39);
            this.SectorInput.TabIndex = 18;
            // 
            // ComunaLabel
            // 
            this.ComunaLabel.AutoSize = true;
            this.ComunaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComunaLabel.Location = new System.Drawing.Point(444, 112);
            this.ComunaLabel.Name = "ComunaLabel";
            this.ComunaLabel.Size = new System.Drawing.Size(190, 58);
            this.ComunaLabel.TabIndex = 19;
            this.ComunaLabel.Text = "Comuna";
            this.ComunaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComunaInput
            // 
            this.ComunaInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComunaInput.Location = new System.Drawing.Point(640, 115);
            this.ComunaInput.Name = "ComunaInput";
            this.ComunaInput.Size = new System.Drawing.Size(362, 39);
            this.ComunaInput.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(1008, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 58);
            this.label1.TabIndex = 21;
            this.label1.Text = "Telefono";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(1243, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 39);
            this.textBox1.TabIndex = 22;
            // 
            // BotonesLayout
            // 
            this.BotonesLayout.ColumnCount = 7;
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BotonesLayout.Controls.Add(this.BorrarProductoButton, 1, 0);
            this.BotonesLayout.Controls.Add(this.ResetBuscador, 3, 0);
            this.BotonesLayout.Controls.Add(this.GuardarOfertaButton, 5, 0);
            this.BotonesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotonesLayout.Location = new System.Drawing.Point(3, 688);
            this.BotonesLayout.Name = "BotonesLayout";
            this.BotonesLayout.RowCount = 1;
            this.BotonesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BotonesLayout.Size = new System.Drawing.Size(1543, 57);
            this.BotonesLayout.TabIndex = 2;
            // 
            // BorrarProductoButton
            // 
            this.BorrarProductoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorrarProductoButton.Location = new System.Drawing.Point(157, 3);
            this.BorrarProductoButton.Name = "BorrarProductoButton";
            this.BorrarProductoButton.Size = new System.Drawing.Size(302, 51);
            this.BorrarProductoButton.TabIndex = 0;
            this.BorrarProductoButton.Text = "Borrar Producto";
            this.BorrarProductoButton.UseVisualStyleBackColor = true;
            // 
            // ResetBuscador
            // 
            this.ResetBuscador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetBuscador.Location = new System.Drawing.Point(619, 3);
            this.ResetBuscador.Name = "ResetBuscador";
            this.ResetBuscador.Size = new System.Drawing.Size(302, 51);
            this.ResetBuscador.TabIndex = 1;
            this.ResetBuscador.Text = "Reiniciar buscador";
            this.ResetBuscador.UseVisualStyleBackColor = true;
            // 
            // GuardarOfertaButton
            // 
            this.GuardarOfertaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GuardarOfertaButton.Location = new System.Drawing.Point(1081, 3);
            this.GuardarOfertaButton.Name = "GuardarOfertaButton";
            this.GuardarOfertaButton.Size = new System.Drawing.Size(302, 51);
            this.GuardarOfertaButton.TabIndex = 2;
            this.GuardarOfertaButton.Text = "Guardar oferta";
            this.GuardarOfertaButton.UseVisualStyleBackColor = true;
            // 
            // CrearCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 783);
            this.Controls.Add(this.mainLayout);
            this.Name = "CrearCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear cotización";
            this.mainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productosEnOfertaView)).EndInit();
            this.cabeceraLayout.ResumeLayout(false);
            this.ConfiguracionVentaGroupBox.ResumeLayout(false);
            this.configuracionVentaLayout.ResumeLayout(false);
            this.configuracionVentaLayout.PerformLayout();
            this.BotonesLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.DataGridView productosEnOfertaView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.TableLayoutPanel cabeceraLayout;
        private System.Windows.Forms.GroupBox ConfiguracionVentaGroupBox;
        private System.Windows.Forms.TableLayoutPanel configuracionVentaLayout;
        private System.Windows.Forms.Label CostoTotalLabel;
        private System.Windows.Forms.TextBox CodigoProductoInput;
        private System.Windows.Forms.Label DescuentoLabel;
        private System.Windows.Forms.Label CodigoBarraLabel;
        private System.Windows.Forms.TextBox NombreCotizacionInput;
        private System.Windows.Forms.TextBox DescuentoInput;
        private System.Windows.Forms.TableLayoutPanel BotonesLayout;
        private System.Windows.Forms.Button BorrarProductoButton;
        private System.Windows.Forms.Button ResetBuscador;
        private System.Windows.Forms.Button GuardarOfertaButton;
        private System.Windows.Forms.Label ClienteLabel;
        private System.Windows.Forms.TextBox RutClienteInput;
        private System.Windows.Forms.Label NombreClienteLabel;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.TextBox NombreClienteInput;
        private System.Windows.Forms.TextBox RegionInput;
        private System.Windows.Forms.Label SectorLabel;
        private System.Windows.Forms.TextBox SectorInput;
        private System.Windows.Forms.Label ComunaLabel;
        private System.Windows.Forms.TextBox ComunaInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
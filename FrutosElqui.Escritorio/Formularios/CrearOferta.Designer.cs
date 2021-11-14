
namespace FrutosElqui.Escritorio.Formularios
{
    partial class CrearOferta
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
            this.TipoPagoLabel = new System.Windows.Forms.Label();
            this.CodigoBarraLabel = new System.Windows.Forms.Label();
            this.NombreOfertaInput = new System.Windows.Forms.TextBox();
            this.PrecioOfertaInput = new System.Windows.Forms.TextBox();
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
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.45338F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.77267F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.62346F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.Size = new System.Drawing.Size(1549, 783);
            this.mainLayout.TabIndex = 1;
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
            this.productosEnOfertaView.Location = new System.Drawing.Point(3, 124);
            this.productosEnOfertaView.Name = "productosEnOfertaView";
            this.productosEnOfertaView.RowHeadersVisible = false;
            this.productosEnOfertaView.RowHeadersWidth = 82;
            this.productosEnOfertaView.RowTemplate.Height = 41;
            this.productosEnOfertaView.Size = new System.Drawing.Size(1543, 509);
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
            this.cabeceraLayout.Size = new System.Drawing.Size(1543, 115);
            this.cabeceraLayout.TabIndex = 1;
            // 
            // ConfiguracionVentaGroupBox
            // 
            this.ConfiguracionVentaGroupBox.Controls.Add(this.configuracionVentaLayout);
            this.ConfiguracionVentaGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfiguracionVentaGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ConfiguracionVentaGroupBox.Name = "ConfiguracionVentaGroupBox";
            this.ConfiguracionVentaGroupBox.Size = new System.Drawing.Size(1537, 109);
            this.ConfiguracionVentaGroupBox.TabIndex = 1;
            this.ConfiguracionVentaGroupBox.TabStop = false;
            this.ConfiguracionVentaGroupBox.Text = "Configuración de oferta";
            // 
            // configuracionVentaLayout
            // 
            this.configuracionVentaLayout.ColumnCount = 6;
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.04311F));
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.666884F));
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.02286F));
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.97583F));
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.34944F));
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.94187F));
            this.configuracionVentaLayout.Controls.Add(this.CostoTotalLabel, 0, 0);
            this.configuracionVentaLayout.Controls.Add(this.CodigoProductoInput, 0, 0);
            this.configuracionVentaLayout.Controls.Add(this.TipoPagoLabel, 4, 0);
            this.configuracionVentaLayout.Controls.Add(this.CodigoBarraLabel, 0, 0);
            this.configuracionVentaLayout.Controls.Add(this.NombreOfertaInput, 1, 0);
            this.configuracionVentaLayout.Controls.Add(this.PrecioOfertaInput, 5, 0);
            this.configuracionVentaLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configuracionVentaLayout.Location = new System.Drawing.Point(3, 35);
            this.configuracionVentaLayout.Name = "configuracionVentaLayout";
            this.configuracionVentaLayout.RowCount = 1;
            this.configuracionVentaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.configuracionVentaLayout.Size = new System.Drawing.Size(1531, 71);
            this.configuracionVentaLayout.TabIndex = 0;
            // 
            // CostoTotalLabel
            // 
            this.CostoTotalLabel.AutoSize = true;
            this.CostoTotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CostoTotalLabel.Location = new System.Drawing.Point(366, 0);
            this.CostoTotalLabel.Name = "CostoTotalLabel";
            this.CostoTotalLabel.Size = new System.Drawing.Size(223, 71);
            this.CostoTotalLabel.TabIndex = 9;
            this.CostoTotalLabel.Text = "Nombre oferta";
            this.CostoTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodigoProductoInput
            // 
            this.CodigoProductoInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodigoProductoInput.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodigoProductoInput.Location = new System.Drawing.Point(218, 10);
            this.CodigoProductoInput.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.CodigoProductoInput.Name = "CodigoProductoInput";
            this.CodigoProductoInput.Size = new System.Drawing.Size(142, 43);
            this.CodigoProductoInput.TabIndex = 8;
            this.CodigoProductoInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyBusquedaPress);
            // 
            // TipoPagoLabel
            // 
            this.TipoPagoLabel.AutoSize = true;
            this.TipoPagoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipoPagoLabel.Location = new System.Drawing.Point(1007, 0);
            this.TipoPagoLabel.Name = "TipoPagoLabel";
            this.TipoPagoLabel.Size = new System.Drawing.Size(228, 71);
            this.TipoPagoLabel.TabIndex = 4;
            this.TipoPagoLabel.Text = "Precio de oferta";
            this.TipoPagoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodigoBarraLabel
            // 
            this.CodigoBarraLabel.AutoSize = true;
            this.CodigoBarraLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodigoBarraLabel.Location = new System.Drawing.Point(3, 0);
            this.CodigoBarraLabel.Name = "CodigoBarraLabel";
            this.CodigoBarraLabel.Size = new System.Drawing.Size(209, 71);
            this.CodigoBarraLabel.TabIndex = 0;
            this.CodigoBarraLabel.Text = "Código de barra";
            this.CodigoBarraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NombreOfertaInput
            // 
            this.NombreOfertaInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombreOfertaInput.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NombreOfertaInput.Location = new System.Drawing.Point(595, 10);
            this.NombreOfertaInput.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.NombreOfertaInput.Name = "NombreOfertaInput";
            this.NombreOfertaInput.Size = new System.Drawing.Size(406, 43);
            this.NombreOfertaInput.TabIndex = 5;
            // 
            // PrecioOfertaInput
            // 
            this.PrecioOfertaInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrecioOfertaInput.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrecioOfertaInput.Location = new System.Drawing.Point(1241, 9);
            this.PrecioOfertaInput.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.PrecioOfertaInput.Name = "PrecioOfertaInput";
            this.PrecioOfertaInput.Size = new System.Drawing.Size(287, 46);
            this.PrecioOfertaInput.TabIndex = 10;
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
            this.BotonesLayout.Location = new System.Drawing.Point(3, 639);
            this.BotonesLayout.Name = "BotonesLayout";
            this.BotonesLayout.RowCount = 1;
            this.BotonesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BotonesLayout.Size = new System.Drawing.Size(1543, 61);
            this.BotonesLayout.TabIndex = 2;
            // 
            // BorrarProductoButton
            // 
            this.BorrarProductoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorrarProductoButton.Location = new System.Drawing.Point(157, 3);
            this.BorrarProductoButton.Name = "BorrarProductoButton";
            this.BorrarProductoButton.Size = new System.Drawing.Size(302, 55);
            this.BorrarProductoButton.TabIndex = 0;
            this.BorrarProductoButton.Text = "Borrar Producto";
            this.BorrarProductoButton.UseVisualStyleBackColor = true;
            // 
            // ResetBuscador
            // 
            this.ResetBuscador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetBuscador.Location = new System.Drawing.Point(619, 3);
            this.ResetBuscador.Name = "ResetBuscador";
            this.ResetBuscador.Size = new System.Drawing.Size(302, 55);
            this.ResetBuscador.TabIndex = 1;
            this.ResetBuscador.Text = "Reiniciar buscador";
            this.ResetBuscador.UseVisualStyleBackColor = true;
            // 
            // GuardarOfertaButton
            // 
            this.GuardarOfertaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GuardarOfertaButton.Location = new System.Drawing.Point(1081, 3);
            this.GuardarOfertaButton.Name = "GuardarOfertaButton";
            this.GuardarOfertaButton.Size = new System.Drawing.Size(302, 55);
            this.GuardarOfertaButton.TabIndex = 2;
            this.GuardarOfertaButton.Text = "Guardar oferta";
            this.GuardarOfertaButton.UseVisualStyleBackColor = true;
            this.GuardarOfertaButton.Click += new System.EventHandler(this.CrearOfertaClick);
            // 
            // CrearOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 783);
            this.Controls.Add(this.mainLayout);
            this.Name = "CrearOferta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear oferta";
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
        private System.Windows.Forms.Label TipoPagoLabel;
        private System.Windows.Forms.Label CodigoBarraLabel;
        private System.Windows.Forms.TextBox NombreOfertaInput;
        private System.Windows.Forms.TextBox PrecioOfertaInput;
        private System.Windows.Forms.TableLayoutPanel BotonesLayout;
        private System.Windows.Forms.Button BorrarProductoButton;
        private System.Windows.Forms.Button ResetBuscador;
        private System.Windows.Forms.Button GuardarOfertaButton;
    }
}
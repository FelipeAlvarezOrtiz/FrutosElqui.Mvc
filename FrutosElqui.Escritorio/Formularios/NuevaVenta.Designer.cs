
namespace FrutosElqui.Escritorio.Formularios
{
    partial class NuevaVenta
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
            this.productoCanasta = new System.Windows.Forms.DataGridView();
            this.CodeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabeceraLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ConfiguracionVentaGroupBox = new System.Windows.Forms.GroupBox();
            this.configuracionVentaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TipoPagoCombo = new System.Windows.Forms.ComboBox();
            this.TipoPagoLabel = new System.Windows.Forms.Label();
            this.TipoVentaLabel = new System.Windows.Forms.Label();
            this.CodigoBarraLabel = new System.Windows.Forms.Label();
            this.CodigoBarraInput = new System.Windows.Forms.TextBox();
            this.TipoVentaCombo = new System.Windows.Forms.ComboBox();
            this.BotonesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BorrarProductoButton = new System.Windows.Forms.Button();
            this.ResetBuscador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalVentaTextbox = new System.Windows.Forms.TextBox();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoCanasta)).BeginInit();
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
            this.mainLayout.Controls.Add(this.productoCanasta, 0, 1);
            this.mainLayout.Controls.Add(this.cabeceraLayout, 0, 0);
            this.mainLayout.Controls.Add(this.BotonesLayout, 0, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 4;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.97911F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.38136F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.62346F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.Size = new System.Drawing.Size(1549, 783);
            this.mainLayout.TabIndex = 0;
            // 
            // productoCanasta
            // 
            this.productoCanasta.AllowUserToDeleteRows = false;
            this.productoCanasta.AllowUserToResizeColumns = false;
            this.productoCanasta.AllowUserToResizeRows = false;
            this.productoCanasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productoCanasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoCanasta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeID,
            this.NombreProducto,
            this.Cantidad,
            this.Precio});
            this.productoCanasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productoCanasta.Location = new System.Drawing.Point(3, 135);
            this.productoCanasta.Name = "productoCanasta";
            this.productoCanasta.RowHeadersWidth = 82;
            this.productoCanasta.RowTemplate.Height = 41;
            this.productoCanasta.Size = new System.Drawing.Size(1543, 498);
            this.productoCanasta.TabIndex = 0;
            // 
            // CodeID
            // 
            this.CodeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodeID.HeaderText = "Codigo de Barra";
            this.CodeID.MinimumWidth = 200;
            this.CodeID.Name = "CodeID";
            this.CodeID.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreProducto.HeaderText = "Nombre de Producto";
            this.NombreProducto.MinimumWidth = 560;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 10;
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.MaxInputLength = 64000;
            this.Precio.MinimumWidth = 10;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
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
            this.cabeceraLayout.Size = new System.Drawing.Size(1543, 126);
            this.cabeceraLayout.TabIndex = 1;
            // 
            // ConfiguracionVentaGroupBox
            // 
            this.ConfiguracionVentaGroupBox.Controls.Add(this.configuracionVentaLayout);
            this.ConfiguracionVentaGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfiguracionVentaGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ConfiguracionVentaGroupBox.Name = "ConfiguracionVentaGroupBox";
            this.ConfiguracionVentaGroupBox.Size = new System.Drawing.Size(1537, 120);
            this.ConfiguracionVentaGroupBox.TabIndex = 1;
            this.ConfiguracionVentaGroupBox.TabStop = false;
            this.ConfiguracionVentaGroupBox.Text = "Configuración de venta";
            // 
            // configuracionVentaLayout
            // 
            this.configuracionVentaLayout.ColumnCount = 6;
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.configuracionVentaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.configuracionVentaLayout.Controls.Add(this.TipoPagoCombo, 5, 0);
            this.configuracionVentaLayout.Controls.Add(this.TipoPagoLabel, 4, 0);
            this.configuracionVentaLayout.Controls.Add(this.TipoVentaLabel, 2, 0);
            this.configuracionVentaLayout.Controls.Add(this.CodigoBarraLabel, 0, 0);
            this.configuracionVentaLayout.Controls.Add(this.CodigoBarraInput, 1, 0);
            this.configuracionVentaLayout.Controls.Add(this.TipoVentaCombo, 3, 0);
            this.configuracionVentaLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configuracionVentaLayout.Location = new System.Drawing.Point(3, 35);
            this.configuracionVentaLayout.Name = "configuracionVentaLayout";
            this.configuracionVentaLayout.RowCount = 1;
            this.configuracionVentaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.configuracionVentaLayout.Size = new System.Drawing.Size(1531, 82);
            this.configuracionVentaLayout.TabIndex = 0;
            // 
            // TipoPagoCombo
            // 
            this.TipoPagoCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipoPagoCombo.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TipoPagoCombo.FormattingEnabled = true;
            this.TipoPagoCombo.Items.AddRange(new object[] {
            "Efectivo",
            "Debito",
            "Credito",
            "Cheque"});
            this.TipoPagoCombo.Location = new System.Drawing.Point(1278, 3);
            this.TipoPagoCombo.Name = "TipoPagoCombo";
            this.TipoPagoCombo.Size = new System.Drawing.Size(250, 45);
            this.TipoPagoCombo.TabIndex = 7;
            // 
            // TipoPagoLabel
            // 
            this.TipoPagoLabel.AutoSize = true;
            this.TipoPagoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipoPagoLabel.Location = new System.Drawing.Point(1023, 0);
            this.TipoPagoLabel.Name = "TipoPagoLabel";
            this.TipoPagoLabel.Size = new System.Drawing.Size(249, 82);
            this.TipoPagoLabel.TabIndex = 4;
            this.TipoPagoLabel.Text = "Tipo de pago";
            this.TipoPagoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TipoVentaLabel
            // 
            this.TipoVentaLabel.AutoSize = true;
            this.TipoVentaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipoVentaLabel.Location = new System.Drawing.Point(513, 0);
            this.TipoVentaLabel.Name = "TipoVentaLabel";
            this.TipoVentaLabel.Size = new System.Drawing.Size(249, 82);
            this.TipoVentaLabel.TabIndex = 2;
            this.TipoVentaLabel.Text = "Tipo de venta";
            this.TipoVentaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodigoBarraLabel
            // 
            this.CodigoBarraLabel.AutoSize = true;
            this.CodigoBarraLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodigoBarraLabel.Location = new System.Drawing.Point(3, 0);
            this.CodigoBarraLabel.Name = "CodigoBarraLabel";
            this.CodigoBarraLabel.Size = new System.Drawing.Size(249, 82);
            this.CodigoBarraLabel.TabIndex = 0;
            this.CodigoBarraLabel.Text = "Código de barra";
            this.CodigoBarraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodigoBarraInput
            // 
            this.CodigoBarraInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodigoBarraInput.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodigoBarraInput.Location = new System.Drawing.Point(258, 10);
            this.CodigoBarraInput.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.CodigoBarraInput.Name = "CodigoBarraInput";
            this.CodigoBarraInput.Size = new System.Drawing.Size(249, 43);
            this.CodigoBarraInput.TabIndex = 5;
            this.CodigoBarraInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntroKeyInput);
            // 
            // TipoVentaCombo
            // 
            this.TipoVentaCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipoVentaCombo.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TipoVentaCombo.FormattingEnabled = true;
            this.TipoVentaCombo.Items.AddRange(new object[] {
            "Detalle",
            "Mayorista"});
            this.TipoVentaCombo.Location = new System.Drawing.Point(768, 3);
            this.TipoVentaCombo.Name = "TipoVentaCombo";
            this.TipoVentaCombo.Size = new System.Drawing.Size(249, 45);
            this.TipoVentaCombo.TabIndex = 6;
            // 
            // BotonesLayout
            // 
            this.BotonesLayout.ColumnCount = 7;
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.169872F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.78483F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.3046F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07194F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.453013F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.92482F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.17434F));
            this.BotonesLayout.Controls.Add(this.BorrarProductoButton, 1, 0);
            this.BotonesLayout.Controls.Add(this.ResetBuscador, 3, 0);
            this.BotonesLayout.Controls.Add(this.label1, 5, 0);
            this.BotonesLayout.Controls.Add(this.TotalVentaTextbox, 6, 0);
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
            this.BorrarProductoButton.Location = new System.Drawing.Point(98, 3);
            this.BorrarProductoButton.Name = "BorrarProductoButton";
            this.BorrarProductoButton.Size = new System.Drawing.Size(361, 55);
            this.BorrarProductoButton.TabIndex = 0;
            this.BorrarProductoButton.Text = "Borrar Producto";
            this.BorrarProductoButton.UseVisualStyleBackColor = true;
            this.BorrarProductoButton.Click += new System.EventHandler(this.BorrarProductoClick);
            // 
            // ResetBuscador
            // 
            this.ResetBuscador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetBuscador.Location = new System.Drawing.Point(624, 3);
            this.ResetBuscador.Name = "ResetBuscador";
            this.ResetBuscador.Size = new System.Drawing.Size(350, 55);
            this.ResetBuscador.TabIndex = 1;
            this.ResetBuscador.Text = "Reiniciar buscador";
            this.ResetBuscador.UseVisualStyleBackColor = true;
            this.ResetBuscador.Click += new System.EventHandler(this.ResetBuscadorClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(1095, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalVentaTextbox
            // 
            this.TotalVentaTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalVentaTextbox.Location = new System.Drawing.Point(1279, 3);
            this.TotalVentaTextbox.Name = "TotalVentaTextbox";
            this.TotalVentaTextbox.Size = new System.Drawing.Size(261, 39);
            this.TotalVentaTextbox.TabIndex = 3;
            this.TotalVentaTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 783);
            this.Controls.Add(this.mainLayout);
            this.Name = "NuevaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Venta";
            this.mainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productoCanasta)).EndInit();
            this.cabeceraLayout.ResumeLayout(false);
            this.ConfiguracionVentaGroupBox.ResumeLayout(false);
            this.configuracionVentaLayout.ResumeLayout(false);
            this.configuracionVentaLayout.PerformLayout();
            this.BotonesLayout.ResumeLayout(false);
            this.BotonesLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.DataGridView productoCanasta;
        private System.Windows.Forms.TableLayoutPanel cabeceraLayout;
        private System.Windows.Forms.TableLayoutPanel BotonesLayout;
        private System.Windows.Forms.Button BorrarProductoButton;
        private System.Windows.Forms.Button ResetBuscador;
        private System.Windows.Forms.GroupBox ConfiguracionVentaGroupBox;
        private System.Windows.Forms.TableLayoutPanel configuracionVentaLayout;
        private System.Windows.Forms.ComboBox TipoPagoCombo;
        private System.Windows.Forms.Label TipoPagoLabel;
        private System.Windows.Forms.Label TipoVentaLabel;
        private System.Windows.Forms.Label CodigoBarraLabel;
        private System.Windows.Forms.TextBox CodigoBarraInput;
        private System.Windows.Forms.ComboBox TipoVentaCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalVentaTextbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}
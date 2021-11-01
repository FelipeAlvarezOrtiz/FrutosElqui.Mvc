
namespace FrutosElqui.Escritorio.Formularios
{
    partial class Productos
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
            this.MainLayoutProductos = new System.Windows.Forms.TableLayoutPanel();
            this.OpcionesGroupbox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BusquedaAvanzadaLabel = new System.Windows.Forms.Label();
            this.BusquedaAvanzadaInput = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ProductosView = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RefrescarLista = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.NuevoProductoForm = new System.Windows.Forms.Button();
            this.MainLayoutProductos.SuspendLayout();
            this.OpcionesGroupbox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayoutProductos
            // 
            this.MainLayoutProductos.ColumnCount = 1;
            this.MainLayoutProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutProductos.Controls.Add(this.OpcionesGroupbox, 0, 0);
            this.MainLayoutProductos.Controls.Add(this.ProductosView, 0, 1);
            this.MainLayoutProductos.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.MainLayoutProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutProductos.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutProductos.Name = "MainLayoutProductos";
            this.MainLayoutProductos.RowCount = 3;
            this.MainLayoutProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.77826F));
            this.MainLayoutProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.15178F));
            this.MainLayoutProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainLayoutProductos.Size = new System.Drawing.Size(1214, 929);
            this.MainLayoutProductos.TabIndex = 0;
            // 
            // OpcionesGroupbox
            // 
            this.OpcionesGroupbox.Controls.Add(this.tableLayoutPanel2);
            this.OpcionesGroupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpcionesGroupbox.Location = new System.Drawing.Point(3, 3);
            this.OpcionesGroupbox.Name = "OpcionesGroupbox";
            this.OpcionesGroupbox.Size = new System.Drawing.Size(1208, 122);
            this.OpcionesGroupbox.TabIndex = 0;
            this.OpcionesGroupbox.TabStop = false;
            this.OpcionesGroupbox.Text = "Opciones";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.BusquedaAvanzadaLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BusquedaAvanzadaInput, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BuscarButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1202, 84);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BusquedaAvanzadaLabel
            // 
            this.BusquedaAvanzadaLabel.AutoSize = true;
            this.BusquedaAvanzadaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BusquedaAvanzadaLabel.Location = new System.Drawing.Point(3, 0);
            this.BusquedaAvanzadaLabel.Name = "BusquedaAvanzadaLabel";
            this.BusquedaAvanzadaLabel.Size = new System.Drawing.Size(394, 84);
            this.BusquedaAvanzadaLabel.TabIndex = 0;
            this.BusquedaAvanzadaLabel.Text = "Busqueda avanzada";
            this.BusquedaAvanzadaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BusquedaAvanzadaInput
            // 
            this.BusquedaAvanzadaInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BusquedaAvanzadaInput.Location = new System.Drawing.Point(403, 3);
            this.BusquedaAvanzadaInput.Name = "BusquedaAvanzadaInput";
            this.BusquedaAvanzadaInput.Size = new System.Drawing.Size(394, 39);
            this.BusquedaAvanzadaInput.TabIndex = 1;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuscarButton.Location = new System.Drawing.Point(815, 15);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(15);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(372, 54);
            this.BuscarButton.TabIndex = 2;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // ProductosView
            // 
            this.ProductosView.AllowUserToAddRows = false;
            this.ProductosView.AllowUserToDeleteRows = false;
            this.ProductosView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.NombreProducto,
            this.Categoria,
            this.Medida,
            this.Proveedor});
            this.ProductosView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductosView.Location = new System.Drawing.Point(3, 131);
            this.ProductosView.Name = "ProductosView";
            this.ProductosView.RowHeadersWidth = 82;
            this.ProductosView.RowTemplate.Height = 41;
            this.ProductosView.Size = new System.Drawing.Size(1208, 655);
            this.ProductosView.TabIndex = 1;
            // 
            // IdProducto
            // 
            this.IdProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdProducto.FillWeight = 51.28205F;
            this.IdProducto.HeaderText = "Id";
            this.IdProducto.MinimumWidth = 10;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Width = 40;
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreProducto.FillWeight = 106.9597F;
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.MinimumWidth = 10;
            this.NombreProducto.Name = "NombreProducto";
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Categoria.FillWeight = 106.9597F;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 10;
            this.Categoria.Name = "Categoria";
            // 
            // Medida
            // 
            this.Medida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medida.FillWeight = 106.9597F;
            this.Medida.HeaderText = "Medida";
            this.Medida.MinimumWidth = 10;
            this.Medida.Name = "Medida";
            // 
            // Proveedor
            // 
            this.Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Proveedor.FillWeight = 106.9597F;
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 10;
            this.Proveedor.Name = "Proveedor";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.RefrescarLista, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditarButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.NuevoProductoForm, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 792);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1208, 134);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // RefrescarLista
            // 
            this.RefrescarLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefrescarLista.Location = new System.Drawing.Point(123, 3);
            this.RefrescarLista.Name = "RefrescarLista";
            this.RefrescarLista.Size = new System.Drawing.Size(235, 128);
            this.RefrescarLista.TabIndex = 0;
            this.RefrescarLista.Text = "Refrescar";
            this.RefrescarLista.UseVisualStyleBackColor = true;
            this.RefrescarLista.Click += new System.EventHandler(this.RefrescarListaClick);
            // 
            // EditarButton
            // 
            this.EditarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditarButton.Location = new System.Drawing.Point(484, 3);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(235, 128);
            this.EditarButton.TabIndex = 1;
            this.EditarButton.Text = "Editar";
            this.EditarButton.UseVisualStyleBackColor = true;
            this.EditarButton.Click += new System.EventHandler(this.EditarProductoClick);
            // 
            // NuevoProductoForm
            // 
            this.NuevoProductoForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NuevoProductoForm.Location = new System.Drawing.Point(845, 3);
            this.NuevoProductoForm.Name = "NuevoProductoForm";
            this.NuevoProductoForm.Size = new System.Drawing.Size(235, 128);
            this.NuevoProductoForm.TabIndex = 2;
            this.NuevoProductoForm.Text = "Agregar nuevo producto";
            this.NuevoProductoForm.UseVisualStyleBackColor = true;
            this.NuevoProductoForm.Click += new System.EventHandler(this.NuevoProductoFormClick);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 929);
            this.Controls.Add(this.MainLayoutProductos);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.LoadFormEvent);
            this.MainLayoutProductos.ResumeLayout(false);
            this.OpcionesGroupbox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutProductos;
        private System.Windows.Forms.GroupBox OpcionesGroupbox;
        private System.Windows.Forms.DataGridView ProductosView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button RefrescarLista;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.Button NuevoProductoForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label BusquedaAvanzadaLabel;
        private System.Windows.Forms.TextBox BusquedaAvanzadaInput;
        private System.Windows.Forms.Button BuscarButton;
    }
}
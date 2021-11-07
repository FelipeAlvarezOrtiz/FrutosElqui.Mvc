
namespace FrutosElqui.Escritorio.Formularios
{
    partial class AgregarProductoEnSucursal
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
            this.TopLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SucursalLabel = new System.Windows.Forms.Label();
            this.SucursalBox = new System.Windows.Forms.ComboBox();
            this.ProductoDataLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.ProveedorNombreInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreProductoInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdProductoLabel = new System.Windows.Forms.Label();
            this.IdProductoInput = new System.Windows.Forms.TextBox();
            this.ValidarProducto = new System.Windows.Forms.Button();
            this.CantidadInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.MainLayout.SuspendLayout();
            this.TopLayout.SuspendLayout();
            this.ProductoDataLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Controls.Add(this.TopLayout, 0, 0);
            this.MainLayout.Controls.Add(this.ProductoDataLayout, 0, 1);
            this.MainLayout.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.33333F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.88889F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.46881F));
            this.MainLayout.Size = new System.Drawing.Size(867, 450);
            this.MainLayout.TabIndex = 0;
            // 
            // TopLayout
            // 
            this.TopLayout.ColumnCount = 2;
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.8432F));
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.15679F));
            this.TopLayout.Controls.Add(this.SucursalLabel, 0, 0);
            this.TopLayout.Controls.Add(this.SucursalBox, 1, 0);
            this.TopLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopLayout.Location = new System.Drawing.Point(3, 3);
            this.TopLayout.Name = "TopLayout";
            this.TopLayout.RowCount = 1;
            this.TopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.Size = new System.Drawing.Size(861, 63);
            this.TopLayout.TabIndex = 0;
            // 
            // SucursalLabel
            // 
            this.SucursalLabel.AutoSize = true;
            this.SucursalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SucursalLabel.Location = new System.Drawing.Point(3, 0);
            this.SucursalLabel.Name = "SucursalLabel";
            this.SucursalLabel.Size = new System.Drawing.Size(293, 63);
            this.SucursalLabel.TabIndex = 0;
            this.SucursalLabel.Text = "Sucursal";
            this.SucursalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SucursalBox
            // 
            this.SucursalBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SucursalBox.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SucursalBox.FormattingEnabled = true;
            this.SucursalBox.Location = new System.Drawing.Point(302, 3);
            this.SucursalBox.Name = "SucursalBox";
            this.SucursalBox.Size = new System.Drawing.Size(556, 48);
            this.SucursalBox.TabIndex = 1;
            // 
            // ProductoDataLayout
            // 
            this.ProductoDataLayout.ColumnCount = 3;
            this.ProductoDataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.ProductoDataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.52547F));
            this.ProductoDataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.48794F));
            this.ProductoDataLayout.Controls.Add(this.CantidadLabel, 0, 3);
            this.ProductoDataLayout.Controls.Add(this.ProveedorNombreInput, 1, 2);
            this.ProductoDataLayout.Controls.Add(this.label3, 0, 2);
            this.ProductoDataLayout.Controls.Add(this.NombreProductoInput, 1, 1);
            this.ProductoDataLayout.Controls.Add(this.label1, 0, 1);
            this.ProductoDataLayout.Controls.Add(this.IdProductoLabel, 0, 0);
            this.ProductoDataLayout.Controls.Add(this.IdProductoInput, 1, 0);
            this.ProductoDataLayout.Controls.Add(this.ValidarProducto, 2, 0);
            this.ProductoDataLayout.Controls.Add(this.CantidadInput, 1, 3);
            this.ProductoDataLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductoDataLayout.Location = new System.Drawing.Point(3, 72);
            this.ProductoDataLayout.Name = "ProductoDataLayout";
            this.ProductoDataLayout.RowCount = 4;
            this.ProductoDataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.72881F));
            this.ProductoDataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.38983F));
            this.ProductoDataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.52542F));
            this.ProductoDataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.0339F));
            this.ProductoDataLayout.Size = new System.Drawing.Size(861, 295);
            this.ProductoDataLayout.TabIndex = 1;
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CantidadLabel.Location = new System.Drawing.Point(3, 229);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(295, 66);
            this.CantidadLabel.TabIndex = 11;
            this.CantidadLabel.Text = "Cantidad";
            this.CantidadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProveedorNombreInput
            // 
            this.ProveedorNombreInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProveedorNombreInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProveedorNombreInput.Location = new System.Drawing.Point(304, 140);
            this.ProveedorNombreInput.Name = "ProveedorNombreInput";
            this.ProveedorNombreInput.ReadOnly = true;
            this.ProveedorNombreInput.Size = new System.Drawing.Size(411, 50);
            this.ProveedorNombreInput.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 92);
            this.label3.TabIndex = 6;
            this.label3.Text = "Proveedor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NombreProductoInput
            // 
            this.NombreProductoInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombreProductoInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NombreProductoInput.Location = new System.Drawing.Point(304, 72);
            this.NombreProductoInput.Name = "NombreProductoInput";
            this.NombreProductoInput.ReadOnly = true;
            this.NombreProductoInput.Size = new System.Drawing.Size(411, 50);
            this.NombreProductoInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IdProductoLabel
            // 
            this.IdProductoLabel.AutoSize = true;
            this.IdProductoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdProductoLabel.Location = new System.Drawing.Point(3, 0);
            this.IdProductoLabel.Name = "IdProductoLabel";
            this.IdProductoLabel.Size = new System.Drawing.Size(295, 69);
            this.IdProductoLabel.TabIndex = 0;
            this.IdProductoLabel.Text = "ID del producto";
            this.IdProductoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IdProductoInput
            // 
            this.IdProductoInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdProductoInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdProductoInput.Location = new System.Drawing.Point(304, 3);
            this.IdProductoInput.Name = "IdProductoInput";
            this.IdProductoInput.Size = new System.Drawing.Size(411, 50);
            this.IdProductoInput.TabIndex = 1;
            // 
            // ValidarProducto
            // 
            this.ValidarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValidarProducto.Location = new System.Drawing.Point(721, 3);
            this.ValidarProducto.Name = "ValidarProducto";
            this.ValidarProducto.Size = new System.Drawing.Size(137, 63);
            this.ValidarProducto.TabIndex = 2;
            this.ValidarProducto.Text = "Check";
            this.ValidarProducto.UseVisualStyleBackColor = true;
            this.ValidarProducto.Click += new System.EventHandler(this.CheckProductoClick);
            // 
            // CantidadInput
            // 
            this.CantidadInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CantidadInput.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CantidadInput.Location = new System.Drawing.Point(304, 232);
            this.CantidadInput.Name = "CantidadInput";
            this.CantidadInput.Size = new System.Drawing.Size(411, 46);
            this.CantidadInput.TabIndex = 12;
            this.CantidadInput.Text = "0";
            this.CantidadInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CancelarButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AgregarButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 373);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 74);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelarButton.Location = new System.Drawing.Point(3, 3);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(424, 68);
            this.CancelarButton.TabIndex = 1;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CerrarFormClick);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgregarButton.Location = new System.Drawing.Point(433, 3);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(425, 68);
            this.AgregarButton.TabIndex = 0;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.IngresarProductoEnSucursal);
            // 
            // AgregarProductoEnSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.MainLayout);
            this.Name = "AgregarProductoEnSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar productos";
            this.Load += new System.EventHandler(this.CargarSucursal);
            this.MainLayout.ResumeLayout(false);
            this.TopLayout.ResumeLayout(false);
            this.TopLayout.PerformLayout();
            this.ProductoDataLayout.ResumeLayout(false);
            this.ProductoDataLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel TopLayout;
        private System.Windows.Forms.Label SucursalLabel;
        private System.Windows.Forms.ComboBox SucursalBox;
        private System.Windows.Forms.TableLayoutPanel ProductoDataLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox ProveedorNombreInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreProductoInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdProductoLabel;
        private System.Windows.Forms.TextBox IdProductoInput;
        private System.Windows.Forms.Button ValidarProducto;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.TextBox CantidadInput;
    }
}
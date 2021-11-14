namespace FrutosElqui.Escritorio.Formularios
{
    partial class ListaOfertas
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.NuevoEgresoButton = new System.Windows.Forms.Button();
            this.EgresosView = new System.Windows.Forms.DataGridView();
            this.IdIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusquedaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FechaHastaPicker = new System.Windows.Forms.DateTimePicker();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.SucursalLabel = new System.Windows.Forms.Label();
            this.SucursalesBox = new System.Windows.Forms.ComboBox();
            this.FechaDesdePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.MainLayout.SuspendLayout();
            this.DAtaLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EgresosView)).BeginInit();
            this.BusquedaLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.19328F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.80672F));
            this.MainLayout.Controls.Add(this.DAtaLayout, 1, 0);
            this.MainLayout.Controls.Add(this.BusquedaLayout, 0, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Size = new System.Drawing.Size(1214, 623);
            this.MainLayout.TabIndex = 2;
            // 
            // DAtaLayout
            // 
            this.DAtaLayout.ColumnCount = 1;
            this.DAtaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DAtaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DAtaLayout.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.DAtaLayout.Controls.Add(this.EgresosView, 0, 1);
            this.DAtaLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DAtaLayout.Location = new System.Drawing.Point(405, 3);
            this.DAtaLayout.Name = "DAtaLayout";
            this.DAtaLayout.RowCount = 3;
            this.DAtaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.272727F));
            this.DAtaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.13949F));
            this.DAtaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.59136F));
            this.DAtaLayout.Size = new System.Drawing.Size(806, 617);
            this.DAtaLayout.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.73333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33333F));
            this.tableLayoutPanel2.Controls.Add(this.NuevoEgresoButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 547);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 67);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // NuevoEgresoButton
            // 
            this.NuevoEgresoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NuevoEgresoButton.Location = new System.Drawing.Point(186, 3);
            this.NuevoEgresoButton.Name = "NuevoEgresoButton";
            this.NuevoEgresoButton.Size = new System.Drawing.Size(423, 61);
            this.NuevoEgresoButton.TabIndex = 0;
            this.NuevoEgresoButton.Text = "Nuevo egreso";
            this.NuevoEgresoButton.UseVisualStyleBackColor = true;
            // 
            // EgresosView
            // 
            this.EgresosView.AllowUserToAddRows = false;
            this.EgresosView.AllowUserToDeleteRows = false;
            this.EgresosView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EgresosView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIngreso,
            this.FechaIngreso,
            this.Cantidad,
            this.Observacion});
            this.EgresosView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EgresosView.Location = new System.Drawing.Point(3, 47);
            this.EgresosView.Name = "EgresosView";
            this.EgresosView.ReadOnly = true;
            this.EgresosView.RowHeadersVisible = false;
            this.EgresosView.RowHeadersWidth = 82;
            this.EgresosView.RowTemplate.Height = 41;
            this.EgresosView.Size = new System.Drawing.Size(800, 494);
            this.EgresosView.TabIndex = 1;
            // 
            // IdIngreso
            // 
            this.IdIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdIngreso.FillWeight = 128.2051F;
            this.IdIngreso.Frozen = true;
            this.IdIngreso.HeaderText = "ID";
            this.IdIngreso.MinimumWidth = 10;
            this.IdIngreso.Name = "IdIngreso";
            this.IdIngreso.ReadOnly = true;
            this.IdIngreso.Width = 82;
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
            // Observacion
            // 
            this.Observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Observacion.FillWeight = 90.59829F;
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.MinimumWidth = 10;
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            // 
            // BusquedaLayout
            // 
            this.BusquedaLayout.ColumnCount = 2;
            this.BusquedaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.47423F));
            this.BusquedaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.52577F));
            this.BusquedaLayout.Controls.Add(this.FechaHastaPicker, 1, 3);
            this.BusquedaLayout.Controls.Add(this.HastaLabel, 0, 3);
            this.BusquedaLayout.Controls.Add(this.DesdeLabel, 0, 2);
            this.BusquedaLayout.Controls.Add(this.BuscarButton, 1, 5);
            this.BusquedaLayout.Controls.Add(this.SucursalLabel, 0, 1);
            this.BusquedaLayout.Controls.Add(this.SucursalesBox, 1, 1);
            this.BusquedaLayout.Controls.Add(this.FechaDesdePicker, 1, 2);
            this.BusquedaLayout.Controls.Add(this.label1, 0, 4);
            this.BusquedaLayout.Controls.Add(this.TotalBox, 1, 4);
            this.BusquedaLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BusquedaLayout.Location = new System.Drawing.Point(3, 3);
            this.BusquedaLayout.Name = "BusquedaLayout";
            this.BusquedaLayout.RowCount = 7;
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34343F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.91919F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.91919F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.89899F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.080808F));
            this.BusquedaLayout.Size = new System.Drawing.Size(396, 617);
            this.BusquedaLayout.TabIndex = 1;
            // 
            // FechaHastaPicker
            // 
            this.FechaHastaPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FechaHastaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaHastaPicker.Location = new System.Drawing.Point(131, 252);
            this.FechaHastaPicker.Name = "FechaHastaPicker";
            this.FechaHastaPicker.Size = new System.Drawing.Size(262, 39);
            this.FechaHastaPicker.TabIndex = 10;
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HastaLabel.Location = new System.Drawing.Point(3, 249);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(122, 73);
            this.HastaLabel.TabIndex = 7;
            this.HastaLabel.Text = "Hasta";
            this.HastaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesdeLabel.Location = new System.Drawing.Point(3, 176);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(122, 73);
            this.DesdeLabel.TabIndex = 6;
            this.DesdeLabel.Text = "Desde";
            this.DesdeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuscarButton.Location = new System.Drawing.Point(131, 510);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(262, 50);
            this.BuscarButton.TabIndex = 0;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // SucursalLabel
            // 
            this.SucursalLabel.AutoSize = true;
            this.SucursalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SucursalLabel.Location = new System.Drawing.Point(3, 88);
            this.SucursalLabel.Name = "SucursalLabel";
            this.SucursalLabel.Size = new System.Drawing.Size(122, 88);
            this.SucursalLabel.TabIndex = 1;
            this.SucursalLabel.Text = "Sucursal";
            this.SucursalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SucursalesBox
            // 
            this.SucursalesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SucursalesBox.FormattingEnabled = true;
            this.SucursalesBox.Location = new System.Drawing.Point(131, 91);
            this.SucursalesBox.Name = "SucursalesBox";
            this.SucursalesBox.Size = new System.Drawing.Size(262, 40);
            this.SucursalesBox.TabIndex = 2;
            // 
            // FechaDesdePicker
            // 
            this.FechaDesdePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FechaDesdePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDesdePicker.Location = new System.Drawing.Point(131, 179);
            this.FechaDesdePicker.Name = "FechaDesdePicker";
            this.FechaDesdePicker.Size = new System.Drawing.Size(262, 39);
            this.FechaDesdePicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cantidad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalBox
            // 
            this.TotalBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TotalBox.Location = new System.Drawing.Point(131, 325);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(262, 39);
            this.TotalBox.TabIndex = 12;
            this.TotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ListaOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 623);
            this.Controls.Add(this.MainLayout);
            this.Name = "ListaOfertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaOfertas";
            this.MainLayout.ResumeLayout(false);
            this.DAtaLayout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EgresosView)).EndInit();
            this.BusquedaLayout.ResumeLayout(false);
            this.BusquedaLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel DAtaLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button NuevoEgresoButton;
        private System.Windows.Forms.DataGridView EgresosView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.TableLayoutPanel BusquedaLayout;
        private System.Windows.Forms.DateTimePicker FechaHastaPicker;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label SucursalLabel;
        private System.Windows.Forms.ComboBox SucursalesBox;
        private System.Windows.Forms.DateTimePicker FechaDesdePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalBox;
    }
}
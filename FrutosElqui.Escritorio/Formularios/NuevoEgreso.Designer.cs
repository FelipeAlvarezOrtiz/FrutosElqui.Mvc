
namespace FrutosElqui.Escritorio.Formularios
{
    partial class NuevoEgreso
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
            this.buttonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.SucursalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SucursalLabel = new System.Windows.Forms.Label();
            this.SucursalBox = new System.Windows.Forms.TextBox();
            this.DataLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ObservacionLabel = new System.Windows.Forms.Label();
            this.CantidadInput = new System.Windows.Forms.TextBox();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.ObservacionInput = new System.Windows.Forms.TextBox();
            this.mainLayout.SuspendLayout();
            this.buttonsLayout.SuspendLayout();
            this.SucursalLayout.SuspendLayout();
            this.DataLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.buttonsLayout, 0, 2);
            this.mainLayout.Controls.Add(this.SucursalLayout, 0, 0);
            this.mainLayout.Controls.Add(this.DataLayout, 0, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.04016F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.49799F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.26104F));
            this.mainLayout.Size = new System.Drawing.Size(574, 499);
            this.mainLayout.TabIndex = 1;
            // 
            // buttonsLayout
            // 
            this.buttonsLayout.ColumnCount = 5;
            this.buttonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.buttonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.buttonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.buttonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.buttonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.buttonsLayout.Controls.Add(this.CerrarButton, 1, 0);
            this.buttonsLayout.Controls.Add(this.IngresarButton, 3, 0);
            this.buttonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsLayout.Location = new System.Drawing.Point(3, 425);
            this.buttonsLayout.Name = "buttonsLayout";
            this.buttonsLayout.RowCount = 1;
            this.buttonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsLayout.Size = new System.Drawing.Size(568, 71);
            this.buttonsLayout.TabIndex = 0;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CerrarButton.Location = new System.Drawing.Point(59, 3);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(192, 65);
            this.CerrarButton.TabIndex = 0;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            // 
            // IngresarButton
            // 
            this.IngresarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IngresarButton.Location = new System.Drawing.Point(313, 3);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(192, 65);
            this.IngresarButton.TabIndex = 1;
            this.IngresarButton.Text = "Ingresar";
            this.IngresarButton.UseVisualStyleBackColor = true;
            this.IngresarButton.Click += new System.EventHandler(this.InsertarEgresoClick);
            // 
            // SucursalLayout
            // 
            this.SucursalLayout.ColumnCount = 2;
            this.SucursalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.SucursalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.SucursalLayout.Controls.Add(this.SucursalLabel, 0, 0);
            this.SucursalLayout.Controls.Add(this.SucursalBox, 1, 0);
            this.SucursalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SucursalLayout.Location = new System.Drawing.Point(3, 3);
            this.SucursalLayout.Name = "SucursalLayout";
            this.SucursalLayout.RowCount = 1;
            this.SucursalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SucursalLayout.Size = new System.Drawing.Size(568, 44);
            this.SucursalLayout.TabIndex = 1;
            // 
            // SucursalLabel
            // 
            this.SucursalLabel.AutoSize = true;
            this.SucursalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SucursalLabel.Location = new System.Drawing.Point(3, 0);
            this.SucursalLabel.Name = "SucursalLabel";
            this.SucursalLabel.Size = new System.Drawing.Size(221, 44);
            this.SucursalLabel.TabIndex = 0;
            this.SucursalLabel.Text = "Sucursal";
            this.SucursalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SucursalBox
            // 
            this.SucursalBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SucursalBox.Location = new System.Drawing.Point(230, 3);
            this.SucursalBox.Name = "SucursalBox";
            this.SucursalBox.Size = new System.Drawing.Size(335, 39);
            this.SucursalBox.TabIndex = 1;
            // 
            // DataLayout
            // 
            this.DataLayout.ColumnCount = 2;
            this.DataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.DataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.DataLayout.Controls.Add(this.ObservacionLabel, 0, 1);
            this.DataLayout.Controls.Add(this.CantidadInput, 1, 0);
            this.DataLayout.Controls.Add(this.CantidadLabel, 0, 0);
            this.DataLayout.Controls.Add(this.ObservacionInput, 1, 1);
            this.DataLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataLayout.Location = new System.Drawing.Point(3, 53);
            this.DataLayout.Name = "DataLayout";
            this.DataLayout.RowCount = 2;
            this.DataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.15069F));
            this.DataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.84931F));
            this.DataLayout.Size = new System.Drawing.Size(568, 366);
            this.DataLayout.TabIndex = 2;
            // 
            // ObservacionLabel
            // 
            this.ObservacionLabel.AutoSize = true;
            this.ObservacionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObservacionLabel.Location = new System.Drawing.Point(3, 48);
            this.ObservacionLabel.Name = "ObservacionLabel";
            this.ObservacionLabel.Size = new System.Drawing.Size(221, 318);
            this.ObservacionLabel.TabIndex = 3;
            this.ObservacionLabel.Text = "Observación";
            this.ObservacionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CantidadInput
            // 
            this.CantidadInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CantidadInput.Location = new System.Drawing.Point(230, 3);
            this.CantidadInput.Name = "CantidadInput";
            this.CantidadInput.Size = new System.Drawing.Size(335, 39);
            this.CantidadInput.TabIndex = 2;
            this.CantidadInput.Text = "0";
            this.CantidadInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CantidadLabel.Location = new System.Drawing.Point(3, 0);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(221, 48);
            this.CantidadLabel.TabIndex = 0;
            this.CantidadLabel.Text = "Cantidad";
            this.CantidadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ObservacionInput
            // 
            this.ObservacionInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObservacionInput.Location = new System.Drawing.Point(230, 51);
            this.ObservacionInput.Multiline = true;
            this.ObservacionInput.Name = "ObservacionInput";
            this.ObservacionInput.Size = new System.Drawing.Size(335, 312);
            this.ObservacionInput.TabIndex = 4;
            // 
            // NuevoEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 499);
            this.Controls.Add(this.mainLayout);
            this.Name = "NuevoEgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo egreso";
            this.Load += new System.EventHandler(this.CargarFormEgreso);
            this.mainLayout.ResumeLayout(false);
            this.buttonsLayout.ResumeLayout(false);
            this.SucursalLayout.ResumeLayout(false);
            this.SucursalLayout.PerformLayout();
            this.DataLayout.ResumeLayout(false);
            this.DataLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel buttonsLayout;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button IngresarButton;
        private System.Windows.Forms.TableLayoutPanel SucursalLayout;
        private System.Windows.Forms.Label SucursalLabel;
        private System.Windows.Forms.TextBox SucursalBox;
        private System.Windows.Forms.TableLayoutPanel DataLayout;
        private System.Windows.Forms.Label ObservacionLabel;
        private System.Windows.Forms.TextBox CantidadInput;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.TextBox ObservacionInput;
    }
}
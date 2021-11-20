namespace FrutosElqui.Escritorio.Formularios
{
    partial class CrearMedida
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
            this.nuevaMedidaLabel = new System.Windows.Forms.Label();
            this.NuevaMedidaInput = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.MainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 3;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.04598F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.61494F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.195402F));
            this.MainLayout.Controls.Add(this.nuevaMedidaLabel, 0, 1);
            this.MainLayout.Controls.Add(this.NuevaMedidaInput, 1, 1);
            this.MainLayout.Controls.Add(this.AgregarButton, 1, 3);
            this.MainLayout.Controls.Add(this.CerrarButton, 0, 3);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 4;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.42857F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.MainLayout.Size = new System.Drawing.Size(715, 196);
            this.MainLayout.TabIndex = 1;
            // 
            // nuevaMedidaLabel
            // 
            this.nuevaMedidaLabel.AutoSize = true;
            this.nuevaMedidaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nuevaMedidaLabel.Location = new System.Drawing.Point(3, 49);
            this.nuevaMedidaLabel.Name = "nuevaMedidaLabel";
            this.nuevaMedidaLabel.Size = new System.Drawing.Size(230, 49);
            this.nuevaMedidaLabel.TabIndex = 0;
            this.nuevaMedidaLabel.Text = "Nueva medida";
            this.nuevaMedidaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NuevaMedidaInput
            // 
            this.NuevaMedidaInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NuevaMedidaInput.Location = new System.Drawing.Point(239, 52);
            this.NuevaMedidaInput.Name = "NuevaMedidaInput";
            this.NuevaMedidaInput.Size = new System.Drawing.Size(406, 39);
            this.NuevaMedidaInput.TabIndex = 1;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AgregarButton.Location = new System.Drawing.Point(454, 142);
            this.AgregarButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(191, 45);
            this.AgregarButton.TabIndex = 2;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.CrearMedidaClick);
            // 
            // CerrarButton
            // 
            this.CerrarButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CerrarButton.Location = new System.Drawing.Point(83, 142);
            this.CerrarButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(150, 45);
            this.CerrarButton.TabIndex = 3;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButtonClick);
            // 
            // CrearMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 196);
            this.Controls.Add(this.MainLayout);
            this.Name = "CrearMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva medida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingEvent);
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Label nuevaMedidaLabel;
        private System.Windows.Forms.TextBox NuevaMedidaInput;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button CerrarButton;
    }
}
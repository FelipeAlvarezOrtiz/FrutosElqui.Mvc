
namespace FrutosElqui.Escritorio.Formularios
{
    partial class CrearUsuario
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
            this.ButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.DataLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PassInput = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.DireccionInput = new System.Windows.Forms.TextBox();
            this.DireccionLabel = new System.Windows.Forms.Label();
            this.RolesBox = new System.Windows.Forms.ComboBox();
            this.RolesLabel = new System.Windows.Forms.Label();
            this.ComunaBox = new System.Windows.Forms.ComboBox();
            this.ComunaLabel = new System.Windows.Forms.Label();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.TelefonoInput = new System.Windows.Forms.TextBox();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.RutInput = new System.Windows.Forms.TextBox();
            this.RutLabel = new System.Windows.Forms.Label();
            this.NombreInput = new System.Windows.Forms.TextBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.CorreoLabel = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.RegionBox = new System.Windows.Forms.ComboBox();
            this.MainLayout.SuspendLayout();
            this.ButtonsLayout.SuspendLayout();
            this.DataLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.ButtonsLayout, 0, 1);
            this.MainLayout.Controls.Add(this.DataLayout, 0, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 2;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.Size = new System.Drawing.Size(775, 639);
            this.MainLayout.TabIndex = 0;
            // 
            // ButtonsLayout
            // 
            this.ButtonsLayout.ColumnCount = 2;
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayout.Controls.Add(this.GuardarButton, 1, 0);
            this.ButtonsLayout.Controls.Add(this.CancelarButton, 0, 0);
            this.ButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsLayout.Location = new System.Drawing.Point(3, 578);
            this.ButtonsLayout.Name = "ButtonsLayout";
            this.ButtonsLayout.RowCount = 1;
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayout.Size = new System.Drawing.Size(769, 58);
            this.ButtonsLayout.TabIndex = 0;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GuardarButton.Location = new System.Drawing.Point(387, 3);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(379, 52);
            this.GuardarButton.TabIndex = 0;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.AgregarUsuario);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelarButton.Location = new System.Drawing.Point(3, 3);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(378, 52);
            this.CancelarButton.TabIndex = 1;
            this.CancelarButton.Text = "Cerrar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CerrarUsuarioClick);
            // 
            // DataLayout
            // 
            this.DataLayout.ColumnCount = 2;
            this.DataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.DataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.DataLayout.Controls.Add(this.PassInput, 1, 8);
            this.DataLayout.Controls.Add(this.PassLabel, 0, 8);
            this.DataLayout.Controls.Add(this.DireccionInput, 1, 7);
            this.DataLayout.Controls.Add(this.DireccionLabel, 0, 7);
            this.DataLayout.Controls.Add(this.RolesBox, 1, 6);
            this.DataLayout.Controls.Add(this.RolesLabel, 0, 6);
            this.DataLayout.Controls.Add(this.ComunaBox, 1, 5);
            this.DataLayout.Controls.Add(this.ComunaLabel, 0, 5);
            this.DataLayout.Controls.Add(this.RegionLabel, 0, 4);
            this.DataLayout.Controls.Add(this.TelefonoInput, 1, 3);
            this.DataLayout.Controls.Add(this.TelefonoLabel, 0, 3);
            this.DataLayout.Controls.Add(this.RutInput, 1, 2);
            this.DataLayout.Controls.Add(this.RutLabel, 0, 2);
            this.DataLayout.Controls.Add(this.NombreInput, 1, 1);
            this.DataLayout.Controls.Add(this.NombreLabel, 0, 1);
            this.DataLayout.Controls.Add(this.CorreoLabel, 0, 0);
            this.DataLayout.Controls.Add(this.EmailInput, 1, 0);
            this.DataLayout.Controls.Add(this.RegionBox, 1, 4);
            this.DataLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataLayout.Location = new System.Drawing.Point(3, 3);
            this.DataLayout.Name = "DataLayout";
            this.DataLayout.RowCount = 10;
            this.DataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.DataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.DataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.DataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.DataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.DataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.DataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.DataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.DataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.DataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.DataLayout.Size = new System.Drawing.Size(769, 569);
            this.DataLayout.TabIndex = 1;
            // 
            // PassInput
            // 
            this.PassInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PassInput.Location = new System.Drawing.Point(310, 451);
            this.PassInput.Name = "PassInput";
            this.PassInput.Size = new System.Drawing.Size(456, 39);
            this.PassInput.TabIndex = 17;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PassLabel.Location = new System.Drawing.Point(3, 448);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(301, 56);
            this.PassLabel.TabIndex = 16;
            this.PassLabel.Text = "Contraseña";
            this.PassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DireccionInput
            // 
            this.DireccionInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DireccionInput.Location = new System.Drawing.Point(310, 395);
            this.DireccionInput.Name = "DireccionInput";
            this.DireccionInput.Size = new System.Drawing.Size(456, 39);
            this.DireccionInput.TabIndex = 15;
            // 
            // DireccionLabel
            // 
            this.DireccionLabel.AutoSize = true;
            this.DireccionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DireccionLabel.Location = new System.Drawing.Point(3, 392);
            this.DireccionLabel.Name = "DireccionLabel";
            this.DireccionLabel.Size = new System.Drawing.Size(301, 56);
            this.DireccionLabel.TabIndex = 14;
            this.DireccionLabel.Text = "Dirección";
            this.DireccionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RolesBox
            // 
            this.RolesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RolesBox.FormattingEnabled = true;
            this.RolesBox.Location = new System.Drawing.Point(310, 339);
            this.RolesBox.Name = "RolesBox";
            this.RolesBox.Size = new System.Drawing.Size(456, 40);
            this.RolesBox.TabIndex = 13;
            // 
            // RolesLabel
            // 
            this.RolesLabel.AutoSize = true;
            this.RolesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RolesLabel.Location = new System.Drawing.Point(3, 336);
            this.RolesLabel.Name = "RolesLabel";
            this.RolesLabel.Size = new System.Drawing.Size(301, 56);
            this.RolesLabel.TabIndex = 12;
            this.RolesLabel.Text = "Roles";
            this.RolesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComunaBox
            // 
            this.ComunaBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComunaBox.FormattingEnabled = true;
            this.ComunaBox.Location = new System.Drawing.Point(310, 283);
            this.ComunaBox.Name = "ComunaBox";
            this.ComunaBox.Size = new System.Drawing.Size(456, 40);
            this.ComunaBox.TabIndex = 11;
            // 
            // ComunaLabel
            // 
            this.ComunaLabel.AutoSize = true;
            this.ComunaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComunaLabel.Location = new System.Drawing.Point(3, 280);
            this.ComunaLabel.Name = "ComunaLabel";
            this.ComunaLabel.Size = new System.Drawing.Size(301, 56);
            this.ComunaLabel.TabIndex = 10;
            this.ComunaLabel.Text = "Comuna";
            this.ComunaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegionLabel.Location = new System.Drawing.Point(3, 224);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(301, 56);
            this.RegionLabel.TabIndex = 8;
            this.RegionLabel.Text = "Región";
            this.RegionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelefonoInput
            // 
            this.TelefonoInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TelefonoInput.Location = new System.Drawing.Point(310, 171);
            this.TelefonoInput.Name = "TelefonoInput";
            this.TelefonoInput.Size = new System.Drawing.Size(456, 39);
            this.TelefonoInput.TabIndex = 7;
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TelefonoLabel.Location = new System.Drawing.Point(3, 168);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(301, 56);
            this.TelefonoLabel.TabIndex = 6;
            this.TelefonoLabel.Text = "Teléfono";
            this.TelefonoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RutInput
            // 
            this.RutInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RutInput.Location = new System.Drawing.Point(310, 115);
            this.RutInput.Name = "RutInput";
            this.RutInput.Size = new System.Drawing.Size(456, 39);
            this.RutInput.TabIndex = 5;
            // 
            // RutLabel
            // 
            this.RutLabel.AutoSize = true;
            this.RutLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RutLabel.Location = new System.Drawing.Point(3, 112);
            this.RutLabel.Name = "RutLabel";
            this.RutLabel.Size = new System.Drawing.Size(301, 56);
            this.RutLabel.TabIndex = 4;
            this.RutLabel.Text = "R.U.T";
            this.RutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NombreInput
            // 
            this.NombreInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombreInput.Location = new System.Drawing.Point(310, 59);
            this.NombreInput.Name = "NombreInput";
            this.NombreInput.Size = new System.Drawing.Size(456, 39);
            this.NombreInput.TabIndex = 3;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombreLabel.Location = new System.Drawing.Point(3, 56);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(301, 56);
            this.NombreLabel.TabIndex = 2;
            this.NombreLabel.Text = "Nombre";
            this.NombreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CorreoLabel
            // 
            this.CorreoLabel.AutoSize = true;
            this.CorreoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CorreoLabel.Location = new System.Drawing.Point(3, 0);
            this.CorreoLabel.Name = "CorreoLabel";
            this.CorreoLabel.Size = new System.Drawing.Size(301, 56);
            this.CorreoLabel.TabIndex = 0;
            this.CorreoLabel.Text = "Correo";
            this.CorreoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailInput
            // 
            this.EmailInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailInput.Location = new System.Drawing.Point(310, 3);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(456, 39);
            this.EmailInput.TabIndex = 1;
            // 
            // RegionBox
            // 
            this.RegionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegionBox.FormattingEnabled = true;
            this.RegionBox.Location = new System.Drawing.Point(310, 227);
            this.RegionBox.Name = "RegionBox";
            this.RegionBox.Size = new System.Drawing.Size(456, 40);
            this.RegionBox.TabIndex = 9;
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 639);
            this.Controls.Add(this.MainLayout);
            this.Name = "CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear usuario";
            this.Load += new System.EventHandler(this.CargarForm);
            this.MainLayout.ResumeLayout(false);
            this.ButtonsLayout.ResumeLayout(false);
            this.DataLayout.ResumeLayout(false);
            this.DataLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel ButtonsLayout;
        private System.Windows.Forms.TableLayoutPanel DataLayout;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.TextBox RutInput;
        private System.Windows.Forms.Label RutLabel;
        private System.Windows.Forms.TextBox NombreInput;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label CorreoLabel;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.TextBox TelefonoInput;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.ComboBox RegionBox;
        private System.Windows.Forms.TextBox PassInput;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox DireccionInput;
        private System.Windows.Forms.Label DireccionLabel;
        private System.Windows.Forms.ComboBox RolesBox;
        private System.Windows.Forms.Label RolesLabel;
        private System.Windows.Forms.ComboBox ComunaBox;
        private System.Windows.Forms.Label ComunaLabel;
    }
}

namespace FrutosElqui.Escritorio
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SalirButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.DatosLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PassInput = new System.Windows.Forms.TextBox();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.imagenLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainLayout.SuspendLayout();
            this.ButtonsLayout.SuspendLayout();
            this.DatosLayout.SuspendLayout();
            this.imagenLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.ButtonsLayout, 0, 2);
            this.MainLayout.Controls.Add(this.DatosLayout, 0, 1);
            this.MainLayout.Controls.Add(this.imagenLayout, 0, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.9389F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.84054F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.22057F));
            this.MainLayout.Size = new System.Drawing.Size(620, 671);
            this.MainLayout.TabIndex = 0;
            // 
            // ButtonsLayout
            // 
            this.ButtonsLayout.ColumnCount = 5;
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ButtonsLayout.Controls.Add(this.SalirButton, 1, 0);
            this.ButtonsLayout.Controls.Add(this.LoginButton, 3, 0);
            this.ButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsLayout.Location = new System.Drawing.Point(3, 591);
            this.ButtonsLayout.Name = "ButtonsLayout";
            this.ButtonsLayout.RowCount = 1;
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsLayout.Size = new System.Drawing.Size(614, 77);
            this.ButtonsLayout.TabIndex = 0;
            // 
            // SalirButton
            // 
            this.SalirButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalirButton.Location = new System.Drawing.Point(64, 3);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(208, 71);
            this.SalirButton.TabIndex = 0;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirAppClick);
            // 
            // LoginButton
            // 
            this.LoginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginButton.Location = new System.Drawing.Point(339, 3);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(208, 71);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Ingresar";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoggearClick);
            // 
            // DatosLayout
            // 
            this.DatosLayout.ColumnCount = 2;
            this.DatosLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.DatosLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.DatosLayout.Controls.Add(this.PassInput, 1, 1);
            this.DatosLayout.Controls.Add(this.UsuarioLabel, 0, 0);
            this.DatosLayout.Controls.Add(this.PassLabel, 0, 1);
            this.DatosLayout.Controls.Add(this.EmailTextbox, 1, 0);
            this.DatosLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosLayout.Location = new System.Drawing.Point(3, 478);
            this.DatosLayout.Name = "DatosLayout";
            this.DatosLayout.RowCount = 2;
            this.DatosLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DatosLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DatosLayout.Size = new System.Drawing.Size(614, 107);
            this.DatosLayout.TabIndex = 1;
            // 
            // PassInput
            // 
            this.PassInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PassInput.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassInput.Location = new System.Drawing.Point(248, 56);
            this.PassInput.Name = "PassInput";
            this.PassInput.PasswordChar = '*';
            this.PassInput.Size = new System.Drawing.Size(363, 46);
            this.PassInput.TabIndex = 3;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsuarioLabel.Location = new System.Drawing.Point(3, 0);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(239, 53);
            this.UsuarioLabel.TabIndex = 0;
            this.UsuarioLabel.Text = "Correo";
            this.UsuarioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PassLabel.Location = new System.Drawing.Point(3, 53);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(239, 54);
            this.PassLabel.TabIndex = 1;
            this.PassLabel.Text = "Contraseña";
            this.PassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailTextbox.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailTextbox.Location = new System.Drawing.Point(248, 3);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(363, 46);
            this.EmailTextbox.TabIndex = 2;
            // 
            // imagenLayout
            // 
            this.imagenLayout.ColumnCount = 3;
            this.imagenLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.imagenLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.imagenLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.imagenLayout.Controls.Add(this.pictureBox1, 1, 1);
            this.imagenLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagenLayout.Location = new System.Drawing.Point(3, 3);
            this.imagenLayout.Name = "imagenLayout";
            this.imagenLayout.RowCount = 3;
            this.imagenLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.imagenLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.imagenLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.imagenLayout.Size = new System.Drawing.Size(614, 469);
            this.imagenLayout.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 416);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 671);
            this.Controls.Add(this.MainLayout);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MainLayout.ResumeLayout(false);
            this.ButtonsLayout.ResumeLayout(false);
            this.DatosLayout.ResumeLayout(false);
            this.DatosLayout.PerformLayout();
            this.imagenLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel ButtonsLayout;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TableLayoutPanel DatosLayout;
        private System.Windows.Forms.TextBox PassInput;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.TableLayoutPanel imagenLayout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
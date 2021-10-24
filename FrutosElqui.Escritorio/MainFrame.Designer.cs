
namespace FrutosElqui.Escritorio
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.opcionesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.productosOfertasGroupBox = new System.Windows.Forms.GroupBox();
            this.ventasDineroGroupBox = new System.Windows.Forms.GroupBox();
            this.informesGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UserLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UserNameText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SalirButton = new System.Windows.Forms.Button();
            this.NuevoUsuarioButton = new System.Windows.Forms.Button();
            this.CotizacionesGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductosContentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.mainLayout.SuspendLayout();
            this.opcionesLayout.SuspendLayout();
            this.productosOfertasGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.UserLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ProductosContentLayout.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.mainLayout.Controls.Add(this.opcionesLayout, 1, 0);
            this.mainLayout.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(1474, 729);
            this.mainLayout.TabIndex = 0;
            // 
            // opcionesLayout
            // 
            this.opcionesLayout.AutoScroll = true;
            this.opcionesLayout.ColumnCount = 1;
            this.opcionesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.opcionesLayout.Controls.Add(this.productosOfertasGroupBox, 0, 0);
            this.opcionesLayout.Controls.Add(this.ventasDineroGroupBox, 0, 1);
            this.opcionesLayout.Controls.Add(this.informesGroupBox, 0, 2);
            this.opcionesLayout.Controls.Add(this.groupBox4, 0, 3);
            this.opcionesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opcionesLayout.Location = new System.Drawing.Point(371, 3);
            this.opcionesLayout.Name = "opcionesLayout";
            this.opcionesLayout.RowCount = 4;
            this.opcionesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.opcionesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.opcionesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.opcionesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.opcionesLayout.Size = new System.Drawing.Size(1100, 723);
            this.opcionesLayout.TabIndex = 0;
            // 
            // productosOfertasGroupBox
            // 
            this.productosOfertasGroupBox.Controls.Add(this.ProductosContentLayout);
            this.productosOfertasGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productosOfertasGroupBox.Location = new System.Drawing.Point(3, 3);
            this.productosOfertasGroupBox.Name = "productosOfertasGroupBox";
            this.productosOfertasGroupBox.Size = new System.Drawing.Size(1094, 174);
            this.productosOfertasGroupBox.TabIndex = 0;
            this.productosOfertasGroupBox.TabStop = false;
            this.productosOfertasGroupBox.Text = "Productos y ofertas";
            // 
            // ventasDineroGroupBox
            // 
            this.ventasDineroGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventasDineroGroupBox.Location = new System.Drawing.Point(3, 183);
            this.ventasDineroGroupBox.Name = "ventasDineroGroupBox";
            this.ventasDineroGroupBox.Size = new System.Drawing.Size(1094, 174);
            this.ventasDineroGroupBox.TabIndex = 1;
            this.ventasDineroGroupBox.TabStop = false;
            this.ventasDineroGroupBox.Text = "Ventas y dinero";
            // 
            // informesGroupBox
            // 
            this.informesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informesGroupBox.Location = new System.Drawing.Point(3, 363);
            this.informesGroupBox.Name = "informesGroupBox";
            this.informesGroupBox.Size = new System.Drawing.Size(1094, 174);
            this.informesGroupBox.TabIndex = 2;
            this.informesGroupBox.TabStop = false;
            this.informesGroupBox.Text = "Informes y reportes";
            // 
            // groupBox4
            // 
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 543);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1094, 177);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Administración y cuentas";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.UserLayout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CotizacionesGroupBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.70401F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.28354F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.87414F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 723);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // UserLayout
            // 
            this.UserLayout.ColumnCount = 2;
            this.UserLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.UserLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.UserLayout.Controls.Add(this.UserNameText, 1, 1);
            this.UserLayout.Controls.Add(this.label1, 0, 1);
            this.UserLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserLayout.Location = new System.Drawing.Point(3, 3);
            this.UserLayout.Name = "UserLayout";
            this.UserLayout.RowCount = 3;
            this.UserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.UserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.UserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.UserLayout.Size = new System.Drawing.Size(356, 122);
            this.UserLayout.TabIndex = 2;
            // 
            // UserNameText
            // 
            this.UserNameText.AutoSize = true;
            this.UserNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserNameText.Location = new System.Drawing.Point(145, 40);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(208, 40);
            this.UserNameText.TabIndex = 3;
            this.UserNameText.Text = "usuariologeado";
            this.UserNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.SalirButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.NuevoUsuarioButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 603);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(356, 117);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // SalirButton
            // 
            this.SalirButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SalirButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalirButton.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalirButton.Location = new System.Drawing.Point(12, 70);
            this.SalirButton.Margin = new System.Windows.Forms.Padding(12, 12, 12, 6);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(332, 41);
            this.SalirButton.TabIndex = 1;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = false;
            // 
            // NuevoUsuarioButton
            // 
            this.NuevoUsuarioButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NuevoUsuarioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NuevoUsuarioButton.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NuevoUsuarioButton.Location = new System.Drawing.Point(12, 12);
            this.NuevoUsuarioButton.Margin = new System.Windows.Forms.Padding(12, 12, 12, 6);
            this.NuevoUsuarioButton.Name = "NuevoUsuarioButton";
            this.NuevoUsuarioButton.Size = new System.Drawing.Size(332, 40);
            this.NuevoUsuarioButton.TabIndex = 0;
            this.NuevoUsuarioButton.Text = "Nuevo usuario";
            this.NuevoUsuarioButton.UseVisualStyleBackColor = false;
            // 
            // CotizacionesGroupBox
            // 
            this.CotizacionesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CotizacionesGroupBox.Location = new System.Drawing.Point(3, 131);
            this.CotizacionesGroupBox.Name = "CotizacionesGroupBox";
            this.CotizacionesGroupBox.Size = new System.Drawing.Size(356, 466);
            this.CotizacionesGroupBox.TabIndex = 3;
            this.CotizacionesGroupBox.TabStop = false;
            this.CotizacionesGroupBox.Text = "Cotizaciones";
            // 
            // ProductosContentLayout
            // 
            this.ProductosContentLayout.AutoScroll = true;
            this.ProductosContentLayout.ColumnCount = 4;
            this.ProductosContentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ProductosContentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ProductosContentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ProductosContentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ProductosContentLayout.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.ProductosContentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductosContentLayout.Location = new System.Drawing.Point(3, 35);
            this.ProductosContentLayout.Name = "ProductosContentLayout";
            this.ProductosContentLayout.RowCount = 1;
            this.ProductosContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProductosContentLayout.Size = new System.Drawing.Size(1088, 136);
            this.ProductosContentLayout.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(266, 130);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inventario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainFrame
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1474, 729);
            this.Controls.Add(this.mainLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frutos de elqui";
            this.mainLayout.ResumeLayout(false);
            this.opcionesLayout.ResumeLayout(false);
            this.productosOfertasGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.UserLayout.ResumeLayout(false);
            this.UserLayout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ProductosContentLayout.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel opcionesLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox productosOfertasGroupBox;
        private System.Windows.Forms.GroupBox ventasDineroGroupBox;
        private System.Windows.Forms.GroupBox informesGroupBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button NuevoUsuarioButton;
        private System.Windows.Forms.TableLayoutPanel UserLayout;
        private System.Windows.Forms.Label UserNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CotizacionesGroupBox;
        private System.Windows.Forms.TableLayoutPanel ProductosContentLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}
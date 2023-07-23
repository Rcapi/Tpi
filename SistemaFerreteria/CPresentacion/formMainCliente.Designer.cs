namespace SistemaFerreteria.CPresentacion
{
    partial class formMainCliente
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.menuProductos = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementoDeSujeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasElectricasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasDeManoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialDeConstruccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(90, 62);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(75, 16);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.Click += new System.EventHandler(this.lblBienvenido_Click);
            // 
            // menuProductos
            // 
            this.menuProductos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.cuentaToolStripMenuItem,
            this.carritoToolStripMenuItem});
            this.menuProductos.Location = new System.Drawing.Point(0, 0);
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.Size = new System.Drawing.Size(776, 28);
            this.menuProductos.TabIndex = 2;
            this.menuProductos.Text = "Productos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elementoDeSujeccionToolStripMenuItem,
            this.equipoDeSeguridadToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.materialDeConstruccionToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // elementoDeSujeccionToolStripMenuItem
            // 
            this.elementoDeSujeccionToolStripMenuItem.Name = "elementoDeSujeccionToolStripMenuItem";
            this.elementoDeSujeccionToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.elementoDeSujeccionToolStripMenuItem.Text = "Elemento de sujeccion";
            // 
            // equipoDeSeguridadToolStripMenuItem
            // 
            this.equipoDeSeguridadToolStripMenuItem.Name = "equipoDeSeguridadToolStripMenuItem";
            this.equipoDeSeguridadToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.equipoDeSeguridadToolStripMenuItem.Text = "Equipo de seguridad";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herramientasElectricasToolStripMenuItem,
            this.herramientasDeManoToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // herramientasElectricasToolStripMenuItem
            // 
            this.herramientasElectricasToolStripMenuItem.Name = "herramientasElectricasToolStripMenuItem";
            this.herramientasElectricasToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.herramientasElectricasToolStripMenuItem.Text = "Herramientas electricas";
            // 
            // herramientasDeManoToolStripMenuItem
            // 
            this.herramientasDeManoToolStripMenuItem.Name = "herramientasDeManoToolStripMenuItem";
            this.herramientasDeManoToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.herramientasDeManoToolStripMenuItem.Text = "Herramientas de mano";
            // 
            // materialDeConstruccionToolStripMenuItem
            // 
            this.materialDeConstruccionToolStripMenuItem.Name = "materialDeConstruccionToolStripMenuItem";
            this.materialDeConstruccionToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.materialDeConstruccionToolStripMenuItem.Text = "Material de construccion";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem,
            this.saldoToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.datosToolStripMenuItem.Text = "Datos";
            // 
            // saldoToolStripMenuItem
            // 
            this.saldoToolStripMenuItem.Name = "saldoToolStripMenuItem";
            this.saldoToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.saldoToolStripMenuItem.Text = "Saldo";
            // 
            // carritoToolStripMenuItem
            // 
            this.carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            this.carritoToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.carritoToolStripMenuItem.Text = "Carrito";
            // 
            // formMainCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 346);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.menuProductos);
            this.MainMenuStrip = this.menuProductos;
            this.Name = "formMainCliente";
            this.Text = "formMain";
            this.Load += new System.EventHandler(this.formMainCliente_Load);
            this.menuProductos.ResumeLayout(false);
            this.menuProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.MenuStrip menuProductos;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementoDeSujeccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipoDeSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasElectricasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasDeManoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialDeConstruccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carritoToolStripMenuItem;
    }
}
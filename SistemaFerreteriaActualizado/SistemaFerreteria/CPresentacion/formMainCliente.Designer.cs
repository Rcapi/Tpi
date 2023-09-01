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
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementoDeSujeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasElectricasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasDeManoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialDeConstruccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanelProductoCliente = new System.Windows.Forms.FlowLayoutPanel();
            this.panelProducto = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.menuProductos.SuspendLayout();
            this.flowLayoutPanelProductoCliente.SuspendLayout();
            this.panelProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(90, 62);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(109, 25);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.Click += new System.EventHandler(this.lblBienvenido_Click);
            // 
            // menuProductos
            // 
            this.menuProductos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.carritoToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.menuProductos.Location = new System.Drawing.Point(0, 0);
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.Size = new System.Drawing.Size(1127, 28);
            this.menuProductos.TabIndex = 2;
            this.menuProductos.Text = "Productos";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem,
            this.saldoToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.datosToolStripMenuItem.Text = "Datos";
            // 
            // saldoToolStripMenuItem
            // 
            this.saldoToolStripMenuItem.Name = "saldoToolStripMenuItem";
            this.saldoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.saldoToolStripMenuItem.Text = "Saldo";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // carritoToolStripMenuItem
            // 
            this.carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            this.carritoToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.carritoToolStripMenuItem.Text = "Carrito";
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
            // flowLayoutPanelProductoCliente
            // 
            this.flowLayoutPanelProductoCliente.Controls.Add(this.panelProducto);
            this.flowLayoutPanelProductoCliente.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelProductoCliente.Location = new System.Drawing.Point(13, 110);
            this.flowLayoutPanelProductoCliente.Name = "flowLayoutPanelProductoCliente";
            this.flowLayoutPanelProductoCliente.Size = new System.Drawing.Size(1102, 419);
            this.flowLayoutPanelProductoCliente.TabIndex = 3;
            // 
            // panelProducto
            // 
            this.panelProducto.Controls.Add(this.lblDescripcion);
            this.panelProducto.Controls.Add(this.lblPrecio);
            this.panelProducto.Controls.Add(this.lblNombre);
            this.panelProducto.Controls.Add(this.lblCodigo);
            this.panelProducto.Controls.Add(this.btnCarrito);
            this.panelProducto.Controls.Add(this.pictureBox1);
            this.panelProducto.Location = new System.Drawing.Point(3, 3);
            this.panelProducto.Name = "panelProducto";
            this.panelProducto.Size = new System.Drawing.Size(319, 416);
            this.panelProducto.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 119);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCarrito
            // 
            this.btnCarrito.Location = new System.Drawing.Point(191, 348);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(101, 44);
            this.btnCarrito.TabIndex = 1;
            this.btnCarrito.Text = "Agregar al carrito";
            this.btnCarrito.UseVisualStyleBackColor = true;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 26);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(13, 102);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 145);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // formMainCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 541);
            this.Controls.Add(this.flowLayoutPanelProductoCliente);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.menuProductos);
            this.MainMenuStrip = this.menuProductos;
            this.Name = "formMainCliente";
            this.Text = "formMain";
            this.Load += new System.EventHandler(this.formMainCliente_Load);
            this.menuProductos.ResumeLayout(false);
            this.menuProductos.PerformLayout();
            this.flowLayoutPanelProductoCliente.ResumeLayout(false);
            this.panelProducto.ResumeLayout(false);
            this.panelProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProductoCliente;
        private System.Windows.Forms.Panel panelProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnCarrito;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
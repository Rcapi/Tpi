namespace Presentacion
{
    partial class formMainEmpleado
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
            this.menuStripEmpleado = new System.Windows.Forms.MenuStrip();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEliminarModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEliminarModificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(24, 70);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(109, 25);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStripEmpleado
            // 
            this.menuStripEmpleado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripEmpleado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStripEmpleado.Location = new System.Drawing.Point(0, 0);
            this.menuStripEmpleado.Name = "menuStripEmpleado";
            this.menuStripEmpleado.Size = new System.Drawing.Size(948, 28);
            this.menuStripEmpleado.TabIndex = 1;
            this.menuStripEmpleado.Text = "menuEmpleado";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarDatosToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // modificarDatosToolStripMenuItem
            // 
            this.modificarDatosToolStripMenuItem.Name = "modificarDatosToolStripMenuItem";
            this.modificarDatosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modificarDatosToolStripMenuItem.Text = "Datos";
            this.modificarDatosToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEliminarModificarToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // agregarEliminarModificarToolStripMenuItem
            // 
            this.agregarEliminarModificarToolStripMenuItem.Name = "agregarEliminarModificarToolStripMenuItem";
            this.agregarEliminarModificarToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.agregarEliminarModificarToolStripMenuItem.Text = "Agregar/ Eliminar/ Modificar";
            this.agregarEliminarModificarToolStripMenuItem.Click += new System.EventHandler(this.agregarEliminarModificarToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEliminarModificarToolStripMenuItem1});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarEliminarModificarToolStripMenuItem1
            // 
            this.agregarEliminarModificarToolStripMenuItem1.Name = "agregarEliminarModificarToolStripMenuItem1";
            this.agregarEliminarModificarToolStripMenuItem1.Size = new System.Drawing.Size(288, 26);
            this.agregarEliminarModificarToolStripMenuItem1.Text = "Agregar/ Eliminar / Modificar";
            this.agregarEliminarModificarToolStripMenuItem1.Click += new System.EventHandler(this.agregarEliminarModificarToolStripMenuItem1_Click);
            // 
            // formMainEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 499);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.menuStripEmpleado);
            this.MainMenuStrip = this.menuStripEmpleado;
            this.Name = "formMainEmpleado";
            this.Text = "formMainEmpleado";
            this.Load += new System.EventHandler(this.formMainEmpleado_Load);
            this.menuStripEmpleado.ResumeLayout(false);
            this.menuStripEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.MenuStrip menuStripEmpleado;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEliminarModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEliminarModificarToolStripMenuItem1;
    }
}
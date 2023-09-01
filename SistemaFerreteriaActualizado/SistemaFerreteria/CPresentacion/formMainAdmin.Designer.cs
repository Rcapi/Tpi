namespace SistemaFerreteria.CPresentacion
{
    partial class formMainAdmin
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.linkLblCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(95, 85);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(109, 25);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(44, 168);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(207, 89);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Location = new System.Drawing.Point(298, 168);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(207, 89);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(558, 168);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(207, 89);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // linkLblCerrarSesion
            // 
            this.linkLblCerrarSesion.AutoSize = true;
            this.linkLblCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblCerrarSesion.Location = new System.Drawing.Point(13, 299);
            this.linkLblCerrarSesion.Name = "linkLblCerrarSesion";
            this.linkLblCerrarSesion.Size = new System.Drawing.Size(111, 20);
            this.linkLblCerrarSesion.TabIndex = 4;
            this.linkLblCerrarSesion.TabStop = true;
            this.linkLblCerrarSesion.Text = "Cerrar sesion";
            this.linkLblCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblCerrarSesion_LinkClicked);
            // 
            // formMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 327);
            this.Controls.Add(this.linkLblCerrarSesion);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "formMainAdmin";
            this.Text = "formMainAdmin";
            this.Load += new System.EventHandler(this.formMainAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.LinkLabel linkLblCerrarSesion;
    }
}
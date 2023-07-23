namespace SistemaFerreteria.CPresentacion
{
    partial class SeleccionarTipoUsuario
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(13, 98);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(267, 180);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(298, 98);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(267, 180);
            this.btnEmpleado.TabIndex = 1;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(110, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(357, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Elige como desea registrarse";
            // 
            // SeleccionarTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 311);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnCliente);
            this.Name = "SeleccionarTipoUsuario";
            this.Text = "SeleccionarTipoUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Label lblTitulo;
    }
}
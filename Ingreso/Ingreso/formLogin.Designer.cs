namespace Ingreso
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            lblUsuario = new Label();
            lblPass = new Label();
            lnkOlvidaPass = new LinkLabel();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            lnkRegistro = new LinkLabel();
            lblRegistro = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Location = new Point(474, 226);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Ingresar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(361, 226);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(196, 27);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 2;
            label1.Text = "Ingreso al sistema";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(118, 93);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(49, 15);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(118, 137);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(69, 15);
            lblPass.TabIndex = 4;
            lblPass.Text = "Contraseña";
            // 
            // lnkOlvidaPass
            // 
            lnkOlvidaPass.AutoSize = true;
            lnkOlvidaPass.Cursor = Cursors.Hand;
            lnkOlvidaPass.Location = new Point(196, 175);
            lnkOlvidaPass.Name = "lnkOlvidaPass";
            lnkOlvidaPass.Size = new Size(131, 15);
            lnkOlvidaPass.TabIndex = 5;
            lnkOlvidaPass.TabStop = true;
            lnkOlvidaPass.Text = "Olvidaste tu contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Location = new Point(196, 90);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(240, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Cursor = Cursors.IBeam;
            txtPass.Location = new Point(196, 134);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(240, 23);
            txtPass.TabIndex = 7;
            // 
            // lnkRegistro
            // 
            lnkRegistro.AutoSize = true;
            lnkRegistro.Cursor = Cursors.Hand;
            lnkRegistro.Location = new Point(10, 226);
            lnkRegistro.Name = "lnkRegistro";
            lnkRegistro.Size = new Size(59, 15);
            lnkRegistro.TabIndex = 8;
            lnkRegistro.TabStop = true;
            lnkRegistro.Text = "Registrate";
            lnkRegistro.LinkClicked += lnkRegistro_LinkClicked;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(10, 209);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(124, 15);
            lblRegistro.TabIndex = 9;
            lblRegistro.Text = "¿Aun no tiene cuenta?";
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 263);
            Controls.Add(lblRegistro);
            Controls.Add(lnkRegistro);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(lnkOlvidaPass);
            Controls.Add(lblPass);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "formLogin";
            Text = "Sistema de ferreteria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private Label lblUsuario;
        private Label lblPass;
        private LinkLabel lnkOlvidaPass;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private LinkLabel lnkRegistro;
        private Label lblRegistro;
    }
}
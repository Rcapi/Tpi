namespace Ingreso
{
    partial class formRegistro
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
            lblUsuario = new Label();
            lblPass = new Label();
            lblConfPass = new Label();
            label4 = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            txtRepitePass = new TextBox();
            lblIngreso = new Label();
            lnkIngresar = new LinkLabel();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(86, 107);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(49, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(86, 157);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(69, 15);
            lblPass.TabIndex = 1;
            lblPass.Text = "Contraseña";
            // 
            // lblConfPass
            // 
            lblConfPass.AutoSize = true;
            lblConfPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfPass.Location = new Point(86, 204);
            lblConfPass.Name = "lblConfPass";
            lblConfPass.Size = new Size(122, 15);
            lblConfPass.TabIndex = 2;
            lblConfPass.Text = "Confirma contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(214, 35);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 3;
            label4.Text = "Registro";
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Location = new Point(214, 104);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(261, 23);
            txtUsuario.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Cursor = Cursors.IBeam;
            txtPass.Location = new Point(214, 154);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(261, 23);
            txtPass.TabIndex = 5;
            txtPass.TextChanged += textBox2_TextChanged;
            // 
            // txtRepitePass
            // 
            txtRepitePass.Cursor = Cursors.IBeam;
            txtRepitePass.Location = new Point(214, 201);
            txtRepitePass.Name = "txtRepitePass";
            txtRepitePass.PasswordChar = '*';
            txtRepitePass.Size = new Size(261, 23);
            txtRepitePass.TabIndex = 6;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(20, 334);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(97, 15);
            lblIngreso.TabIndex = 7;
            lblIngreso.Text = "¿Ya tiene cuenta?";
            lblIngreso.Click += lblIngreso_Click;
            // 
            // lnkIngresar
            // 
            lnkIngresar.AutoSize = true;
            lnkIngresar.Cursor = Cursors.Hand;
            lnkIngresar.Location = new Point(20, 351);
            lnkIngresar.Name = "lnkIngresar";
            lnkIngresar.Size = new Size(49, 15);
            lnkIngresar.TabIndex = 8;
            lnkIngresar.TabStop = true;
            lnkIngresar.Text = "Ingresar";
            lnkIngresar.LinkClicked += lnkIngresar_LinkClicked;
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Location = new Point(488, 343);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(361, 343);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // formRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 388);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lnkIngresar);
            Controls.Add(lblIngreso);
            Controls.Add(txtRepitePass);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(lblConfPass);
            Controls.Add(lblPass);
            Controls.Add(lblUsuario);
            Name = "formRegistro";
            Text = "formRegistro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblPass;
        private Label lblConfPass;
        private Label label4;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private TextBox txtRepitePass;
        private Label lblIngreso;
        private LinkLabel lnkIngresar;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}
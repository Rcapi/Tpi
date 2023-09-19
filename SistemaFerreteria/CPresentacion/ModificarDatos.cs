using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDatos;


namespace Presentacion
{
    public partial class ModificarDatos : Form
    {
        public ModificarDatos(string dni)
        {
            InitializeComponent();
            txtDni.Text = dni;
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                var usuarioEncontrado = (from usuario in db.Usuarios where usuario.Dni == txtDni.Text select usuario).FirstOrDefault();

                txtNombre.Text = usuarioEncontrado.Nombre;
                txtApellido.Text = usuarioEncontrado.Apellido;
                txtMail.Text = usuarioEncontrado.Email;
                txtTelefono.Text = usuarioEncontrado.Telefono;
                txtDireccion.Text = usuarioEncontrado.Direccion;
                txtCiudad.Text = usuarioEncontrado.Ciudad;
                txtClave.Text = usuarioEncontrado.Clave;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {

                var usuarioEncontrado = (from usuario in db.Usuarios where usuario.Dni == txtDni.Text select usuario).FirstOrDefault();

                if (usuarioEncontrado != null)
                {
                    usuarioEncontrado.Nombre = txtNombre.Text;
                    usuarioEncontrado.Apellido = txtApellido.Text;
                    usuarioEncontrado.Email = txtMail.Text;
                    usuarioEncontrado.Telefono = txtTelefono.Text;
                    usuarioEncontrado.Direccion = txtDireccion.Text;
                    usuarioEncontrado.Ciudad = txtCiudad.Text;
                    usuarioEncontrado.Clave = txtClave.Text;


                    if (!string.IsNullOrEmpty(txtDni.Text) &&
                        !string.IsNullOrEmpty(txtNombre.Text) &&
                        !string.IsNullOrEmpty(txtApellido.Text) &&
                        !string.IsNullOrEmpty(txtTelefono.Text) &&
                        !string.IsNullOrEmpty(txtDireccion.Text) &&
                        !string.IsNullOrEmpty(txtCiudad.Text) &&
                        !string.IsNullOrEmpty(txtClave.Text) &&
                        !string.IsNullOrEmpty(txtConfirmaClave.Text) &&
                        txtClave.Text == txtConfirmaClave.Text)

                    {
                        db.SaveChanges();
                        MessageBox.Show("Registro guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }


                    else if (txtClave.Text != txtConfirmaClave.Text)
                    {

                        MessageBox.Show("La clave ingresada y la confirmacion no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    else if (string.IsNullOrEmpty(txtDni.Text))
                    {

                        MessageBox.Show("El campo Dni no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (string.IsNullOrEmpty(txtNombre.Text))
                    {

                        MessageBox.Show("El campo nombre no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(txtApellido.Text))
                    {

                        MessageBox.Show("El campo apellido no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(txtTelefono.Text))
                    {

                        MessageBox.Show("El campo teléfono no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(txtDireccion.Text))
                    {

                        MessageBox.Show("El campo dirección no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(txtCiudad.Text))
                    {

                        MessageBox.Show("El campo ciudad no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(txtClave.Text))
                    {

                        MessageBox.Show("El campo clave no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else

                        MessageBox.Show("El campo confirmación de clave no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
    
    


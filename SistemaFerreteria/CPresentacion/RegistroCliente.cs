using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionarTipoUsuario seleccionarTipoUsuario = new SeleccionarTipoUsuario();
            seleccionarTipoUsuario.Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FerreteriaEntities db = new FerreteriaEntities())
                {
                    CDatos.Usuario nuevoUsuario = new CDatos.Usuario
                    {
                        Dni = txtDni.Text,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Email = txtMail.Text,
                        Telefono = txtTelefono.Text,
                        Direccion = txtDireccion.Text,
                        Ciudad = txtCiudad.Text,
                        Clave = txtClave.Text,
                    };

                    CDatos.Cliente nuevoCliente = new CDatos.Cliente
                    {
                        Dni = txtDni.Text,
                    };

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

                        if (!db.Usuarios.Any(usuario => usuario.Dni == nuevoUsuario.Dni))
                        {
                            db.Usuarios.Add(nuevoUsuario);
                            db.Clientes.Add(nuevoCliente);
                            db.SaveChanges();
                            MessageBox.Show("Registro guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else if (db.Usuarios.Any(usuario => usuario.Dni == nuevoUsuario.Dni))
                        {

                            MessageBox.Show("Ese dni ya esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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



            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

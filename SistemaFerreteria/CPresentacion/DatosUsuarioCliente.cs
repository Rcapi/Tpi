using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDatos;


namespace Presentacion
{
    public partial class DatosUsuarioCliente : Form
    {
        public DatosUsuarioCliente(string Dni)
        {
            InitializeComponent();
            txtDni.Text = Dni;
        }

        private void DatosUsuario_Load(object sender, EventArgs e)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                var usuarioEncontrado = (from usuario in db.Usuarios where usuario.Dni == txtDni.Text select usuario).FirstOrDefault();
                var clienteEncontrado = (from cliente in db.Clientes where cliente.Dni == usuarioEncontrado.Dni select cliente).FirstOrDefault();

                txtNombre.Text = usuarioEncontrado.Nombre;
                txtApellido.Text = usuarioEncontrado.Apellido;
                txtMail.Text = usuarioEncontrado.Email;
                txtTelefono.Text = usuarioEncontrado.Telefono;
                txtDireccion.Text = usuarioEncontrado.Direccion;
                txtCiudad.Text = usuarioEncontrado.Ciudad;
                txtClave.Text = usuarioEncontrado.Clave;
                txtNroCli.Text = clienteEncontrado.NroCli.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarDatos modificarDatos = new ModificarDatos(txtDni.Text);
            modificarDatos.ShowDialog();
        }
    }
}

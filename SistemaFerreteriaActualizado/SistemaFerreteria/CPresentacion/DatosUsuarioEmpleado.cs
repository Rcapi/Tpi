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

namespace SistemaFerreteria.CPresentacion
{
    public partial class DatosUsuarioEmpleado : Form
    {
        public DatosUsuarioEmpleado(string Dni)
        {
            InitializeComponent();
            txtDni.Text = Dni;
        }

        private void DatosUsuarioEmpleado_Load(object sender, EventArgs e)
        {
            using (CDatos.FerreteriaEntities db = new CDatos.FerreteriaEntities())
            {
                var usuarioEncontrado = (from usuario in db.Usuarios where usuario.Dni == txtDni.Text select usuario).FirstOrDefault();
                var empleadoEncontrado = (from empleado in db.Empleadoes where empleado.Dni == usuarioEncontrado.Dni select empleado).FirstOrDefault();

                txtNombre.Text = usuarioEncontrado.Nombre;
                txtApellido.Text = usuarioEncontrado.Apellido;
                txtMail.Text = usuarioEncontrado.Email;
                txtTelefono.Text = usuarioEncontrado.Telefono;
                txtDireccion.Text = usuarioEncontrado.Direccion;
                txtCiudad.Text = usuarioEncontrado.Ciudad;
                txtClave.Text = usuarioEncontrado.Clave;
                txtLegajo.Text = empleadoEncontrado.Legajo.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarDatos modificarDatos = new ModificarDatos(txtDni.Text);
            modificarDatos.ShowDialog();
        }
    }
}

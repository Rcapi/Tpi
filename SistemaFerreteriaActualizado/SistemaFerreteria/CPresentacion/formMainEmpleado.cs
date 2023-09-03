using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFerreteria.CPresentacion
{
    public partial class formMainEmpleado : Form
    {
        public string NombreEmpleado { get; set; }
        public string DNI { get; set; }
        public formMainEmpleado(string nombre, string dni)
        {
            InitializeComponent();
            NombreEmpleado = nombre;
            DNI = dni;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formMainEmpleado_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido, " + NombreEmpleado;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formIngreso formIngreso = new formIngreso();
            formIngreso.Show();
            this.Close();
        }

        private void agregarEliminarModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SeleccionaCategoria abmproducto = new SeleccionaCategoria();
                abmproducto.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarEliminarModificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ABMClientes abmClientes = new ABMClientes();
            abmClientes.ShowDialog();
        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosUsuarioEmpleado datosUsuarioEmpleado = new DatosUsuarioEmpleado(DNI);
            datosUsuarioEmpleado.ShowDialog();
        }
    }
}

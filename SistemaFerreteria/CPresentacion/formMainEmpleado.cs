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
        public formMainEmpleado(string nombre)
        {
            InitializeComponent();
            NombreEmpleado = nombre;
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
    }
}

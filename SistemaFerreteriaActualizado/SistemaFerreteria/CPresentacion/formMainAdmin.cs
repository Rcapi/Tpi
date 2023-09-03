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
    public partial class formMainAdmin : Form
    {
        public string NombreAdmin { get; set; }
        public string DniAdmin { get; set; }
        public formMainAdmin(string nombre, string dni)
        {
            InitializeComponent();
            InitializeComponent();
            NombreAdmin = nombre;
            DniAdmin = dni;
        }

        private void formMainAdmin_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido, " + NombreAdmin;
        }

        private void linkLblCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formIngreso formIngreso = new formIngreso();
            formIngreso.Show();
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ABMClientes abmclientes = new ABMClientes();
            abmclientes.Show();
        }

        private void datosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DatoUsuarioAdmin datoUsuarioAdmin = new DatoUsuarioAdmin(DniAdmin);
            datoUsuarioAdmin.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ABMEmpleados abmempleados = new ABMEmpleados();
            abmempleados.Show();
        }
    }
}

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
    public partial class formMainAdmin : Form
    {
        public string NombreAdmin { get; set; }
        public formMainAdmin(string nombre)
        {
            InitializeComponent();
            InitializeComponent();
            NombreAdmin = nombre;
        }

        private void formMainAdmin_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido, " + NombreAdmin;
        }

        private void linkLblCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            formIngreso formIngreso = new formIngreso();
            formIngreso.Show();
            this.Close();
        }
    }
}

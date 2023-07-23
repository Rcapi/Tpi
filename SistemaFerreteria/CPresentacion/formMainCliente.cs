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

    public partial class formMainCliente : Form
    {
        public string NombreCliente { get; set; }
        public formMainCliente(string nombre)
        {
            InitializeComponent();
            NombreCliente = nombre;

        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void formMainCliente_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido, " + NombreCliente;
        }
    }
}

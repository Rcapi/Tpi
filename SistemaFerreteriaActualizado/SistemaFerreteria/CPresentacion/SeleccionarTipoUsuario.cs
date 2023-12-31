﻿using System;
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
    public partial class SeleccionarTipoUsuario : Form
    {
        public SeleccionarTipoUsuario()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistroCliente registroCliente = new RegistroCliente();
            registroCliente.Show();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistroEmpleado registroEmpleado = new RegistroEmpleado();
            registroEmpleado.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            formIngreso formIngreso = new formIngreso();
            formIngreso.Show();
            this.Close();
        }
    }
}

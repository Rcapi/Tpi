using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using SistemaFerreteria.CPresentacion;




namespace SistemaFerreteria
{
    public partial class formIngreso : Form
    {
        public formIngreso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {


                try
                {

                    using (CDatos.FerreteriaEntities db = new CDatos.FerreteriaEntities())
                    {
                        var lst = from d in db.Usuarios
                                  where d.Clave == txtClave.Text.Trim()
                                  && d.Dni == txtUsuario.Text.Trim()
                                  select d;

                        if (lst.Count() > 0)
                        {
                            string nombre = lst.First().Nombre;
                            string dni = lst.First().Dni;

                        MessageBox.Show("Bienvenido, " + nombre, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var cli = from d in db.Clientes
                                      where txtUsuario.Text.Trim() == d.Dni
                                      select d;

                        var emp = from d in db.Empleadoes
                                      where txtUsuario.Text.Trim() == d.Dni
                                      select d;

                        var adm = from d in db.Administradors
                                      where txtUsuario.Text.Trim() == d.Dni
                                      select d;

                        if (cli.Count() > 0)
                            {
                            this.Hide();
                            formMainCliente formMainCliente = new formMainCliente(nombre, dni);
                            formMainCliente.Show();

                        }

                        if (emp.Count() > 0)
                        {
                            this.Hide();
                            formMainEmpleado formMainEmpleado = new formMainEmpleado(nombre, dni);
                            formMainEmpleado.Show();


                        }

                        if (adm.Count() > 0)
                        {
                            this.Hide();
                            formMainAdmin formMainAdmin = new formMainAdmin(nombre, dni);
                            formMainAdmin.Show();

                        }





                    }
                    else
                        {
                            MessageBox.Show("Inicio de sesión erróneo!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SeleccionarTipoUsuario seleccionarTipoUsuario = new SeleccionarTipoUsuario();
            seleccionarTipoUsuario.Show();

        }
    }
}

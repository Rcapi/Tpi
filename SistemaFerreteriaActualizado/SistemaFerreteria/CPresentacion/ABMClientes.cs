using SistemaFerreteria.CDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFerreteria.CPresentacion
{
    public partial class ABMClientes : Form
    {

        public ABMClientes()
        {
            InitializeComponent();
        }


        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewClientes.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    if (dataGridViewClientes.Columns[e.ColumnIndex].Name == "Modificar")
                    {
                        string dni = dataGridViewClientes.Rows[e.RowIndex].Cells["Dni"].Value.ToString();

                        ModificarCliente modificarCliente = new ModificarCliente(dni);
                        modificarCliente.ShowDialog();
                    }
                    else if (dataGridViewClientes.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        string dni = dataGridViewClientes.Rows[e.RowIndex].Cells["Dni"].Value.ToString();


                        DialogResult result = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            using (CDatos.FerreteriaEntities db = new CDatos.FerreteriaEntities())
                            {
                                Usuario usuario = db.Usuarios.FirstOrDefault(u => u.Dni == dni);
                                Cliente cliente = db.Clientes.FirstOrDefault(c => c.Dni == dni);


                                    db.Usuarios.Remove(usuario);
                                    db.Clientes.Remove(cliente);
                                    db.SaveChanges();

                                dataGridViewClientes.Rows.Clear();

                                List<Cliente> listaClientes = db.Clientes.ToList();
                                List<string> dnisNew = listaClientes.Select(c => c.Dni).ToList();
                                List<Usuario> listaUsuarios = db.Usuarios.Where(u => dnisNew.Contains(u.Dni)).ToList();

                                foreach (var usuarios in listaUsuarios)
                                {
                                    Cliente clientes = listaClientes.FirstOrDefault(c => c.Dni == usuarios.Dni);
                                    int nroCli = (clientes != null) ? cliente.NroCli : 0;
                                    dataGridViewClientes.Rows.Add(
                                        usuarios.Dni,
                                        nroCli,
                                        usuarios.Clave,
                                        usuarios.Nombre,
                                        usuarios.Apellido,
                                        usuarios.Email,
                                        usuarios.Ciudad,
                                        usuarios.Direccion

                                        );
                                }

                                dataGridViewClientes.Refresh();

                            }
                        }
                    }
                }
            }
        }

        private void ABMClientes_Load(object sender, EventArgs e)
        {
            using (CDatos.FerreteriaEntities db = new CDatos.FerreteriaEntities())
            {
                List<Cliente> listaClientes = db.Clientes.ToList();
                List<string> dnisNew = listaClientes.Select(c => c.Dni).ToList();
                List<Usuario> listaUsuarios = db.Usuarios.Where(u => dnisNew.Contains(u.Dni)).ToList();


                dataGridViewClientes.Columns.Add("Dni", "DNI");
                dataGridViewClientes.Columns.Add("NroCli", "Nro. Cliente");
                dataGridViewClientes.Columns.Add("Clave", "Clave");
                dataGridViewClientes.Columns.Add("Nombre", "Nombre");
                dataGridViewClientes.Columns.Add("Apellido", "Apellido");
                dataGridViewClientes.Columns.Add("Email", "Email");
                dataGridViewClientes.Columns.Add("Ciudad", "Ciudad");
                dataGridViewClientes.Columns.Add("Direccion", "Dirección");

                DataGridViewButtonColumn botonModificar = new DataGridViewButtonColumn();
                botonModificar.Name = "Modificar";
                botonModificar.Text = "Modificar";
                botonModificar.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn botonEliminar = new DataGridViewButtonColumn();
                botonEliminar.Name = "Eliminar";
                botonEliminar.Text = "Eliminar";
                botonEliminar.UseColumnTextForButtonValue = true;

                dataGridViewClientes.Columns.Add(botonModificar);
                dataGridViewClientes.Columns.Add(botonEliminar);


                foreach (var usuario in listaUsuarios)
                {
                    Cliente cliente = listaClientes.FirstOrDefault(c => c.Dni == usuario.Dni);
                    int nroCli = (cliente != null) ? cliente.NroCli : 0;
                    dataGridViewClientes.Rows.Add(
                        usuario.Dni,
                        nroCli,
                        usuario.Clave,
                        usuario.Nombre,
                        usuario.Apellido,
                        usuario.Email,
                        usuario.Ciudad,
                        usuario.Direccion

                        );
                }





            }



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (CDatos.FerreteriaEntities db = new CDatos.FerreteriaEntities())
            {

                string searchText = txtBuscar.Text;
                var usuariosConClientesFiltrados = from usuario in db.Usuarios
                                                   join cliente in db.Clientes on usuario.Dni equals cliente.Dni
                                                   where SqlFunctions.PatIndex("%" + searchText + "%", usuario.Dni) > 0
                                                   select new
                                                   {
                                                       usuario.Dni,
                                                       cliente.NroCli,
                                                       usuario.Clave,
                                                       usuario.Nombre,
                                                       usuario.Apellido,
                                                       usuario.Email,
                                                       usuario.Ciudad,
                                                       usuario.Direccion
                                                   };

                List<Cliente> listaClientes = db.Clientes.ToList();
                List<string> dnisNew = listaClientes.Select(c => c.Dni).ToList();
                List<Usuario> listaUsuarios = db.Usuarios.Where(u => dnisNew.Contains(u.Dni)).ToList();


                dataGridViewClientes.Rows.Clear();
                if(searchText != null)
                { 
                foreach (var usuarioConCliente in usuariosConClientesFiltrados)
                {
                    dataGridViewClientes.Rows.Add(
                        usuarioConCliente.Dni,
                        usuarioConCliente.NroCli,
                        usuarioConCliente.Clave,
                        usuarioConCliente.Nombre,
                        usuarioConCliente.Apellido,
                        usuarioConCliente.Email,
                        usuarioConCliente.Ciudad,
                        usuarioConCliente.Direccion
                    );
                }   
                }
                else
                {
                    foreach (var usuario in listaUsuarios)
                    {
                        Cliente cliente = listaClientes.FirstOrDefault(c => c.Dni == usuario.Dni);
                        int nroCli = (cliente != null) ? cliente.NroCli : 0;
                        dataGridViewClientes.Rows.Add(
                            usuario.Dni,
                            nroCli,
                            usuario.Clave,
                            usuario.Nombre,
                            usuario.Apellido,
                            usuario.Email,
                            usuario.Ciudad,
                            usuario.Direccion

                            );
                    }

                    dataGridViewClientes.Refresh();
                }




            }
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {

            RegistroClientePorParteDeEmpleado registroClientePorParteDeEmpleado = new RegistroClientePorParteDeEmpleado();
            registroClientePorParteDeEmpleado.Show();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (CDatos.FerreteriaEntities db = new CDatos.FerreteriaEntities())
            {
                List<Cliente> listaClientes = db.Clientes.ToList();
            List<string> dnisNew = listaClientes.Select(c => c.Dni).ToList();
            List<Usuario> listaUsuarios = db.Usuarios.Where(u => dnisNew.Contains(u.Dni)).ToList();

            dataGridViewClientes.Rows.Clear();
            foreach (var usuario in listaUsuarios)
            {
                Cliente cliente = listaClientes.FirstOrDefault(c => c.Dni == usuario.Dni);
                int nroCli = (cliente != null) ? cliente.NroCli : 0;
                dataGridViewClientes.Rows.Add(
                    usuario.Dni,
                    nroCli,
                    usuario.Clave,
                    usuario.Nombre,
                    usuario.Apellido,
                    usuario.Email,
                    usuario.Ciudad,
                    usuario.Direccion

                    );
            }
            }
        }
    }
}

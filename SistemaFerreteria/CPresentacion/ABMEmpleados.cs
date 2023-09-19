using Entidades;
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
using Empleado = CDatos.Empleado;
using Usuario = CDatos.Usuario;
using CDatos;


namespace Presentacion
{
    public partial class ABMEmpleados : Form
    {
        public ABMEmpleados()
        {
            InitializeComponent();
        }



        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewEmpleados.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    if (dataGridViewEmpleados.Columns[e.ColumnIndex].Name == "Modificar")
                    {
                        string dni = dataGridViewEmpleados.Rows[e.RowIndex].Cells["Dni"].Value.ToString();

                        ModificarDatos modificarEmpleado = new ModificarDatos(dni);
                        modificarEmpleado.ShowDialog();
                    }
                    else if (dataGridViewEmpleados.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        string dni = dataGridViewEmpleados.Rows[e.RowIndex].Cells["Dni"].Value.ToString();


                        DialogResult result = MessageBox.Show("¿Está seguro de eliminar este empleado?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            using (FerreteriaEntities db = new FerreteriaEntities())
                            {

                                Usuario usuario = db.Usuarios.FirstOrDefault(u => u.Dni == dni);
                                Empleado empleado = db.Empleadoes.FirstOrDefault(c => c.Dni == dni);


                                db.Usuarios.Remove(usuario);
                                db.Empleadoes.Remove(empleado);
                                db.SaveChanges();

                                dataGridViewEmpleados.Rows.Clear();

                                List<Empleado> listaEmpleados = db.Empleadoes.ToList();
                                List<string> dnisNew = listaEmpleados.Select(c => c.Dni).ToList();
                                List<Usuario> listaUsuarios = db.Usuarios.Where(u => dnisNew.Contains(u.Dni)).ToList();

                                foreach (var usuarios in listaUsuarios)
                                {
                                    Empleado empleados = listaEmpleados.FirstOrDefault(c => c.Dni == usuarios.Dni);
                                    int Legajo = (empleados != null) ? empleado.Legajo : 0;
                                    dataGridViewEmpleados.Rows.Add(
                                        usuarios.Dni,
                                        Legajo,
                                        usuarios.Clave,
                                        usuarios.Nombre,
                                        usuarios.Apellido,
                                        usuarios.Email,
                                        usuarios.Ciudad,
                                        usuarios.Direccion

                                        );
                                }

                                dataGridViewEmpleados.Refresh();

                            }
                        }
                    }
                }
            }
        }





        private void ABMEmpleados_Load(object sender, EventArgs e)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                List<Empleado> listaEmpleados = db.Empleadoes.ToList();
                List<string> dnisNew = listaEmpleados.Select(c => c.Dni).ToList();
                List<Usuario> listaUsuarios = db.Usuarios.Where(u => dnisNew.Contains(u.Dni)).ToList();


                dataGridViewEmpleados.Columns.Add("Dni", "DNI");
                dataGridViewEmpleados.Columns.Add("Legajo", "Nro. Legajo");
                dataGridViewEmpleados.Columns.Add("Clave", "Clave");
                dataGridViewEmpleados.Columns.Add("Nombre", "Nombre");
                dataGridViewEmpleados.Columns.Add("Apellido", "Apellido");
                dataGridViewEmpleados.Columns.Add("Email", "Email");
                dataGridViewEmpleados.Columns.Add("Ciudad", "Ciudad");
                dataGridViewEmpleados.Columns.Add("Direccion", "Dirección");

                DataGridViewButtonColumn botonModificar = new DataGridViewButtonColumn();
                botonModificar.Name = "Modificar";
                botonModificar.Text = "Modificar";
                botonModificar.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn botonEliminar = new DataGridViewButtonColumn();
                botonEliminar.Name = "Eliminar";
                botonEliminar.Text = "Eliminar";
                botonEliminar.UseColumnTextForButtonValue = true;

                dataGridViewEmpleados.Columns.Add(botonModificar);
                dataGridViewEmpleados.Columns.Add(botonEliminar);


                foreach (var usuario in listaUsuarios)
                {
                    Empleado empleado = listaEmpleados.FirstOrDefault(c => c.Dni == usuario.Dni);
                    int Legajo = (empleado != null) ? empleado.Legajo : 0;
                    dataGridViewEmpleados.Rows.Add(
                        usuario.Dni,
                        Legajo,
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
            using (FerreteriaEntities db = new FerreteriaEntities())
            {

                string searchText = txtBuscar.Text;
                var usuariosConEmpleadosFiltrados = from usuario in db.Usuarios
                                                   join empleado in db.Empleadoes on usuario.Dni equals empleado.Dni
                                                   where SqlFunctions.PatIndex("%" + searchText + "%", usuario.Dni) > 0
                                                   select new
                                                   {
                                                       usuario.Dni,
                                                       empleado.Legajo,
                                                       usuario.Clave,
                                                       usuario.Nombre,
                                                       usuario.Apellido,
                                                       usuario.Email,
                                                       usuario.Ciudad,
                                                       usuario.Direccion
                                                   };

                List<Empleado> listaEmpleados = db.Empleadoes.ToList();
                List<string> dnisNew = listaEmpleados.Select(c => c.Dni).ToList();
                List<Usuario> listaUsuarios = db.Usuarios.Where(u => dnisNew.Contains(u.Dni)).ToList();


                dataGridViewEmpleados.Rows.Clear();
                if (searchText != null)
                {
                    foreach (var usuarioConEmpleado in usuariosConEmpleadosFiltrados)
                    {
                        dataGridViewEmpleados.Rows.Add(
                            usuarioConEmpleado.Dni,
                            usuarioConEmpleado.Legajo,
                            usuarioConEmpleado.Clave,
                            usuarioConEmpleado.Nombre,
                            usuarioConEmpleado.Apellido,
                            usuarioConEmpleado.Email,
                            usuarioConEmpleado.Ciudad,
                            usuarioConEmpleado.Direccion
                        );
                    }
                }
                else
                {
                    foreach (var usuario in listaUsuarios)
                    {
                        Empleado empleado = listaEmpleados.FirstOrDefault(c => c.Dni == usuario.Dni);
                        int Legajo = (empleado != null) ? empleado.Legajo : 0;
                        dataGridViewEmpleados.Rows.Add(
                            usuario.Dni,
                            Legajo,
                            usuario.Clave,
                            usuario.Nombre,
                            usuario.Apellido,
                            usuario.Email,
                            usuario.Ciudad,
                            usuario.Direccion

                            );
                    }

                    dataGridViewEmpleados.Refresh();
                }




            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                List<Empleado> listaEmpleados = db.Empleadoes.ToList();
                List<string> dnisNew = listaEmpleados.Select(c => c.Dni).ToList();
                List<Usuario> listaUsuarios = db.Usuarios.Where(u => dnisNew.Contains(u.Dni)).ToList();

                dataGridViewEmpleados.Rows.Clear();
                foreach (var usuario in listaUsuarios)
                {
                    Empleado empleado = listaEmpleados.FirstOrDefault(c => c.Dni == usuario.Dni);
                    int Legajo = (empleado != null) ? empleado.Legajo : 0;
                    dataGridViewEmpleados.Rows.Add(
                        usuario.Dni,
                        Legajo,
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

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            RegistroEmpleadoPorAdmin registroEmpleadoPorAdmin = new RegistroEmpleadoPorAdmin();
            registroEmpleadoPorAdmin.Show();
        }
    }
}

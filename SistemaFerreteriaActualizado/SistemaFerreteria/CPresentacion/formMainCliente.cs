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
        public string DniCliente { get; set; }
        public formMainCliente(string nombre, string dni)
        {
            InitializeComponent();
            NombreCliente = nombre;
            DniCliente = dni;
            MostrarProductos();
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void MostrarProductos()
        {
            try
            {

                using (CDatos.FerreteriaEntities db = new CDatos.FerreteriaEntities())
                {
                    var prod = from p in db.Productoes
                               select p;


                    foreach (var producto in prod)
                    {



                        Panel productPanel = new Panel();
                        productPanel.Controls.AddRange(panelProducto.Controls.Cast<Control>().ToArray());
                        productPanel.BorderStyle = BorderStyle.FixedSingle;
                        productPanel.Size = new Size(300, 500);

                        Label lblCodigo = productPanel.Controls.Find("lblCodigo", true).FirstOrDefault() as Label;
                        if (lblCodigo != null)
                        {
                            lblCodigo.Text = $"Código: {producto.Codigo}";
                        }

                        Label lblNombre = productPanel.Controls.Find("lblNombre", true).FirstOrDefault() as Label;
                        if (lblNombre != null)
                        {
                            lblNombre.Text = $"Nombre: {producto.Nombre}";
                        }

                        Label lblPrecio = productPanel.Controls.Find("lblPrecio", true).FirstOrDefault() as Label;
                        if (lblPrecio != null)
                        {
                            lblPrecio.Text = $"Precio: {producto.Precio}";
                        }

                        Label lblDescripcion = productPanel.Controls.Find("lblDescripcion", true).FirstOrDefault() as Label;
                        if (lblDescripcion != null)
                        {
                            lblDescripcion.AutoSize = false; 
                            lblDescripcion.MaximumSize = new Size(lblDescripcion.Width, 0); 
                            lblDescripcion.Text = $"Descripcion: {producto.Descripcion}";
                        }



                        Button btnCarrito = productPanel.Controls.Find("btnCarrito", true).FirstOrDefault() as Button;
                        if (btnCarrito != null)
                        {
                            btnCarrito.Tag = producto;
                            btnCarrito.Click += btnCarrito_Click;
                        }

                        flowLayoutPanelProductoCliente.AutoScroll = true;
                        flowLayoutPanelProductoCliente.Controls.Add(productPanel);

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void formMainCliente_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido, " + NombreCliente;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Hide();
                formIngreso formIngreso = new formIngreso();
                formIngreso.Show();
                this.Close();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {

        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosUsuarioCliente datosUsuario = new DatosUsuarioCliente(DniCliente);
            datosUsuario.Show();
        }
    }
}

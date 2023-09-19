using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDatos;


namespace Presentacion
{
    public partial class ABMHerramientaDeMano : Form
    {
        public ABMHerramientaDeMano()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FerreteriaEntities db = new FerreteriaEntities())
                {

                    string codigo = txtCodigo.Text;
                    Producto productoExistente = db.Productoes.FirstOrDefault(p => p.Codigo == codigo);
                    Herramienta herramientaExistente = db.Herramientas.FirstOrDefault(p => p.Codigo == codigo);
                    HerramientaManual herramientaManualExistente = db.HerramientaManuals.FirstOrDefault(p => p.Codigo == codigo);

                    if (herramientaManualExistente != null)
                    {

                        if (!string.IsNullOrEmpty(txtNombre.Text))
                        {
                            productoExistente.Nombre = txtNombre.Text;
                        }

                        if (!string.IsNullOrEmpty(txtDescripcion.Text))
                        {
                            productoExistente.Descripcion = txtDescripcion.Text;
                        }

                        if (!string.IsNullOrEmpty(txtPrecio.Text))
                        {
                            productoExistente.Precio = double.Parse(txtPrecio.Text);
                        }

                        if (!string.IsNullOrEmpty(txtStock.Text))
                        {
                            productoExistente.Stock = int.Parse(txtStock.Text);
                        }

                        if (!string.IsNullOrEmpty(txtModelo.Text))
                        {
                            herramientaExistente.Modelo = txtModelo.Text;
                        }

                        if (!string.IsNullOrEmpty(txtTipoHerramienta.Text))
                        {
                            herramientaManualExistente.Tipo = txtTipoHerramienta.Text;
                        }

                        db.SaveChanges();
                    }
                    else
                    {

                        Producto nuevoProducto = new Producto
                        {
                            Codigo = txtCodigo.Text,
                            Nombre = txtNombre.Text,
                            Descripcion = txtDescripcion.Text,
                            Precio = double.Parse(txtPrecio.Text),
                            Stock = int.Parse(txtStock.Text),

                        };

                        Herramienta nuevaHerramienta = new Herramienta
                        {
                            Codigo = txtCodigo.Text,
                            Modelo = txtModelo.Text,
                        };

                        HerramientaManual nuevaHerramientaManual = new HerramientaManual
                        {
                            Codigo = txtCodigo.Text,
                            Modelo = txtModelo.Text,
                            Tipo = txtTipoHerramienta.Text,
                        };

                        if (!string.IsNullOrEmpty(txtCodigo.Text) &&
                            !string.IsNullOrEmpty(txtNombre.Text))
                        {

                            db.Productoes.Add(nuevoProducto);
                            db.Herramientas.Add(nuevaHerramienta);
                            db.HerramientaManuals.Add(nuevaHerramientaManual);
                            db.SaveChanges();
                            MessageBox.Show("Producto guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }


                        else if (string.IsNullOrEmpty(txtCodigo.Text))
                        {

                            MessageBox.Show("El campo Codigo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else if (string.IsNullOrEmpty(txtNombre.Text))
                        {

                            MessageBox.Show("El campo nombre no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                using (FerreteriaEntities db = new FerreteriaEntities())
                {
                    string codigo = txtCodigo.Text;
                    Producto productoAEliminar = db.Productoes.FirstOrDefault(p => p.Codigo == codigo);
                    Herramienta herramientaAEliminar = db.Herramientas.FirstOrDefault(p => p.Codigo == codigo);
                    HerramientaManual herramientaManualAEliminar = db.HerramientaManuals.FirstOrDefault(p => p.Codigo == codigo);

                    if (herramientaManualAEliminar != null)
                    {
                        db.Productoes.Remove(productoAEliminar);
                        db.Herramientas.Remove(herramientaAEliminar);
                        db.HerramientaManuals.Remove(herramientaManualAEliminar);
                        db.SaveChanges();
                        MessageBox.Show("Producto eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    else
                    {
                        MessageBox.Show("No se encontro el producto a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}

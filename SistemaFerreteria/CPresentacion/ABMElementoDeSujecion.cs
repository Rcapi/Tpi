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
    public partial class ABMElementoDeSujecion : Form
    {
        public ABMElementoDeSujecion()
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
                    ElementoDeSujecion elementoDeSujecionExistente = db.ElementoDeSujecions.FirstOrDefault(p => p.Codigo == codigo);

                    if (elementoDeSujecionExistente != null)
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

                        if (!string.IsNullOrEmpty(txtCapacidad.Text))
                        {
                            elementoDeSujecionExistente.Capacidad = double.Parse(txtCapacidad.Text);
                        }

                        if (!string.IsNullOrEmpty(txtLongitud.Text))
                        {
                            elementoDeSujecionExistente.Longitud = double.Parse(txtLongitud.Text);
                        }

                        if (!string.IsNullOrEmpty(txtTipoElemento.Text))
                        {
                            elementoDeSujecionExistente.Longitud = double.Parse(txtTipoElemento.Text);
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


                        ElementoDeSujecion nuevoElementoDeSujecion = new ElementoDeSujecion
                        {
                            Codigo = txtCodigo.Text,
                            Capacidad = double.Parse(txtCapacidad.Text),
                            TipoElemento = txtTipoElemento.Text,
                            Longitud = double.Parse(txtLongitud.Text),
                        };

                        if (!string.IsNullOrEmpty(txtCodigo.Text) &&
                            !string.IsNullOrEmpty(txtNombre.Text))
                        {

                            db.Productoes.Add(nuevoProducto);
                            db.ElementoDeSujecions.Add(nuevoElementoDeSujecion);
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
                    ElementoDeSujecion nuevoElementoDeSujecion = db.ElementoDeSujecions.FirstOrDefault(p => p.Codigo == codigo);

                    if (nuevoElementoDeSujecion != null)
                    {
                        db.Productoes.Remove(productoAEliminar);
                        db.ElementoDeSujecions.Remove(nuevoElementoDeSujecion);
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

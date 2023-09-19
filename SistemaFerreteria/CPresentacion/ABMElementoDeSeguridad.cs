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
    public partial class ABMElementoDeSeguridad : Form
    {
        public ABMElementoDeSeguridad()
        {
            InitializeComponent();
        }

        private void lblModelo_Click(object sender, EventArgs e)
        {

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                using (FerreteriaEntities db = new FerreteriaEntities())
                {
                    string codigo = txtCodigo.Text;
                    Producto productoAEliminar = db.Productoes.FirstOrDefault(p => p.Codigo == codigo);
                    EquipoDeSeguridad equipoDeSeguridadAEliminar = db.EquipoDeSeguridads.FirstOrDefault(p => p.Codigo == codigo);

                    if (equipoDeSeguridadAEliminar != null)
                    {
                        db.Productoes.Remove(productoAEliminar);
                        db.EquipoDeSeguridads.Remove(equipoDeSeguridadAEliminar);
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

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (FerreteriaEntities db = new FerreteriaEntities())
                {

                    string codigo = txtCodigo.Text;
                    Producto productoExistente = db.Productoes.FirstOrDefault(p => p.Codigo == codigo);
                    EquipoDeSeguridad equipoDeSeguridadExistente = db.EquipoDeSeguridads.FirstOrDefault(p => p.Codigo == codigo);

                    if (equipoDeSeguridadExistente != null)
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

                        if (!string.IsNullOrEmpty(txtNormativa.Text))
                        {
                            equipoDeSeguridadExistente.Normativa = txtNormativa.Text;
                        }

                        if (!string.IsNullOrEmpty(txtPeso.Text))
                        {
                            equipoDeSeguridadExistente.Peso = double.Parse(txtPeso.Text);
                        }

                        if (!string.IsNullOrEmpty(txtTalle.Text))
                        {
                            equipoDeSeguridadExistente.Talle = txtTalle.Text;
                        }
                        if (!string.IsNullOrEmpty(txtTipoEquipo.Text))
                        {
                            equipoDeSeguridadExistente.TipoEquipo = txtTipoEquipo.Text;
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

                        EquipoDeSeguridad nuevoEquipoDeSeguridad = new EquipoDeSeguridad
                        {
                            Codigo = txtCodigo.Text,
                            Normativa = txtNormativa.Text,
                            Peso = double.Parse(txtPeso.Text),
                            Talle = txtTalle.Text,
                            TipoEquipo = txtTipoEquipo.Text,
                        };

                        if (!string.IsNullOrEmpty(txtCodigo.Text) &&
                            !string.IsNullOrEmpty(txtNombre.Text))
                        {

                            db.Productoes.Add(nuevoProducto);
                            db.EquipoDeSeguridads.Add(nuevoEquipoDeSeguridad);
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
    }
    
}

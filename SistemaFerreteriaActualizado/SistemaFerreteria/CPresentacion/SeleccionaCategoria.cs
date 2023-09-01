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
    public partial class SeleccionaCategoria : Form
    {

        private Dictionary<string, string> categorias = new Dictionary<string, string>();
        public SeleccionaCategoria()
        {
            InitializeComponent();
        }

        private void SeleccionaCategoria_Load(object sender, EventArgs e)
        {
            categorias.Add("Elemento de Seguridad", "ElementoDeSeguridad");
            categorias.Add("Herramienta de Mano", "HerramientaDeMano");
            categorias.Add("Herramienta Eléctrica", "HerramientaElectrica");
            categorias.Add("Materiales de Construcción", "MaterialesDeConstruccion");
            categorias.Add("Elemento de Sujeción", "ElementoDeSujecion");
            comboBoxCategoria.DataSource = new BindingSource(categorias, null);
            comboBoxCategoria.DisplayMember = "Key";
            comboBoxCategoria.ValueMember = "Value";
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string valorInterno = comboBoxCategoria.SelectedValue.ToString();

            if (valorInterno == "HerramientaDeMano")
            {
                var abmHerramientaDeMano = new ABMHerramientaDeMano();
                this.Hide();
                abmHerramientaDeMano.Show();
            }
            else if (valorInterno == "HerramientaElectrica")
            {
                var abmHerramientasElectricas = new ABMHerramientasElectricas();
                this.Hide();
                abmHerramientasElectricas.Show();
            }
            else if (valorInterno == "ElementoDeSeguridad")
            {
                var abmElementoDeSeguridad = new ABMElementoDeSeguridad();
                this.Hide();
                abmElementoDeSeguridad.Show();
            }
            else
            {
                var abmElementoDeSujecion = new ABMElementoDeSujecion();
                this.Hide();
                abmElementoDeSujecion.Show();
            }
        }
    }
}

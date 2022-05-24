using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E1Simulado.Clases;

namespace E1Simulado.Formas
{
    public partial class frmEjercicio2 : Form
    {
        private E2Carretera miCarretera;
        public frmEjercicio2()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            miCarretera = new E2Carretera();
            if (txtCantidadKilometros.Text == "")
                MessageBox.Show("El campo de texto no puede estar vacío", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                miCarretera.CantidadKilometros = double.Parse(txtCantidadKilometros.Text);
                MessageBox.Show("Datos capturados correctamente");
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (miCarretera.CantidadKilometros != null)
                MessageBox.Show($"Kilometros a Millas: {miCarretera.Convertir()}");
            else
                MessageBox.Show("El campo de texto no puede estar vacío", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
    }
}

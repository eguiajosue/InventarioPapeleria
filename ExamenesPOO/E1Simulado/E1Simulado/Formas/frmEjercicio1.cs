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
    public partial class frmEjercicio1 : Form
    {
        private E1LitroAgua miLitroAgua;

        public frmEjercicio1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Litros a Galones: {miLitroAgua.ConvertirLitrosAGalones()}");
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            miLitroAgua = new E1LitroAgua();
            if (txtCantidadLitros.Text == "")
                MessageBox.Show("El campo de texto no puede estar vacío", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                miLitroAgua.CantidadLitros = double.Parse(txtCantidadLitros.Text);
                MessageBox.Show("Datos capturados correctamente");
            }
        }
    }
}

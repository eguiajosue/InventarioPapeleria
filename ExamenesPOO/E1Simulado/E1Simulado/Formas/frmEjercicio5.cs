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
    public partial class frmEjercicio5 : Form
    {
        E5Vendedor miVendedor;
        public frmEjercicio5()
        {
            InitializeComponent();
        }

        private void frmEjercicio5_Load(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (txtNombreVendedor.Text == "" || txtCantidadPaletas.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("No pueden haben campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                miVendedor = new E5Vendedor();
                miVendedor.NombreVendedor = txtNombreVendedor.Text;
                miVendedor.CantidadPaletasVendidas = int.Parse(txtCantidadPaletas.Text);
                miVendedor.PrecioPaleta = double.Parse(txtPrecio.Text);

                MessageBox.Show("Datos capturados correctamente");
            }
        }

        private void btnCalcularVenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{miVendedor.NombreVendedor} ha vendido en total: {miVendedor.CalcularTotalVentas().ToString("C")}");
        }
    }
}

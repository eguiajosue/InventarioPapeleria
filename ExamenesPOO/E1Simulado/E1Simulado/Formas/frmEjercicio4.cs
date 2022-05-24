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
    public partial class frmEjercicio4 : Form
    {
        private E4Producto miProducto;
        public frmEjercicio4()
        {
            InitializeComponent();
        }

        private void frmEjercicio4_Load(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                miProducto = new E4Producto();
                miProducto.NombreProducto = txtNombreProducto.Text;
                miProducto.Precio = double.Parse(txtPrecio.Text);

                MessageBox.Show("Datos capturados correctamente");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El IVA de {miProducto.NombreProducto} es de: {miProducto.CalcularIVA().ToString("C")}");
        }
    }
}

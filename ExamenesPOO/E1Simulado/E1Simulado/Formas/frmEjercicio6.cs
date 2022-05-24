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
    public partial class frmEjercicio6 : Form
    {
        private E6Empleado miEmpleado;
        public frmEjercicio6()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (txtCantidadVentas.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                miEmpleado.CantidadVentas = int.Parse(txtCantidadVentas.Text);

                MessageBox.Show("Datos capturados correctamente");
            }
        }

        private void btnCalcularBono_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El bono por ${miEmpleado.CantidadVentas} es de: {miEmpleado.CalcularBono().ToString("C")}");
        }
    }
}

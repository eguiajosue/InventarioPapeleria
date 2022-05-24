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
    public partial class frmEjercicio7 : Form
    {
        private E7Empleado miEmpleado;
        public frmEjercicio7()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (txtSueldo.Text == "")
            {
                MessageBox.Show("No puede haber campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                miEmpleado.Sueldo = double.Parse(txtSueldo.Text);

                MessageBox.Show("Datos capturados correctamebte");
            }
        }
    }
}

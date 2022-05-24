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
    public partial class frmEjercicio3 : Form
    {
        private E3Estudiante miEstudiante;
        public frmEjercicio3()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtMateria1.Text == "" || txtMateria2.Text == "" || txtMateria3.Text == "")
            {
                MessageBox.Show("Ninguno de los campos puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                miEstudiante = new E3Estudiante();
                miEstudiante.Nombre = txtNombre.Text;
                miEstudiante.Materia1 = double.Parse(txtMateria1.Text);
                miEstudiante.Materia2 = double.Parse(txtMateria2.Text);
                miEstudiante.Materia3 = double.Parse(txtMateria3.Text);

                MessageBox.Show("Datos capturados correctamente");
            }
        }

        private void btnPromediar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El promedio de {miEstudiante.Nombre} es de: {miEstudiante.CalcularPromedio()}");
        }
    }
}

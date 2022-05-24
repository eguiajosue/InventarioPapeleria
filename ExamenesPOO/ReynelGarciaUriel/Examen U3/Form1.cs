using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_U3
{
    public partial class Form1 : Form
    {
        PacienteEspecial unPacienteEspecial;
        PacienteEspecial otroPacienteEspecial;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCaptuarar_Click(object sender, EventArgs e)
        {
            unPacienteEspecial = new PacienteEspecial("desconocido", "desconocido", 0, 0, "Desconocido");
            unPacienteEspecial.Nombre = txtNombre.Text;
            unPacienteEspecial.Sexo = txtSexo.Text;
            unPacienteEspecial.Edad = int.Parse(txtEdad.Text);
            unPacienteEspecial.CostoDeConsultaGeneral = double.Parse(txtCostoDeConsultaGeneral.Text);
            if (radRespiradorArtificial.Checked) unPacienteEspecial.TipoDeTratamiento = "Respirador Artifical";
            if (radMediastino.Checked) unPacienteEspecial.TipoDeTratamiento = "Mediastino";
            //Console.WriteLine(unPacienteEspecial.CalcularPago());
            MessageBox.Show("Se han capturado los datos del Paciente ");
            btnCaptuarar.Enabled = false;
        }

        private void btnMostrarMayor_Click(object sender, EventArgs e)
        {
            int intResultado = unPacienteEspecial.CalcularPago().CompareTo(otroPacienteEspecial.CalcularPago());
            switch (intResultado)
            {
                case 1:
                    MessageBox.Show($"El paciente {unPacienteEspecial.Nombre} va a pagar mas ");
                    break;
                case -1:
                    MessageBox.Show($"El paciente {otroPacienteEspecial.Nombre} va a pagar mas");
                    break;
                case 0:
                    MessageBox.Show("Ambos pacientes pagan lo mismo");
                    break;
            }
        }

        private void btnCapturarotropaciente_Click(object sender, EventArgs e)
        {
            otroPacienteEspecial = new PacienteEspecial("desconocido", "desconocido", 0, 0, "Desconocido");
            otroPacienteEspecial.Nombre = txtNombre.Text;
            otroPacienteEspecial.Sexo = txtSexo.Text;
            otroPacienteEspecial.Edad = int.Parse(txtEdad.Text);
            otroPacienteEspecial.CostoDeConsultaGeneral = double.Parse(txtCostoDeConsultaGeneral.Text);
            if (radRespiradorArtificial.Checked) otroPacienteEspecial.TipoDeTratamiento = "Respirador Artifical";
            if (radMediastino.Checked) otroPacienteEspecial.TipoDeTratamiento = "Mediastino";
            //Console.WriteLine(otroPacienteEspecial.CalcularPago());
            MessageBox.Show("Se han capturado los datos del Paciente ");
            btnCapturarotropaciente.Enabled = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E1Simulado.Formas;

namespace E1Simulado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form formulario = panelEjercicios.Controls.OfType<T>().FirstOrDefault();
            if (formulario != null)
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

                if (formulario.WindowState == FormWindowState.Normal)
                {
                    formulario.Close();
                }
                formulario.BringToFront();
                return;
            }

            panelEjercicios.Controls.Clear();
            formulario = new T();
            formulario.TopLevel = false;
            panelEjercicios.Controls.Add(formulario);
            panelEjercicios.Tag = formulario;
            formulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio1>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio2>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio3>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio4>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio5>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio6>();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio7>();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio8>();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio9>();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio10>();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio11>();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio12>();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio13>();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio14>();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio15>();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio16>();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio17>();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio18>();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio19>();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicio20>();
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {

        }

        private void button48_Click(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {

        }

        private void button50_Click(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {

        }

        private void button52_Click(object sender, EventArgs e)
        {

        }

        private void button53_Click(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {

        }

        private void button55_Click(object sender, EventArgs e)
        {

        }

        private void button56_Click(object sender, EventArgs e)
        {

        }

        private void button57_Click(object sender, EventArgs e)
        {

        }

        private void button58_Click(object sender, EventArgs e)
        {

        }

        private void button59_Click(object sender, EventArgs e)
        {

        }

        private void button60_Click(object sender, EventArgs e)
        {

        }

        private void button61_Click(object sender, EventArgs e)
        {

        }

        private void button62_Click(object sender, EventArgs e)
        {

        }

        private void button63_Click(object sender, EventArgs e)
        {

        }

        private void button64_Click(object sender, EventArgs e)
        {

        }

        private void button65_Click(object sender, EventArgs e)
        {

        }

        private void button66_Click(object sender, EventArgs e)
        {

        }

        private void button67_Click(object sender, EventArgs e)
        {

        }

        private void button68_Click(object sender, EventArgs e)
        {

        }

        private void button69_Click(object sender, EventArgs e)
        {

        }

        private void button70_Click(object sender, EventArgs e)
        {

        }
    }
}

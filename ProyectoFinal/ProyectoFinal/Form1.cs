using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        Tienda MiTienda = new Tienda();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarTienda_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard;
            try
            {
                MiTienda.Nombre = txtNombre.Text;
                MiTienda.Direccion = txtDireccion.Text;
                MiTienda.Telefono = int.Parse(txtTelefono.Text);

                MessageBox.Show("Tienda registrada correctamente", "Tienda agregada", MessageBoxButtons.OK, MessageBoxIcon.None);

                dashboard = new frmDashboard(MiTienda);
                this.Hide();

                dashboard.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "Error al agregar la tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

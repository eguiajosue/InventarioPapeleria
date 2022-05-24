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
    public partial class frmDashboard : Form
    {
        Tienda miTienda;

        public frmDashboard(Tienda miTienda)
        {
            InitializeComponent();
            this.miTienda = miTienda;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            txtNombre.Text = miTienda.Nombre;
            txtDireccion.Text = miTienda.Direccion;
            txtTelefono.Text = miTienda.Telefono.ToString();
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form formulario = panelMenu.Controls.OfType<T>().FirstOrDefault();
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

            panelMenu.Controls.Clear();
            formulario = new T();
            formulario.TopLevel = false;
            panelMenu.Controls.Add(formulario);
            panelMenu.Tag = formulario;
            formulario.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmInicio>();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmInventario inventario = panelMenu.Controls.OfType<frmInventario>().FirstOrDefault(); ;

            if (inventario != null)
            {
                if (inventario.WindowState == FormWindowState.Minimized)
                {
                    inventario.WindowState = FormWindowState.Normal;
                }

                if (inventario.WindowState == FormWindowState.Normal)
                {
                    inventario.Close();
                }
                inventario.BringToFront();
            }

            panelMenu.Controls.Clear();
            inventario = new frmInventario(miTienda);
            inventario.TopLevel = false;
            panelMenu.Controls.Add(inventario);
            panelMenu.Tag = inventario;
            inventario.Show();

        }
    }
}

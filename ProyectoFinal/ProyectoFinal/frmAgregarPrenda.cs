using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProyectoFinal
{
    public partial class frmAgregarPrenda : Form
    {
        private Tienda miTienda;
        Primavera primavera = new Primavera();
        public frmAgregarPrenda(Tienda miTienda)
        {
            InitializeComponent();
            this.miTienda = miTienda;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboColecciones.SelectedItem == "Primavera")
            {
                cboCategoria.Items.Clear();
                cboCategoria.Items.Add("Camisa de Manga Corta");
                cboCategoria.Items.Add("Short");
            }

            if (cboColecciones.SelectedItem == "Verano")
            {
                cboCategoria.Items.Clear();
                cboCategoria.Items.Add("Traje de Baño");
            }

            if (cboColecciones.SelectedItem == "Otoño")
            {
                cboCategoria.Items.Clear();
                cboCategoria.Items.Add("Camisa de Manga Larga");
                cboCategoria.Items.Add("Pants");
            }

            if (cboColecciones.SelectedItem == "Invierno")
            {
                cboCategoria.Items.Clear();
                cboCategoria.Items.Add("Chamarra");
                cboCategoria.Items.Add("Sueters");
            }
        }

        private void frmAgregarPrenda_Load(object sender, EventArgs e)
        {
            txtTipoMaterial.Visible = false;
            lblTipoMaterial.Visible = false;
            txtCantidadPiezas.Visible = false;
            lblCantidadPiezas.Visible = false;
            chkCierre.Visible = false;
            chkEstampado.Visible = false;
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategoria.SelectedItem == "")
            {
                txtTipoMaterial.Visible = false;
                lblTipoMaterial.Visible = false;
                txtCantidadPiezas.Visible = false;
                lblCantidadPiezas.Visible = false;
                chkCierre.Visible = false;
                chkEstampado.Visible = false;
            }

            if (cboCategoria.SelectedItem == "Camisa de Manga Corta")
            {
                txtTipoMaterial.Visible = false;
                lblTipoMaterial.Visible = false;
                txtCantidadPiezas.Visible = false;
                lblCantidadPiezas.Visible = false;
                chkCierre.Visible = false;
                chkEstampado.Visible = true;
            }

            if (cboCategoria.SelectedItem == "Short")
            {
                txtTipoMaterial.Visible = true;
                lblTipoMaterial.Visible = true;
                txtCantidadPiezas.Visible = false;
                lblCantidadPiezas.Visible = false;
                chkCierre.Visible = false;
                chkEstampado.Visible = false;
            }

            if (cboCategoria.SelectedItem == "Traje de Baño")
            {
                txtTipoMaterial.Visible = false;
                lblTipoMaterial.Visible = false;
                txtCantidadPiezas.Visible = true;
                lblCantidadPiezas.Visible = true;
                chkCierre.Visible = false;
                chkEstampado.Visible = false;
            }

            if (cboCategoria.SelectedItem == "Camisa de Manga Larga")
            {
                txtTipoMaterial.Visible = true;
                lblTipoMaterial.Visible = true;
                txtCantidadPiezas.Visible = false;
                lblCantidadPiezas.Visible = false;
                chkCierre.Visible = false;
                chkEstampado.Visible = false;
            }

            if (cboCategoria.SelectedItem == "Pants")
            {
                txtTipoMaterial.Visible = true;
                lblTipoMaterial.Visible = true;
                txtCantidadPiezas.Visible = false;
                lblCantidadPiezas.Visible = false;
                chkCierre.Visible = false;
                chkEstampado.Visible = false;
            }

            if (cboCategoria.SelectedItem == "Sueters")
            {
                txtTipoMaterial.Visible = false;
                lblTipoMaterial.Visible = false;
                txtCantidadPiezas.Visible = false;
                lblCantidadPiezas.Visible = false;
                chkCierre.Visible = true;
                chkEstampado.Visible = false;
            }

            if (cboCategoria.SelectedItem == "Chamarra")
            {
                txtTipoMaterial.Visible = true;
                lblTipoMaterial.Visible = true;
                txtCantidadPiezas.Visible = false;
                lblCantidadPiezas.Visible = false;
                chkCierre.Visible = false;
                chkEstampado.Visible = false;
            }
        }

        private void btnAgregarNuevaPrenda_Click(object sender, EventArgs e)
        {
            if (cboCategoria.SelectedItem == "Camisa de Manga Corta")
            {
                CamisaMangaCorta nuevaCamisaMangaCorta = new CamisaMangaCorta();
                nuevaCamisaMangaCorta.Color = txtColor.Text;
                nuevaCamisaMangaCorta.Talla = cboTalla.ValueMember;
                nuevaCamisaMangaCorta.Marca = txtMarca.Text;
                if (chkEstampado.Checked) nuevaCamisaMangaCorta.Estampado = true;

                primavera.AgregarCamisaMangaCorta(nuevaCamisaMangaCorta);                
                
                MessageBox.Show("Agregado");
                Console.WriteLine(miTienda.ListaPrimavera.Count());
            }
        }
    }
}
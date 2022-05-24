using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmInventario : Form
    {
        private readonly Tienda miTienda;

        public frmInventario(Tienda miTienda)
        {
            InitializeComponent();
            this.miTienda = miTienda;
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            lstColecciones.Items.Add("Primavera");
            lstColecciones.Items.Add("Verano");
            lstColecciones.Items.Add("Otoño");
            lstColecciones.Items.Add("Invierno");

            dtgInventario.Columns.Add("talla", "Talla");
            dtgInventario.Columns.Add("color", "Color");
            dtgInventario.Columns.Add("marca", "Marca");
        }

        private void lstColecciones_Click(object sender, EventArgs e)
        {
            if (lstColecciones.SelectedItem == "Primavera")
            {
                lstTiposPrenda.Items.Clear();
                lstTiposPrenda.Items.Add("Camisas de Manga Corta");
                lstTiposPrenda.Items.Add("Shorts");
            }

            if (lstColecciones.SelectedItem == "Verano")
            {
                lstTiposPrenda.Items.Clear();
                lstTiposPrenda.Items.Add("Trajes de Baño");
            }

            if (lstColecciones.SelectedItem == "Otoño")
            {
                lstTiposPrenda.Items.Clear();
                lstTiposPrenda.Items.Add("Camisas de Manga Larga");
                lstTiposPrenda.Items.Add("Pants");
            }

            if (lstColecciones.SelectedItem == "Invierno")
            {
                lstTiposPrenda.Items.Clear();
                lstTiposPrenda.Items.Add("Sueters");
                lstTiposPrenda.Items.Add("Chamarras");
            }
        }

        private void btnAgregarPrenda_Click(object sender, EventArgs e)
        {
            var dashboard = new frmDashboard(miTienda);
            dashboard.Width = 1000;
        }

        private void lstTiposPrenda_Click(object sender, EventArgs e)
        {
            if (lstTiposPrenda.SelectedItem == "Camisas de Manga Corta")
            {
                dtgInventario.Rows.Clear();

                if (dtgInventario.ColumnCount >= 4)
                    dtgInventario.Columns.RemoveAt(3);

                if (dtgInventario.ColumnCount < 4)
                    dtgInventario.Columns.Add("estampado", "¿Tiene estampado?");
                else
                    return;
            }

            if (lstTiposPrenda.SelectedItem == "Shorts")
            {
                dtgInventario.Rows.Clear();
                if (dtgInventario.ColumnCount >= 4)
                    dtgInventario.Columns.RemoveAt(3);

                if (dtgInventario.ColumnCount < 4)
                    dtgInventario.Columns.Add("tipoMaterial", "Tipo de Material");
                else
                    return;
            }

            if (lstTiposPrenda.SelectedItem == "Trajes de Baño")
            {
                dtgInventario.Rows.Clear();
                if (dtgInventario.ColumnCount >= 4)
                    dtgInventario.Columns.RemoveAt(3);

                if (dtgInventario.ColumnCount < 4)
                    dtgInventario.Columns.Add("cantidadPiezas", "Cantidad de Piezas");
                else
                    return;
            }

            if (lstTiposPrenda.SelectedItem == "Camisas de Manga Larga")
            {
                dtgInventario.Rows.Clear();
                if (dtgInventario.ColumnCount >= 4)
                    dtgInventario.Columns.RemoveAt(3);

                if (dtgInventario.ColumnCount < 4)
                    dtgInventario.Columns.Add("tipoMaterial", "Tipo de Material");
                else
                    return;
            }

            if (lstTiposPrenda.SelectedItem == "Pants")
            {
                dtgInventario.Rows.Clear();
                if (dtgInventario.ColumnCount >= 4)
                    dtgInventario.Columns.RemoveAt(3);

                if (dtgInventario.ColumnCount < 4)
                    dtgInventario.Columns.Add("tipoMaterial", "Tipo de Material");
                else
                    return;
            }

            if (lstTiposPrenda.SelectedItem == "Sueters")
            {
                dtgInventario.Rows.Clear();
                if (dtgInventario.ColumnCount >= 4)
                    dtgInventario.Columns.RemoveAt(3);

                if (dtgInventario.ColumnCount < 4)
                    dtgInventario.Columns.Add("tieneCierre", "¿Tiene cierre / Zipper?");
                else
                    return;
            }

            if (lstTiposPrenda.SelectedItem == "Chamarras")
            {
                dtgInventario.Rows.Clear();
                if (dtgInventario.ColumnCount >= 4)
                    dtgInventario.Columns.RemoveAt(3);

                if (dtgInventario.ColumnCount < 4)
                    dtgInventario.Columns.Add("tipoMaterial", "Tipo de Material");
                else
                    return;
            }
        }

        public void MostrarPrenda()
        {

        }
    }
}
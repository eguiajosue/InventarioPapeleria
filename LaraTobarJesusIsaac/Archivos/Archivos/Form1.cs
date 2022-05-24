using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos
{
    public partial class Form1 : Form
    {
        ArchivoSecuencialSerializadoBinario<Pelicula> miArchivo = new ArchivoSecuencialSerializadoBinario<Pelicula>("C:\\Datos\\Archivo.dat");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgPelicula.Columns.Add("Nombre", "Nombre");
            dtgPelicula.Columns.Add("Cantidad De Peliculas", "Cantidad De Peliculas");
            dtgPelicula.Columns.Add("Precio", "Precio");
            dtgPelicula.Columns.Add("Clasificacion", "Clasificacion");
            dtgPelicula.Columns.Add("Pagada", "Pagada");
            dtgPelicula.Columns.Add("Estreno", "Estreno");
            dtgPelicula.AllowUserToAddRows = false;
            dtgPelicula.AllowUserToDeleteRows = false;
            dtgPelicula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPelicula.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPelicula.MultiSelect = false;
            dtgPelicula.ReadOnly = true;
            MostrarDatos();
        }

        private void dtgPelicula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pelicula miPelicula = new Pelicula();
            try
            {
                miPelicula.Nombre = txtNombre.Text;
                miPelicula.CantidadDePeliculas = int.Parse(txtCantidad.Text);
                miPelicula.Precio = double.Parse(txtPrecio.Text);
                miPelicula.Clasificacion = char.Parse(txtClasificacion.Text);
                if (radSi.Checked)
                {
                    miPelicula.Pagada = true;
                }
                if (radNo.Checked)
                {
                    miPelicula.Pagada = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                miArchivo.AbrirEnModoEscritura();
                miArchivo.GrabarObjeto(miPelicula);
                MessageBox.Show("Se han guardado los datos de manera correcta :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                miArchivo.Cerrar();
            }
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            Pelicula miPelicula = new Pelicula();
            dtgPelicula.Rows.Clear();
            try
            {
                miArchivo.AbrirEnModoLectura();
                while (!miArchivo.FinArchivo)
                {
                    miPelicula = miArchivo.LeerObjeto();
                    dtgPelicula.Rows.Add(miPelicula.Nombre.ToString(), miPelicula.CantidadDePeliculas, miPelicula.Precio, miPelicula.Clasificacion, miPelicula.Pagada, miPelicula.Estreno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtNombre.Text = "";
                txtCantidad.Text = "";
                radSi.Text = "";
                radNo.Text = "";
                dtmEstreno.Text = "";
                txtPrecio.Text = "";
                txtClasificacion.Text = "";
            }
        }
        private int ContarRegistros()
        {
            Pelicula miPelicula = new Pelicula();
            int intContador = 0;
            try
            {
                miArchivo.AbrirEnModoLectura();
                while (!miArchivo.FinArchivo)
                {
                    miPelicula = miArchivo.LeerObjeto();
                    intContador++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                miArchivo.Cerrar();
            }
            return (intContador);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Desea borrar el archivo?", "borrar archivo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                miArchivo.EliminarArchivo();
            }
             
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_I_Archivos
{
    public partial class Form1 : Form
    {
        ArchivoSecuencialSerealizadoBinario<VideoJuego> miArchivo = new ArchivoSecuencialSerealizadoBinario<VideoJuego>("c:\\Datos\\Archivo.dat");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VideoJuego miVideoJuego = new VideoJuego();
            try
            {
                miVideoJuego.Nombre = txtNombre.Text;
                miVideoJuego.CantidadDeJugadores = int.Parse(txtCantidadDeJugadores.Text);
                miVideoJuego.Precio = double.Parse(txtPrecio.Text);
                miVideoJuego.Clasificacion =char.Parse(txtClasificacion.Text);
                if (radSi.Checked)
                {
                    miVideoJuego.VersionEspecial = true;
                }
                if (radNo.Checked)
                {
                    miVideoJuego.VersionEspecial = false;
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
                miArchivo.GrabarObjeto(miVideoJuego);
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
            VideoJuego miVideoJuego = new VideoJuego();
            dtgViedoJuego.Rows.Clear();
            try
            {
                miArchivo.AbrirEnModoLectura(); 
                while (!miArchivo.FinArchivo)
                {
                    miVideoJuego = miArchivo.LeerObjeto();
                    dtgViedoJuego.Rows.Add(miVideoJuego.Nombre.ToString(), miVideoJuego.CantidadDeJugadores, miVideoJuego.VersionEspecial, miVideoJuego.Estreno, miVideoJuego.Precio, miVideoJuego.Clasificacion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtNombre.Text = "";
                txtCantidadDeJugadores.Text = "";
                radSi.Text = "";
                radNo.Text = "";
                dtmEstreno.Text = "";
                txtPrecio.Text = "";
                txtClasificacion.Text = "";
            }
        }

        private int ContarRegistros()
        {
            VideoJuego miVideoJuego = new VideoJuego();
            int intContador = 0;
            try
            {
                miArchivo.AbrirEnModoLectura(); 
                while (!miArchivo.FinArchivo)
                { 
                    miVideoJuego = miArchivo.LeerObjeto(); 
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

        private void dtgViedoJuego_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgViedoJuego.Columns.Add("Nombre", "Nombre");
            dtgViedoJuego.Columns.Add("Cantidad De Jugadores", "Cantidad De Jugadores");
            dtgViedoJuego.Columns.Add("Version Especial", "Version Especial");
            dtgViedoJuego.Columns.Add("Estreno", "Estreno");
            dtgViedoJuego.Columns.Add("Precio", "Precio");
            dtgViedoJuego.Columns.Add("Clasificación", "Clasificación");
            dtgViedoJuego.AllowUserToAddRows = false;
            dtgViedoJuego.AllowUserToDeleteRows = false;
            dtgViedoJuego.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgViedoJuego.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgViedoJuego.MultiSelect = false;
            dtgViedoJuego.ReadOnly = true;
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Desea salir de la aplicacion?", "Salir del Programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;

namespace Tarea_I_Archivos
{
    public partial class Form1 : Form
    {
        private readonly ArchivoSecuencialSerealizadoBinario<VideoJuego> miArchivo =
            new ArchivoSecuencialSerealizadoBinario<VideoJuego>("C:\\Datos\\Archivo.dat");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var miVideoJuego = new VideoJuego();
            try
            {
                miVideoJuego.Nombre = txtNombre.Text;
                miVideoJuego.CantidadDeJugadores = int.Parse(txtCantidadDeJugadores.Text);
                if (chkVersionEspecial.Checked)
                    miVideoJuego.VersionEspecial = true;
                miVideoJuego.Precio = double.Parse(txtPrecio.Text);
                miVideoJuego.Clasificacion = char.Parse(txtClasificacion.Text);
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
                    dtgViedoJuego.Rows.Add(miVideoJuego.Nombre, miVideoJuego.CantidadDeJugadores,
                        miVideoJuego.VersionEspecial, miVideoJuego.Estreno.ToShortDateString(),
                        miVideoJuego.Precio.ToString("C"), miVideoJuego.Clasificacion);
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
                chkVersionEspecial.Checked = false;
                dtmEstreno.Text = "";
                txtPrecio.Text = "";
                txtClasificacion.Text = "";
            }
        }

        private int ContarRegistros()
        {
            var miVideoJuego = new VideoJuego();
            var intContador = 0;
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

            return intContador;
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
            Opcion = MessageBox.Show("¿Desea salir de la aplicacion?", "Salir del Programa", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK) Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("¿Está seguro de que desea eliminar el archivo?", "Eliminar Archivo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                miArchivo.EliminarArchivo();
                dtgViedoJuego.Rows.Clear();

                MessageBox.Show("Archivo eliminado correctamente", "Eliminar archivo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
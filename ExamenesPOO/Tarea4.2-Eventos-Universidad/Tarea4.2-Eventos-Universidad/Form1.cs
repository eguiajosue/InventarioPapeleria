using System;
using System.ComponentModel;
using System.Net.Mail;
using System.Windows.Forms;

namespace Tarea4._2_Eventos_Universidad
{
    public partial class Form1 : Form
    {
        private readonly Universidad miUniversidad = new Universidad();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void MetodoGestor(object sender, PropertyChangedEventArgs e)
        {
            MessageBox.Show("Se ha cambiado el valor de " + e.PropertyName);
        }

        private void btnCapturarUniversidad_Click(object sender, EventArgs e)
        {
            try
            {
                miUniversidad.PropertyChanged += MetodoGestor;
                miUniversidad.Nombre = txtNombreUniversidad.Text;
                miUniversidad.CostoColegiatura = double.Parse(txtCostoColegiatura.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var miMensaje = new MailMessage();
            try
            {
                miMensaje.Subject = "Aviso en cambio de colegiatura";
                miMensaje.To.Add(new MailAddress(txtDireccionDestinatario.Text));
                miMensaje.From = new MailAddress(txtDireccion.Text, txtNombre.Text);
                miMensaje.Body =
                    $"Se le informa que la universidad \"{miUniversidad.Nombre}\" ha cambiado su costo de colegiatura, el nuevo costo es de: {miUniversidad.CostoColegiatura.ToString("C")}";
                string strDireccionServidor;
                int intPuerto;
                DetectarDireccionServidor(out strDireccionServidor, out intPuerto);
                new CorreoElectronico(strDireccionServidor, intPuerto, txtDireccion.Text, txtContraseña.Text)
                    .Enviar(miMensaje);
            }
            catch (Exception ex)
            {
                var num = (int)MessageBox.Show(ex.Message, "ERROR AL INTENTAR ENVIAR EL CORREO ELECTRÓNICO",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            var num1 = (int)MessageBox.Show("Correo electrónico enviado correctamente !!!");
        }


        private void DetectarDireccionServidor(out string strDireccionServidor, out int intPuerto)
        {
            switch (cboNombreServidor.Text)
            {
                case "Hotmail":
                    intPuerto = 25;
                    strDireccionServidor = "smtp.live.com";
                    break;
                case "Yahoo !":
                    intPuerto = 587;
                    strDireccionServidor = "smtp.yahoo.com";
                    break;
                case "Gmail":
                    intPuerto = 25;
                    strDireccionServidor = "smtp.gmail.com";
                    break;
                default:
                    throw new Exception("Servidor desconocido");
            }
        }
    }
}
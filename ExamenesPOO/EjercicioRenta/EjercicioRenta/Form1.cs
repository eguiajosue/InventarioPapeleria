using System;
using System.Windows.Forms;

namespace EjercicioRenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Boton para crear un nuevo autobus
        private void btnCapturarAutobus_Click(object sender, EventArgs e)
        {
            // Se crea una excepcion en caso de que se produzca un error
            try
            {
                // Se crea el objeto miAutobus de tipo Autobus
                Autobus miAutobus = new Autobus();

                // Se le asigna a cada una de las propiedades del objeto los datos ingresados en los controles
                miAutobus.Placa = txtPlacasAutobus.Text;
                miAutobus.Alquilado = chkAlquiladoAutobus.Checked;
                miAutobus.PrecioKilometro = double.Parse(txtPrecioKm.Text);
                miAutobus.KilometroInicial = double.Parse(txtCantKmR.Text);
                miAutobus.KilometroFinal = double.Parse(txtCantKmD.Text);

                // Se crea una condicion para que en caso de que no se capture algun dato, marque el error
                if (txtPlacasAutobus.Text == "" && txtCantKmR.Text == "" && txtCantKmD.Text == "")
                    MessageBox.Show("Favor de no dejar los campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // De lo contrario, los datos se agregarán al DataGridView
                    dtgAutobuses.Rows.Add(miAutobus.Placa, miAutobus.Alquilado, miAutobus.PrecioKilometro, miAutobus.KilometroInicial,
                        miAutobus.KilometroFinal);

                    // Se muestran los datos del objeto recien creado en un MessageBox
                    MessageBox.Show("Los datos del autobus han sido capturados" + "\nPlacas: " + miAutobus.Placa +
                        "\nPrecio por Kilometro: " + miAutobus.PrecioKilometro + "\nKilometros al rentarse: " +
                        miAutobus.KilometroInicial + "\nKilometros al final del viaje: " + miAutobus.KilometroFinal,
                        "Autobus");
                }
                    
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

            // Se realiza un ciclo foreach para que recorra cada control dentro del GroupBox para que se limpien
            foreach( Control m in grpDatosAutobus.Controls)
            {
                if(m is TextBox)
                {
                    m.Text = "";
                }
            }
            chkAlquiladoAutobus.Checked = false;
        }

        private void btnDevolverAutobus_Click(object sender, EventArgs e)
        {
            // Para devolver el objeto seleccionado dentro de del DataGridView se crea un objeto "temporal" donde los datos de la fila seleccinada dentro del DGV se guardan en cada una de las propiedades del objeto
            Autobus autobusSeleccionado = new Autobus();
            autobusSeleccionado.Placa = dtgAutobuses.CurrentRow.Cells[0].Value.ToString();
            autobusSeleccionado.PrecioKilometro = int.Parse(dtgAutobuses.CurrentRow.Cells[2].Value.ToString());
            autobusSeleccionado.KilometroInicial = int.Parse(dtgAutobuses.CurrentRow.Cells[3].Value.ToString());
            autobusSeleccionado.KilometroFinal = int.Parse(dtgAutobuses.CurrentRow.Cells[4].Value.ToString());
            // Al momento de que se se devuelve un objeto, su propiedad Alquilado pasa a ser falsa
            autobusSeleccionado.Alquilado = false;
            // Se devuelve el Importe del objeto
            MessageBox.Show( "El autobus ha sido devuelto, el total a pagar de la renta es de: $" + autobusSeleccionado.CalcularImporte(),"Renta");

            dtgAutobuses.Rows.Remove(dtgAutobuses.CurrentRow);
            dtgAutobuses.Rows.Add(autobusSeleccionado.Placa, false, autobusSeleccionado.PrecioKilometro, autobusSeleccionado.KilometroInicial,
                autobusSeleccionado.KilometroFinal);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Se crean las columnas del DataGridView 
            dtgAutobuses.Columns.Add("placas", "No. Placa");
            dtgAutobuses.Columns.Add("alquilado", "¿Está alquilado?");
            dtgAutobuses.Columns.Add("precioKM", "Precio por KM");
            dtgAutobuses.Columns.Add("kmInicial", "Kilometros cuando se renta");
            dtgAutobuses.Columns.Add("kmFinal", "Kilometros cuando se devuelve");
            dtgAutobuses.ReadOnly = true;
            dtgAutobuses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgAutobuses.MultiSelect = false;
            dtgAutobuses.AllowUserToResizeColumns = false;
            dtgAutobuses.AllowUserToAddRows = false;
            dtgAutobuses.AllowUserToDeleteRows = false;
            dtgAutobuses.AllowUserToOrderColumns = false;
            dtgAutobuses.AllowUserToResizeRows = false;

            dtgTractores.Columns.Add("placas", "No. Placa");
            dtgTractores.Columns.Add("alquilado", "¿Está alquilado?");
            dtgTractores.Columns.Add("precioDia", "Precio por Dia");
            dtgTractores.Columns.Add("FechaInicial", "Fecha de Renta");
            dtgTractores.Columns.Add("FechaFinal", "Fecha Devuelta");
            dtgTractores.ReadOnly = true;
            dtgTractores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgTractores.MultiSelect = false;
            dtgTractores.AllowUserToResizeColumns = false;
            dtgTractores.AllowUserToAddRows = false;
            dtgTractores.AllowUserToDeleteRows = false;
            dtgTractores.AllowUserToOrderColumns = false;
            dtgTractores.AllowUserToResizeRows = false;
        }
        private void btnCapturarTractor_Click(object sender, EventArgs e)
        {
            try
            {
                Tractor miTractor = new Tractor();

                miTractor.Placa = txtPlacasTractor.Text;
                miTractor.PrecioPorDia = double.Parse(txtPrecioDia.Text);
                miTractor.FechaInicial = dtmFechaRenta.Value; 
                miTractor.FechaFinal = dtmFechaDevolucion.Value; 

                if (txtPlacasTractor.Text == "" && txtPrecioDia.Text == "")
                    MessageBox.Show("Favor de no dejar los campos en blanco");
                else
                {
                    dtgTractores.Rows.Add(miTractor.Placa, miTractor.Alquilado, miTractor.PrecioPorDia, miTractor.FechaInicial,miTractor.FechaFinal);
                    MessageBox.Show("Los datos del tractor han sido capturados" + "\nPlacas: " + miTractor.Placa +
                        "\nPrecio por Día: " + miTractor.PrecioPorDia + "\nFecha de renta: " +
                        miTractor.FechaInicial + "\nFecha de devolución: " + miTractor.FechaFinal,
                        "Tractor");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            foreach (Control m in grpDatosTractor.Controls)
            {
                if (m is TextBox)
                {
                    m.Text = "";
                }
            }
            chkAlquiladoTractor.Checked = false;
        }

        private void btnDevolverTractor_Click(object sender, EventArgs e)
        {
            Tractor tractorSeleccionado = new Tractor();
            tractorSeleccionado.Placa = dtgTractores.CurrentRow.Cells[0].Value.ToString();
            tractorSeleccionado.PrecioPorDia = int.Parse(dtgTractores.CurrentRow.Cells[2].Value.ToString());
            tractorSeleccionado.FechaInicial = DateTime.Parse(dtgTractores.CurrentRow.Cells[3].Value.ToString());
            tractorSeleccionado.FechaFinal = DateTime.Parse(dtgTractores.CurrentRow.Cells[4].Value.ToString());
            tractorSeleccionado.Alquilado = false;

            chkAlquiladoTractor.Checked = false;
            MessageBox.Show("El tractor ha sido devuelto, el total a pagar de la renta es de: $" + tractorSeleccionado.CalcularImporte(),"Renta");

            dtgTractores.Rows.Remove(dtgTractores.CurrentRow);
            dtgTractores.Rows.Add(tractorSeleccionado.Placa, false, tractorSeleccionado.PrecioPorDia, tractorSeleccionado.FechaInicial,
                tractorSeleccionado.FechaFinal);
        }

        // CellContentClick sirve para que al momento de dar click sobre una fila, los datos pasen a los controles del groupbox correspondiente
        private void dtgAutobuses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlacasAutobus.Text = dtgAutobuses.CurrentRow.Cells[0].Value.ToString();
            txtPrecioKm.Text = dtgAutobuses.CurrentRow.Cells[2].Value.ToString();
            txtCantKmR.Text = dtgAutobuses.CurrentRow.Cells[3].Value.ToString();
            txtCantKmD.Text = dtgAutobuses.CurrentRow.Cells[4].Value.ToString();
        }

        private void dtgTractores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlacasTractor.Text = dtgTractores.CurrentRow.Cells[0].Value.ToString();
            txtPrecioDia.Text = dtgTractores.CurrentRow.Cells[2].Value.ToString();
            dtmFechaRenta.Text = dtgTractores.CurrentRow.Cells[3].Value.ToString();
            dtmFechaDevolucion.Text = dtgTractores.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
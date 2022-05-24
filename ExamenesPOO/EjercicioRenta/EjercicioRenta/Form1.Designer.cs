namespace EjercicioRenta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgAutobuses = new System.Windows.Forms.DataGridView();
            this.btnCapturarAutobus = new System.Windows.Forms.Button();
            this.txtCantKmD = new System.Windows.Forms.TextBox();
            this.lblCantKmD = new System.Windows.Forms.Label();
            this.txtCantKmR = new System.Windows.Forms.TextBox();
            this.lblCantKmR = new System.Windows.Forms.Label();
            this.txtPrecioKm = new System.Windows.Forms.TextBox();
            this.lblPrecioKm = new System.Windows.Forms.Label();
            this.btnDevolverAutobus = new System.Windows.Forms.Button();
            this.chkAlquiladoAutobus = new System.Windows.Forms.CheckBox();
            this.txtPlacasAutobus = new System.Windows.Forms.TextBox();
            this.lblPlacasAutobus = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgTractores = new System.Windows.Forms.DataGridView();
            this.btnCapturarTractor = new System.Windows.Forms.Button();
            this.dtmFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.dtmFechaRenta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRenta = new System.Windows.Forms.Label();
            this.txtPrecioDia = new System.Windows.Forms.TextBox();
            this.lblPrecioDia = new System.Windows.Forms.Label();
            this.btnDevolverTractor = new System.Windows.Forms.Button();
            this.chkAlquiladoTractor = new System.Windows.Forms.CheckBox();
            this.lblPlacasTractor = new System.Windows.Forms.Label();
            this.txtPlacasTractor = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpDatosAutobus = new System.Windows.Forms.GroupBox();
            this.grpDatosTractor = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAutobuses)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTractores)).BeginInit();
            this.grpDatosAutobus.SuspendLayout();
            this.grpDatosTractor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(14, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(845, 354);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.grpDatosAutobus);
            this.tabPage1.Controls.Add(this.dtgAutobuses);
            this.tabPage1.Controls.Add(this.btnCapturarAutobus);
            this.tabPage1.Controls.Add(this.btnDevolverAutobus);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(837, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Autobus";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgAutobuses
            // 
            this.dtgAutobuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAutobuses.Location = new System.Drawing.Point(308, 7);
            this.dtgAutobuses.Name = "dtgAutobuses";
            this.dtgAutobuses.Size = new System.Drawing.Size(522, 311);
            this.dtgAutobuses.TabIndex = 11;
            this.dtgAutobuses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAutobuses_CellContentClick);
            // 
            // btnCapturarAutobus
            // 
            this.btnCapturarAutobus.Location = new System.Drawing.Point(29, 241);
            this.btnCapturarAutobus.Name = "btnCapturarAutobus";
            this.btnCapturarAutobus.Size = new System.Drawing.Size(116, 55);
            this.btnCapturarAutobus.TabIndex = 10;
            this.btnCapturarAutobus.Text = "Capturar Informacion";
            this.btnCapturarAutobus.UseVisualStyleBackColor = true;
            this.btnCapturarAutobus.Click += new System.EventHandler(this.btnCapturarAutobus_Click);
            // 
            // txtCantKmD
            // 
            this.txtCantKmD.Location = new System.Drawing.Point(20, 199);
            this.txtCantKmD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantKmD.Name = "txtCantKmD";
            this.txtCantKmD.Size = new System.Drawing.Size(116, 22);
            this.txtCantKmD.TabIndex = 9;
            // 
            // lblCantKmD
            // 
            this.lblCantKmD.AutoSize = true;
            this.lblCantKmD.Location = new System.Drawing.Point(17, 179);
            this.lblCantKmD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantKmD.Name = "lblCantKmD";
            this.lblCantKmD.Size = new System.Drawing.Size(225, 16);
            this.lblCantKmD.TabIndex = 8;
            this.lblCantKmD.Text = "Cantidad de km cuando se devuelve";
            // 
            // txtCantKmR
            // 
            this.txtCantKmR.Location = new System.Drawing.Point(20, 150);
            this.txtCantKmR.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantKmR.Name = "txtCantKmR";
            this.txtCantKmR.Size = new System.Drawing.Size(116, 22);
            this.txtCantKmR.TabIndex = 7;
            // 
            // lblCantKmR
            // 
            this.lblCantKmR.AutoSize = true;
            this.lblCantKmR.Location = new System.Drawing.Point(17, 129);
            this.lblCantKmR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantKmR.Name = "lblCantKmR";
            this.lblCantKmR.Size = new System.Drawing.Size(199, 16);
            this.lblCantKmR.TabIndex = 6;
            this.lblCantKmR.Text = "Cantidad de km cuando se renta";
            // 
            // txtPrecioKm
            // 
            this.txtPrecioKm.Location = new System.Drawing.Point(20, 97);
            this.txtPrecioKm.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioKm.Name = "txtPrecioKm";
            this.txtPrecioKm.Size = new System.Drawing.Size(116, 22);
            this.txtPrecioKm.TabIndex = 5;
            // 
            // lblPrecioKm
            // 
            this.lblPrecioKm.AutoSize = true;
            this.lblPrecioKm.Location = new System.Drawing.Point(17, 76);
            this.lblPrecioKm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioKm.Name = "lblPrecioKm";
            this.lblPrecioKm.Size = new System.Drawing.Size(89, 16);
            this.lblPrecioKm.TabIndex = 4;
            this.lblPrecioKm.Text = "Precio por Km";
            // 
            // btnDevolverAutobus
            // 
            this.btnDevolverAutobus.Location = new System.Drawing.Point(153, 241);
            this.btnDevolverAutobus.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevolverAutobus.Name = "btnDevolverAutobus";
            this.btnDevolverAutobus.Size = new System.Drawing.Size(121, 55);
            this.btnDevolverAutobus.TabIndex = 3;
            this.btnDevolverAutobus.Text = "Devolver Autobus";
            this.btnDevolverAutobus.UseVisualStyleBackColor = true;
            this.btnDevolverAutobus.Click += new System.EventHandler(this.btnDevolverAutobus_Click);
            // 
            // chkAlquiladoAutobus
            // 
            this.chkAlquiladoAutobus.AutoSize = true;
            this.chkAlquiladoAutobus.Location = new System.Drawing.Point(144, 47);
            this.chkAlquiladoAutobus.Margin = new System.Windows.Forms.Padding(4);
            this.chkAlquiladoAutobus.Name = "chkAlquiladoAutobus";
            this.chkAlquiladoAutobus.Size = new System.Drawing.Size(121, 20);
            this.chkAlquiladoAutobus.TabIndex = 2;
            this.chkAlquiladoAutobus.Text = "¿Está alquilado?";
            this.chkAlquiladoAutobus.UseVisualStyleBackColor = true;
            // 
            // txtPlacasAutobus
            // 
            this.txtPlacasAutobus.Location = new System.Drawing.Point(20, 43);
            this.txtPlacasAutobus.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlacasAutobus.Name = "txtPlacasAutobus";
            this.txtPlacasAutobus.Size = new System.Drawing.Size(116, 22);
            this.txtPlacasAutobus.TabIndex = 1;
            // 
            // lblPlacasAutobus
            // 
            this.lblPlacasAutobus.AutoSize = true;
            this.lblPlacasAutobus.Location = new System.Drawing.Point(17, 23);
            this.lblPlacasAutobus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlacasAutobus.Name = "lblPlacasAutobus";
            this.lblPlacasAutobus.Size = new System.Drawing.Size(46, 16);
            this.lblPlacasAutobus.TabIndex = 0;
            this.lblPlacasAutobus.Text = "Placas";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.grpDatosTractor);
            this.tabPage2.Controls.Add(this.dtgTractores);
            this.tabPage2.Controls.Add(this.btnCapturarTractor);
            this.tabPage2.Controls.Add(this.btnDevolverTractor);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(837, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tractor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgTractores
            // 
            this.dtgTractores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTractores.Location = new System.Drawing.Point(290, 7);
            this.dtgTractores.Name = "dtgTractores";
            this.dtgTractores.Size = new System.Drawing.Size(540, 311);
            this.dtgTractores.TabIndex = 15;
            this.dtgTractores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTractores_CellContentClick);
            // 
            // btnCapturarTractor
            // 
            this.btnCapturarTractor.Location = new System.Drawing.Point(27, 262);
            this.btnCapturarTractor.Name = "btnCapturarTractor";
            this.btnCapturarTractor.Size = new System.Drawing.Size(115, 43);
            this.btnCapturarTractor.TabIndex = 14;
            this.btnCapturarTractor.Text = "Capturar Informacion";
            this.btnCapturarTractor.UseVisualStyleBackColor = true;
            this.btnCapturarTractor.Click += new System.EventHandler(this.btnCapturarTractor_Click);
            // 
            // dtmFechaDevolucion
            // 
            this.dtmFechaDevolucion.Location = new System.Drawing.Point(5, 211);
            this.dtmFechaDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.dtmFechaDevolucion.Name = "dtmFechaDevolucion";
            this.dtmFechaDevolucion.Size = new System.Drawing.Size(246, 22);
            this.dtmFechaDevolucion.TabIndex = 13;
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(4, 190);
            this.lblFechaDevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(133, 16);
            this.lblFechaDevolucion.TabIndex = 12;
            this.lblFechaDevolucion.Text = "Fecha de devolucion";
            // 
            // dtmFechaRenta
            // 
            this.dtmFechaRenta.Location = new System.Drawing.Point(7, 152);
            this.dtmFechaRenta.Margin = new System.Windows.Forms.Padding(4);
            this.dtmFechaRenta.Name = "dtmFechaRenta";
            this.dtmFechaRenta.Size = new System.Drawing.Size(246, 22);
            this.dtmFechaRenta.TabIndex = 11;
            // 
            // lblFechaRenta
            // 
            this.lblFechaRenta.AutoSize = true;
            this.lblFechaRenta.Location = new System.Drawing.Point(5, 131);
            this.lblFechaRenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaRenta.Name = "lblFechaRenta";
            this.lblFechaRenta.Size = new System.Drawing.Size(96, 16);
            this.lblFechaRenta.TabIndex = 10;
            this.lblFechaRenta.Text = "Fecha de renta";
            // 
            // txtPrecioDia
            // 
            this.txtPrecioDia.Location = new System.Drawing.Point(7, 97);
            this.txtPrecioDia.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioDia.Name = "txtPrecioDia";
            this.txtPrecioDia.Size = new System.Drawing.Size(116, 22);
            this.txtPrecioDia.TabIndex = 9;
            // 
            // lblPrecioDia
            // 
            this.lblPrecioDia.AutoSize = true;
            this.lblPrecioDia.Location = new System.Drawing.Point(4, 77);
            this.lblPrecioDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioDia.Name = "lblPrecioDia";
            this.lblPrecioDia.Size = new System.Drawing.Size(90, 16);
            this.lblPrecioDia.TabIndex = 8;
            this.lblPrecioDia.Text = "Precio por dia";
            // 
            // btnDevolverTractor
            // 
            this.btnDevolverTractor.Location = new System.Drawing.Point(149, 262);
            this.btnDevolverTractor.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevolverTractor.Name = "btnDevolverTractor";
            this.btnDevolverTractor.Size = new System.Drawing.Size(123, 43);
            this.btnDevolverTractor.TabIndex = 7;
            this.btnDevolverTractor.Text = "Devolver Tractor";
            this.btnDevolverTractor.UseVisualStyleBackColor = true;
            this.btnDevolverTractor.Click += new System.EventHandler(this.btnDevolverTractor_Click);
            // 
            // chkAlquiladoTractor
            // 
            this.chkAlquiladoTractor.AutoSize = true;
            this.chkAlquiladoTractor.Location = new System.Drawing.Point(130, 47);
            this.chkAlquiladoTractor.Margin = new System.Windows.Forms.Padding(4);
            this.chkAlquiladoTractor.Name = "chkAlquiladoTractor";
            this.chkAlquiladoTractor.Size = new System.Drawing.Size(121, 20);
            this.chkAlquiladoTractor.TabIndex = 6;
            this.chkAlquiladoTractor.Text = "¿Está alquilado?";
            this.chkAlquiladoTractor.UseVisualStyleBackColor = true;
            // 
            // lblPlacasTractor
            // 
            this.lblPlacasTractor.AutoSize = true;
            this.lblPlacasTractor.Location = new System.Drawing.Point(3, 24);
            this.lblPlacasTractor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlacasTractor.Name = "lblPlacasTractor";
            this.lblPlacasTractor.Size = new System.Drawing.Size(46, 16);
            this.lblPlacasTractor.TabIndex = 4;
            this.lblPlacasTractor.Text = "Placas";
            // 
            // txtPlacasTractor
            // 
            this.txtPlacasTractor.Location = new System.Drawing.Point(7, 43);
            this.txtPlacasTractor.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlacasTractor.Name = "txtPlacasTractor";
            this.txtPlacasTractor.Size = new System.Drawing.Size(116, 22);
            this.txtPlacasTractor.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(760, 373);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 28);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpDatosAutobus
            // 
            this.grpDatosAutobus.Controls.Add(this.txtCantKmD);
            this.grpDatosAutobus.Controls.Add(this.lblPlacasAutobus);
            this.grpDatosAutobus.Controls.Add(this.txtPlacasAutobus);
            this.grpDatosAutobus.Controls.Add(this.chkAlquiladoAutobus);
            this.grpDatosAutobus.Controls.Add(this.lblCantKmD);
            this.grpDatosAutobus.Controls.Add(this.lblPrecioKm);
            this.grpDatosAutobus.Controls.Add(this.txtCantKmR);
            this.grpDatosAutobus.Controls.Add(this.txtPrecioKm);
            this.grpDatosAutobus.Controls.Add(this.lblCantKmR);
            this.grpDatosAutobus.ForeColor = System.Drawing.SystemColors.Control;
            this.grpDatosAutobus.Location = new System.Drawing.Point(7, 7);
            this.grpDatosAutobus.Name = "grpDatosAutobus";
            this.grpDatosAutobus.Size = new System.Drawing.Size(267, 228);
            this.grpDatosAutobus.TabIndex = 12;
            this.grpDatosAutobus.TabStop = false;
            this.grpDatosAutobus.Text = "Datos del Autobus";
            // 
            // grpDatosTractor
            // 
            this.grpDatosTractor.Controls.Add(this.txtPrecioDia);
            this.grpDatosTractor.Controls.Add(this.txtPlacasTractor);
            this.grpDatosTractor.Controls.Add(this.lblPlacasTractor);
            this.grpDatosTractor.Controls.Add(this.dtmFechaDevolucion);
            this.grpDatosTractor.Controls.Add(this.chkAlquiladoTractor);
            this.grpDatosTractor.Controls.Add(this.lblFechaDevolucion);
            this.grpDatosTractor.Controls.Add(this.lblPrecioDia);
            this.grpDatosTractor.Controls.Add(this.dtmFechaRenta);
            this.grpDatosTractor.Controls.Add(this.lblFechaRenta);
            this.grpDatosTractor.Location = new System.Drawing.Point(7, 7);
            this.grpDatosTractor.Name = "grpDatosTractor";
            this.grpDatosTractor.Size = new System.Drawing.Size(265, 251);
            this.grpDatosTractor.TabIndex = 16;
            this.grpDatosTractor.TabStop = false;
            this.grpDatosTractor.Text = "Datos del Tractor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 411);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Rentas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAutobuses)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTractores)).EndInit();
            this.grpDatosAutobus.ResumeLayout(false);
            this.grpDatosAutobus.PerformLayout();
            this.grpDatosTractor.ResumeLayout(false);
            this.grpDatosTractor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkAlquiladoAutobus;
        private System.Windows.Forms.TextBox txtPlacasAutobus;
        private System.Windows.Forms.Label lblPlacasAutobus;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDevolverAutobus;
        private System.Windows.Forms.Button btnDevolverTractor;
        private System.Windows.Forms.CheckBox chkAlquiladoTractor;
        private System.Windows.Forms.Label lblPlacasTractor;
        private System.Windows.Forms.TextBox txtPlacasTractor;
        private System.Windows.Forms.TextBox txtCantKmD;
        private System.Windows.Forms.Label lblCantKmD;
        private System.Windows.Forms.TextBox txtCantKmR;
        private System.Windows.Forms.Label lblCantKmR;
        private System.Windows.Forms.TextBox txtPrecioKm;
        private System.Windows.Forms.Label lblPrecioKm;
        private System.Windows.Forms.DateTimePicker dtmFechaDevolucion;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.DateTimePicker dtmFechaRenta;
        private System.Windows.Forms.Label lblFechaRenta;
        private System.Windows.Forms.TextBox txtPrecioDia;
        private System.Windows.Forms.Label lblPrecioDia;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCapturarAutobus;
        private System.Windows.Forms.Button btnCapturarTractor;
        private System.Windows.Forms.DataGridView dtgAutobuses;
        private System.Windows.Forms.DataGridView dtgTractores;
        private System.Windows.Forms.GroupBox grpDatosAutobus;
        private System.Windows.Forms.GroupBox grpDatosTractor;
    }
}


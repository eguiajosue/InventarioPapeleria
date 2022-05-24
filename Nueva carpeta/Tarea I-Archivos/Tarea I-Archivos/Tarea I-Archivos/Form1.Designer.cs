namespace Tarea_I_Archivos
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
            this.grpDatosVideoJuego = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidadDeJugadores = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.dtmEstreno = new System.Windows.Forms.DateTimePicker();
            this.radSi = new System.Windows.Forms.RadioButton();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.dtgViedoJuego = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpDatosVideoJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViedoJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatosVideoJuego
            // 
            this.grpDatosVideoJuego.Controls.Add(this.radNo);
            this.grpDatosVideoJuego.Controls.Add(this.radSi);
            this.grpDatosVideoJuego.Controls.Add(this.dtmEstreno);
            this.grpDatosVideoJuego.Controls.Add(this.txtClasificacion);
            this.grpDatosVideoJuego.Controls.Add(this.txtPrecio);
            this.grpDatosVideoJuego.Controls.Add(this.txtCantidadDeJugadores);
            this.grpDatosVideoJuego.Controls.Add(this.txtNombre);
            this.grpDatosVideoJuego.Controls.Add(this.label6);
            this.grpDatosVideoJuego.Controls.Add(this.label5);
            this.grpDatosVideoJuego.Controls.Add(this.label4);
            this.grpDatosVideoJuego.Controls.Add(this.label3);
            this.grpDatosVideoJuego.Controls.Add(this.label2);
            this.grpDatosVideoJuego.Controls.Add(this.label1);
            this.grpDatosVideoJuego.Location = new System.Drawing.Point(93, 55);
            this.grpDatosVideoJuego.Name = "grpDatosVideoJuego";
            this.grpDatosVideoJuego.Size = new System.Drawing.Size(569, 228);
            this.grpDatosVideoJuego.TabIndex = 0;
            this.grpDatosVideoJuego.TabStop = false;
            this.grpDatosVideoJuego.Text = "Datos del Video Juego";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Juego";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Cuantos Jugadores Pueden Jugar?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "¿Cuenta Con Version Especial?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha De Lanzamiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Clasificacion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(290, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(273, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCantidadDeJugadores
            // 
            this.txtCantidadDeJugadores.Location = new System.Drawing.Point(290, 60);
            this.txtCantidadDeJugadores.Name = "txtCantidadDeJugadores";
            this.txtCantidadDeJugadores.Size = new System.Drawing.Size(69, 22);
            this.txtCantidadDeJugadores.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(290, 159);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(69, 22);
            this.txtPrecio.TabIndex = 8;
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(290, 194);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Size = new System.Drawing.Size(69, 22);
            this.txtClasificacion.TabIndex = 9;
            // 
            // dtmEstreno
            // 
            this.dtmEstreno.Location = new System.Drawing.Point(290, 123);
            this.dtmEstreno.Name = "dtmEstreno";
            this.dtmEstreno.Size = new System.Drawing.Size(200, 22);
            this.dtmEstreno.TabIndex = 10;
            // 
            // radSi
            // 
            this.radSi.AutoSize = true;
            this.radSi.Location = new System.Drawing.Point(290, 90);
            this.radSi.Name = "radSi";
            this.radSi.Size = new System.Drawing.Size(40, 20);
            this.radSi.TabIndex = 11;
            this.radSi.TabStop = true;
            this.radSi.Text = "Si";
            this.radSi.UseVisualStyleBackColor = true;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(400, 89);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(46, 20);
            this.radNo.TabIndex = 12;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // dtgViedoJuego
            // 
            this.dtgViedoJuego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViedoJuego.Location = new System.Drawing.Point(93, 322);
            this.dtgViedoJuego.Name = "dtgViedoJuego";
            this.dtgViedoJuego.RowHeadersWidth = 51;
            this.dtgViedoJuego.RowTemplate.Height = 24;
            this.dtgViedoJuego.Size = new System.Drawing.Size(569, 150);
            this.dtgViedoJuego.TabIndex = 1;
            this.dtgViedoJuego.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViedoJuego_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(687, 62);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(212, 58);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar VideoJuego";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(687, 142);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(212, 58);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(687, 222);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(212, 58);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 523);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgViedoJuego);
            this.Controls.Add(this.grpDatosVideoJuego);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDatosVideoJuego.ResumeLayout(false);
            this.grpDatosVideoJuego.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViedoJuego)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosVideoJuego;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radSi;
        private System.Windows.Forms.DateTimePicker dtmEstreno;
        private System.Windows.Forms.TextBox txtClasificacion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidadDeJugadores;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgViedoJuego;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
    }
}


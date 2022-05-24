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
            this.dtmEstreno = new System.Windows.Forms.DateTimePicker();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidadDeJugadores = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgViedoJuego = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkVersionEspecial = new System.Windows.Forms.CheckBox();
            this.grpDatosVideoJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViedoJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatosVideoJuego
            // 
            this.grpDatosVideoJuego.Controls.Add(this.chkVersionEspecial);
            this.grpDatosVideoJuego.Controls.Add(this.dtmEstreno);
            this.grpDatosVideoJuego.Controls.Add(this.txtClasificacion);
            this.grpDatosVideoJuego.Controls.Add(this.txtPrecio);
            this.grpDatosVideoJuego.Controls.Add(this.txtCantidadDeJugadores);
            this.grpDatosVideoJuego.Controls.Add(this.txtNombre);
            this.grpDatosVideoJuego.Controls.Add(this.label6);
            this.grpDatosVideoJuego.Controls.Add(this.label5);
            this.grpDatosVideoJuego.Controls.Add(this.label4);
            this.grpDatosVideoJuego.Controls.Add(this.label2);
            this.grpDatosVideoJuego.Controls.Add(this.label1);
            this.grpDatosVideoJuego.Location = new System.Drawing.Point(11, 11);
            this.grpDatosVideoJuego.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDatosVideoJuego.Name = "grpDatosVideoJuego";
            this.grpDatosVideoJuego.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDatosVideoJuego.Size = new System.Drawing.Size(238, 258);
            this.grpDatosVideoJuego.TabIndex = 0;
            this.grpDatosVideoJuego.TabStop = false;
            this.grpDatosVideoJuego.Text = "Datos del Video Juego";
            // 
            // dtmEstreno
            // 
            this.dtmEstreno.Location = new System.Drawing.Point(14, 115);
            this.dtmEstreno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmEstreno.Name = "dtmEstreno";
            this.dtmEstreno.Size = new System.Drawing.Size(206, 20);
            this.dtmEstreno.TabIndex = 10;
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(14, 190);
            this.txtClasificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Size = new System.Drawing.Size(206, 20);
            this.txtClasificacion.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(14, 152);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(206, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // txtCantidadDeJugadores
            // 
            this.txtCantidadDeJugadores.Location = new System.Drawing.Point(14, 78);
            this.txtCantidadDeJugadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidadDeJugadores.Name = "txtCantidadDeJugadores";
            this.txtCantidadDeJugadores.Size = new System.Drawing.Size(206, 20);
            this.txtCantidadDeJugadores.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(14, 41);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Clasificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha De Lanzamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Cuantos Jugadores Pueden Jugar?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Juego";
            // 
            // dtgViedoJuego
            // 
            this.dtgViedoJuego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViedoJuego.Location = new System.Drawing.Point(253, 11);
            this.dtgViedoJuego.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgViedoJuego.Name = "dtgViedoJuego";
            this.dtgViedoJuego.RowHeadersWidth = 51;
            this.dtgViedoJuego.RowTemplate.Height = 24;
            this.dtgViedoJuego.Size = new System.Drawing.Size(672, 403);
            this.dtgViedoJuego.TabIndex = 1;
            this.dtgViedoJuego.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViedoJuego_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(11, 273);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(238, 48);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar VideoJuego";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Location = new System.Drawing.Point(11, 325);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(238, 48);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(11, 381);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(238, 33);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkVersionEspecial
            // 
            this.chkVersionEspecial.AutoSize = true;
            this.chkVersionEspecial.Location = new System.Drawing.Point(45, 225);
            this.chkVersionEspecial.Name = "chkVersionEspecial";
            this.chkVersionEspecial.Size = new System.Drawing.Size(175, 17);
            this.chkVersionEspecial.TabIndex = 13;
            this.chkVersionEspecial.Text = "¿Cuenta Con Versión Especial?";
            this.chkVersionEspecial.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 425);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgViedoJuego);
            this.Controls.Add(this.grpDatosVideoJuego);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDatosVideoJuego.ResumeLayout(false);
            this.grpDatosVideoJuego.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViedoJuego)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosVideoJuego;
        private System.Windows.Forms.DateTimePicker dtmEstreno;
        private System.Windows.Forms.TextBox txtClasificacion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidadDeJugadores;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgViedoJuego;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkVersionEspecial;
    }
}


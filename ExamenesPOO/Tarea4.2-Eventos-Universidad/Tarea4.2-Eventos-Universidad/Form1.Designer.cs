namespace Tarea4._2_Eventos_Universidad
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpArticuloNuevo = new System.Windows.Forms.GroupBox();
            this.txtCostoColegiatura = new System.Windows.Forms.TextBox();
            this.lblCostoColegiatura = new System.Windows.Forms.Label();
            this.txtNombreUniversidad = new System.Windows.Forms.TextBox();
            this.lblNombreUniversidad = new System.Windows.Forms.Label();
            this.btnCapturarUniversidad = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpDatosRemitente = new System.Windows.Forms.GroupBox();
            this.cboNombreServidor = new System.Windows.Forms.ComboBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpDatosDestinatario = new System.Windows.Forms.GroupBox();
            this.txtDireccionDestinatario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpArticuloNuevo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpDatosRemitente.SuspendLayout();
            this.grpDatosDestinatario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(431, 278);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpArticuloNuevo);
            this.tabPage1.Controls.Add(this.btnCapturarUniversidad);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(423, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Universidad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpArticuloNuevo
            // 
            this.grpArticuloNuevo.Controls.Add(this.txtCostoColegiatura);
            this.grpArticuloNuevo.Controls.Add(this.lblCostoColegiatura);
            this.grpArticuloNuevo.Controls.Add(this.txtNombreUniversidad);
            this.grpArticuloNuevo.Controls.Add(this.lblNombreUniversidad);
            this.grpArticuloNuevo.Location = new System.Drawing.Point(9, 22);
            this.grpArticuloNuevo.Name = "grpArticuloNuevo";
            this.grpArticuloNuevo.Size = new System.Drawing.Size(408, 100);
            this.grpArticuloNuevo.TabIndex = 0;
            this.grpArticuloNuevo.TabStop = false;
            this.grpArticuloNuevo.Text = "Datos de la Universidad";
            // 
            // txtCostoColegiatura
            // 
            this.txtCostoColegiatura.Location = new System.Drawing.Point(111, 59);
            this.txtCostoColegiatura.Name = "txtCostoColegiatura";
            this.txtCostoColegiatura.Size = new System.Drawing.Size(190, 22);
            this.txtCostoColegiatura.TabIndex = 3;
            // 
            // lblCostoColegiatura
            // 
            this.lblCostoColegiatura.AutoSize = true;
            this.lblCostoColegiatura.Location = new System.Drawing.Point(19, 65);
            this.lblCostoColegiatura.Name = "lblCostoColegiatura";
            this.lblCostoColegiatura.Size = new System.Drawing.Size(79, 16);
            this.lblCostoColegiatura.TabIndex = 2;
            this.lblCostoColegiatura.Text = "Colegiatura:";
            // 
            // txtNombreUniversidad
            // 
            this.txtNombreUniversidad.Location = new System.Drawing.Point(111, 31);
            this.txtNombreUniversidad.Name = "txtNombreUniversidad";
            this.txtNombreUniversidad.Size = new System.Drawing.Size(190, 22);
            this.txtNombreUniversidad.TabIndex = 1;
            // 
            // lblNombreUniversidad
            // 
            this.lblNombreUniversidad.AutoSize = true;
            this.lblNombreUniversidad.Location = new System.Drawing.Point(19, 37);
            this.lblNombreUniversidad.Name = "lblNombreUniversidad";
            this.lblNombreUniversidad.Size = new System.Drawing.Size(59, 16);
            this.lblNombreUniversidad.TabIndex = 0;
            this.lblNombreUniversidad.Text = "Nombre:";
            // 
            // btnCapturarUniversidad
            // 
            this.btnCapturarUniversidad.Location = new System.Drawing.Point(9, 137);
            this.btnCapturarUniversidad.Name = "btnCapturarUniversidad";
            this.btnCapturarUniversidad.Size = new System.Drawing.Size(408, 46);
            this.btnCapturarUniversidad.TabIndex = 1;
            this.btnCapturarUniversidad.Text = "Capturar Universidad";
            this.btnCapturarUniversidad.UseVisualStyleBackColor = true;
            this.btnCapturarUniversidad.Click += new System.EventHandler(this.btnCapturarUniversidad_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpDatosRemitente);
            this.tabPage2.Controls.Add(this.grpDatosDestinatario);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(423, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuración Correo Eléctronico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpDatosRemitente
            // 
            this.grpDatosRemitente.Controls.Add(this.cboNombreServidor);
            this.grpDatosRemitente.Controls.Add(this.txtContraseña);
            this.grpDatosRemitente.Controls.Add(this.txtDireccion);
            this.grpDatosRemitente.Controls.Add(this.txtNombre);
            this.grpDatosRemitente.Controls.Add(this.label6);
            this.grpDatosRemitente.Controls.Add(this.label5);
            this.grpDatosRemitente.Controls.Add(this.label4);
            this.grpDatosRemitente.Controls.Add(this.label3);
            this.grpDatosRemitente.Location = new System.Drawing.Point(9, 19);
            this.grpDatosRemitente.Name = "grpDatosRemitente";
            this.grpDatosRemitente.Size = new System.Drawing.Size(397, 151);
            this.grpDatosRemitente.TabIndex = 3;
            this.grpDatosRemitente.TabStop = false;
            this.grpDatosRemitente.Text = "Datos del remitente";
            // 
            // cboNombreServidor
            // 
            this.cboNombreServidor.FormattingEnabled = true;
            this.cboNombreServidor.Items.AddRange(new object[] {
            "Hotmail",
            "Gmail",
            "Yahoo !"});
            this.cboNombreServidor.Location = new System.Drawing.Point(155, 115);
            this.cboNombreServidor.Name = "cboNombreServidor";
            this.cboNombreServidor.Size = new System.Drawing.Size(236, 24);
            this.cboNombreServidor.TabIndex = 7;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(155, 86);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(236, 22);
            this.txtContraseña.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(155, 57);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(236, 22);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Servidor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Direccion De Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // grpDatosDestinatario
            // 
            this.grpDatosDestinatario.Controls.Add(this.txtDireccionDestinatario);
            this.grpDatosDestinatario.Controls.Add(this.label7);
            this.grpDatosDestinatario.Location = new System.Drawing.Point(9, 177);
            this.grpDatosDestinatario.Name = "grpDatosDestinatario";
            this.grpDatosDestinatario.Size = new System.Drawing.Size(397, 69);
            this.grpDatosDestinatario.TabIndex = 4;
            this.grpDatosDestinatario.TabStop = false;
            this.grpDatosDestinatario.Text = "Datos Destinatario";
            // 
            // txtDireccionDestinatario
            // 
            this.txtDireccionDestinatario.Location = new System.Drawing.Point(155, 19);
            this.txtDireccionDestinatario.Name = "txtDireccionDestinatario";
            this.txtDireccionDestinatario.Size = new System.Drawing.Size(236, 22);
            this.txtDireccionDestinatario.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Direccion de Correo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 302);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpArticuloNuevo.ResumeLayout(false);
            this.grpArticuloNuevo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpDatosRemitente.ResumeLayout(false);
            this.grpDatosRemitente.PerformLayout();
            this.grpDatosDestinatario.ResumeLayout(false);
            this.grpDatosDestinatario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpArticuloNuevo;
        private System.Windows.Forms.TextBox txtCostoColegiatura;
        private System.Windows.Forms.Label lblCostoColegiatura;
        private System.Windows.Forms.TextBox txtNombreUniversidad;
        private System.Windows.Forms.Label lblNombreUniversidad;
        private System.Windows.Forms.Button btnCapturarUniversidad;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpDatosRemitente;
        private System.Windows.Forms.ComboBox cboNombreServidor;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpDatosDestinatario;
        private System.Windows.Forms.TextBox txtDireccionDestinatario;
        private System.Windows.Forms.Label label7;
    }
}


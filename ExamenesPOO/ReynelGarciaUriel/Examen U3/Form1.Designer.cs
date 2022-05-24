namespace Examen_U3
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
            this.grpDatosPaciente = new System.Windows.Forms.GroupBox();
            this.grpTipoDeTratamiento = new System.Windows.Forms.GroupBox();
            this.radMediastino = new System.Windows.Forms.RadioButton();
            this.radRespiradorArtificial = new System.Windows.Forms.RadioButton();
            this.txtCostoDeConsultaGeneral = new System.Windows.Forms.TextBox();
            this.lblCostoDeConsultaGeneral = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCaptuarar = new System.Windows.Forms.Button();
            this.btnMostrarMayor = new System.Windows.Forms.Button();
            this.btnCapturarotropaciente = new System.Windows.Forms.Button();
            this.grpDatosPaciente.SuspendLayout();
            this.grpTipoDeTratamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosPaciente
            // 
            this.grpDatosPaciente.Controls.Add(this.grpTipoDeTratamiento);
            this.grpDatosPaciente.Controls.Add(this.txtCostoDeConsultaGeneral);
            this.grpDatosPaciente.Controls.Add(this.lblCostoDeConsultaGeneral);
            this.grpDatosPaciente.Controls.Add(this.txtEdad);
            this.grpDatosPaciente.Controls.Add(this.lblEdad);
            this.grpDatosPaciente.Controls.Add(this.txtSexo);
            this.grpDatosPaciente.Controls.Add(this.lblSexo);
            this.grpDatosPaciente.Controls.Add(this.txtNombre);
            this.grpDatosPaciente.Controls.Add(this.lblNombre);
            this.grpDatosPaciente.Location = new System.Drawing.Point(58, 54);
            this.grpDatosPaciente.Name = "grpDatosPaciente";
            this.grpDatosPaciente.Size = new System.Drawing.Size(279, 371);
            this.grpDatosPaciente.TabIndex = 0;
            this.grpDatosPaciente.TabStop = false;
            this.grpDatosPaciente.Text = "Datos Paciente ";
            // 
            // grpTipoDeTratamiento
            // 
            this.grpTipoDeTratamiento.Controls.Add(this.radMediastino);
            this.grpTipoDeTratamiento.Controls.Add(this.radRespiradorArtificial);
            this.grpTipoDeTratamiento.Location = new System.Drawing.Point(22, 232);
            this.grpTipoDeTratamiento.Name = "grpTipoDeTratamiento";
            this.grpTipoDeTratamiento.Size = new System.Drawing.Size(200, 100);
            this.grpTipoDeTratamiento.TabIndex = 8;
            this.grpTipoDeTratamiento.TabStop = false;
            this.grpTipoDeTratamiento.Text = "tipoTratamiento";
            // 
            // radMediastino
            // 
            this.radMediastino.AutoSize = true;
            this.radMediastino.Checked = true;
            this.radMediastino.Location = new System.Drawing.Point(7, 49);
            this.radMediastino.Name = "radMediastino";
            this.radMediastino.Size = new System.Drawing.Size(94, 20);
            this.radMediastino.TabIndex = 1;
            this.radMediastino.TabStop = true;
            this.radMediastino.Text = "Mediastino";
            this.radMediastino.UseVisualStyleBackColor = true;
            // 
            // radRespiradorArtificial
            // 
            this.radRespiradorArtificial.AutoSize = true;
            this.radRespiradorArtificial.Location = new System.Drawing.Point(7, 22);
            this.radRespiradorArtificial.Name = "radRespiradorArtificial";
            this.radRespiradorArtificial.Size = new System.Drawing.Size(145, 20);
            this.radRespiradorArtificial.TabIndex = 0;
            this.radRespiradorArtificial.Text = "Respirador Artificial";
            this.radRespiradorArtificial.UseVisualStyleBackColor = true;
            // 
            // txtCostoDeConsultaGeneral
            // 
            this.txtCostoDeConsultaGeneral.Location = new System.Drawing.Point(122, 166);
            this.txtCostoDeConsultaGeneral.Name = "txtCostoDeConsultaGeneral";
            this.txtCostoDeConsultaGeneral.Size = new System.Drawing.Size(100, 22);
            this.txtCostoDeConsultaGeneral.TabIndex = 7;
            // 
            // lblCostoDeConsultaGeneral
            // 
            this.lblCostoDeConsultaGeneral.AutoSize = true;
            this.lblCostoDeConsultaGeneral.Location = new System.Drawing.Point(19, 166);
            this.lblCostoDeConsultaGeneral.Name = "lblCostoDeConsultaGeneral";
            this.lblCostoDeConsultaGeneral.Size = new System.Drawing.Size(97, 16);
            this.lblCostoDeConsultaGeneral.TabIndex = 6;
            this.lblCostoDeConsultaGeneral.Text = "Costo Consulta";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(122, 123);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 22);
            this.txtEdad.TabIndex = 5;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(19, 123);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(40, 16);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(122, 78);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 22);
            this.txtSexo.TabIndex = 3;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(19, 78);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 16);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnCaptuarar
            // 
            this.btnCaptuarar.Location = new System.Drawing.Point(384, 51);
            this.btnCaptuarar.Name = "btnCaptuarar";
            this.btnCaptuarar.Size = new System.Drawing.Size(139, 57);
            this.btnCaptuarar.TabIndex = 1;
            this.btnCaptuarar.Text = "Capturar Datos";
            this.btnCaptuarar.UseVisualStyleBackColor = true;
            this.btnCaptuarar.Click += new System.EventHandler(this.btnCaptuarar_Click);
            // 
            // btnMostrarMayor
            // 
            this.btnMostrarMayor.Location = new System.Drawing.Point(529, 51);
            this.btnMostrarMayor.Name = "btnMostrarMayor";
            this.btnMostrarMayor.Size = new System.Drawing.Size(139, 57);
            this.btnMostrarMayor.TabIndex = 2;
            this.btnMostrarMayor.Text = "Mostrar Mayor";
            this.btnMostrarMayor.UseVisualStyleBackColor = true;
            this.btnMostrarMayor.Click += new System.EventHandler(this.btnMostrarMayor_Click);
            // 
            // btnCapturarotropaciente
            // 
            this.btnCapturarotropaciente.Location = new System.Drawing.Point(384, 107);
            this.btnCapturarotropaciente.Name = "btnCapturarotropaciente";
            this.btnCapturarotropaciente.Size = new System.Drawing.Size(149, 47);
            this.btnCapturarotropaciente.TabIndex = 3;
            this.btnCapturarotropaciente.Text = "otro paciente";
            this.btnCapturarotropaciente.UseVisualStyleBackColor = true;
            this.btnCapturarotropaciente.Click += new System.EventHandler(this.btnCapturarotropaciente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 548);
            this.Controls.Add(this.btnCapturarotropaciente);
            this.Controls.Add(this.btnMostrarMayor);
            this.Controls.Add(this.btnCaptuarar);
            this.Controls.Add(this.grpDatosPaciente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpDatosPaciente.ResumeLayout(false);
            this.grpDatosPaciente.PerformLayout();
            this.grpTipoDeTratamiento.ResumeLayout(false);
            this.grpTipoDeTratamiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPaciente;
        private System.Windows.Forms.GroupBox grpTipoDeTratamiento;
        private System.Windows.Forms.RadioButton radMediastino;
        private System.Windows.Forms.RadioButton radRespiradorArtificial;
        private System.Windows.Forms.TextBox txtCostoDeConsultaGeneral;
        private System.Windows.Forms.Label lblCostoDeConsultaGeneral;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCaptuarar;
        private System.Windows.Forms.Button btnMostrarMayor;
        private System.Windows.Forms.Button btnCapturarotropaciente;
    }
}


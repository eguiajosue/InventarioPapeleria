﻿namespace E1Simulado.Formas
{
    partial class frmEjercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblCantidadKilometros = new System.Windows.Forms.Label();
            this.txtCantidadKilometros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(279, 286);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(100, 23);
            this.btnCapturar.TabIndex = 7;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(279, 321);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(100, 50);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir Kilometros a Millas";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblCantidadKilometros
            // 
            this.lblCantidadKilometros.AutoSize = true;
            this.lblCantidadKilometros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadKilometros.Location = new System.Drawing.Point(261, 229);
            this.lblCantidadKilometros.Name = "lblCantidadKilometros";
            this.lblCantidadKilometros.Size = new System.Drawing.Size(137, 13);
            this.lblCantidadKilometros.TabIndex = 5;
            this.lblCantidadKilometros.Text = "Cantidad de Kilometros";
            // 
            // txtCantidadKilometros
            // 
            this.txtCantidadKilometros.Location = new System.Drawing.Point(279, 254);
            this.txtCantidadKilometros.Name = "txtCantidadKilometros";
            this.txtCantidadKilometros.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadKilometros.TabIndex = 4;
            // 
            // frmEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(658, 601);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblCantidadKilometros);
            this.Controls.Add(this.txtCantidadKilometros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEjercicio2";
            this.Text = "frmEjercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblCantidadKilometros;
        private System.Windows.Forms.TextBox txtCantidadKilometros;
    }
}
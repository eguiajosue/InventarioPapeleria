namespace E1Simulado.Formas
{
    partial class frmEjercicio1
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
            this.txtCantidadLitros = new System.Windows.Forms.TextBox();
            this.lblCantidadLitros = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCantidadLitros
            // 
            this.txtCantidadLitros.Location = new System.Drawing.Point(279, 254);
            this.txtCantidadLitros.Name = "txtCantidadLitros";
            this.txtCantidadLitros.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadLitros.TabIndex = 0;
            // 
            // lblCantidadLitros
            // 
            this.lblCantidadLitros.AutoSize = true;
            this.lblCantidadLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadLitros.Location = new System.Drawing.Point(274, 229);
            this.lblCantidadLitros.Name = "lblCantidadLitros";
            this.lblCantidadLitros.Size = new System.Drawing.Size(110, 13);
            this.lblCantidadLitros.TabIndex = 1;
            this.lblCantidadLitros.Text = "Cantidad de Litros";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(279, 321);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(100, 50);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convertir Litros a Galones";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(279, 286);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(100, 23);
            this.btnCapturar.TabIndex = 3;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // frmEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(658, 601);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblCantidadLitros);
            this.Controls.Add(this.txtCantidadLitros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEjercicio1";
            this.Text = "frmEjercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidadLitros;
        private System.Windows.Forms.Label lblCantidadLitros;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnCapturar;
    }
}
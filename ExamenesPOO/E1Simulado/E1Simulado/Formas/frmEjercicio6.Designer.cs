namespace E1Simulado.Formas
{
    partial class frmEjercicio6
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
            this.btnCalcularBono = new System.Windows.Forms.Button();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.txtCantidadVentas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(250, 286);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(100, 23);
            this.btnCapturar.TabIndex = 7;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnCalcularBono
            // 
            this.btnCalcularBono.Location = new System.Drawing.Point(250, 321);
            this.btnCalcularBono.Name = "btnCalcularBono";
            this.btnCalcularBono.Size = new System.Drawing.Size(100, 50);
            this.btnCalcularBono.TabIndex = 6;
            this.btnCalcularBono.Text = "Calcular Bono";
            this.btnCalcularBono.UseVisualStyleBackColor = true;
            this.btnCalcularBono.Click += new System.EventHandler(this.btnCalcularBono_Click);
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.AutoSize = true;
            this.lblCantidadVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVentas.Location = new System.Drawing.Point(245, 229);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(112, 13);
            this.lblCantidadVentas.TabIndex = 5;
            this.lblCantidadVentas.Text = "Ventas Realizadas";
            // 
            // txtCantidadVentas
            // 
            this.txtCantidadVentas.Location = new System.Drawing.Point(250, 254);
            this.txtCantidadVentas.Name = "txtCantidadVentas";
            this.txtCantidadVentas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadVentas.TabIndex = 4;
            // 
            // frmEjercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnCalcularBono);
            this.Controls.Add(this.lblCantidadVentas);
            this.Controls.Add(this.txtCantidadVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEjercicio6";
            this.Text = "frmEjercicio6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnCalcularBono;
        private System.Windows.Forms.Label lblCantidadVentas;
        private System.Windows.Forms.TextBox txtCantidadVentas;
    }
}
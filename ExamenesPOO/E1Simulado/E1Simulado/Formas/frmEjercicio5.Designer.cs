namespace E1Simulado.Formas
{
    partial class frmEjercicio5
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
            this.btnCalcularVenta = new System.Windows.Forms.Button();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.lblCantidadPaletas = new System.Windows.Forms.Label();
            this.txtCantidadPaletas = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(239, 319);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(126, 23);
            this.btnCapturar.TabIndex = 11;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnCalcularVenta
            // 
            this.btnCalcularVenta.Location = new System.Drawing.Point(239, 354);
            this.btnCalcularVenta.Name = "btnCalcularVenta";
            this.btnCalcularVenta.Size = new System.Drawing.Size(126, 50);
            this.btnCalcularVenta.TabIndex = 10;
            this.btnCalcularVenta.Text = "Calcular Venta Diaria";
            this.btnCalcularVenta.UseVisualStyleBackColor = true;
            this.btnCalcularVenta.Click += new System.EventHandler(this.btnCalcularVenta_Click);
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.Location = new System.Drawing.Point(236, 197);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(129, 13);
            this.lblNombreVendedor.TabIndex = 9;
            this.lblNombreVendedor.Text = "Nombre del Vendedor";
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(239, 213);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(126, 20);
            this.txtNombreVendedor.TabIndex = 8;
            // 
            // lblCantidadPaletas
            // 
            this.lblCantidadPaletas.AutoSize = true;
            this.lblCantidadPaletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPaletas.Location = new System.Drawing.Point(236, 236);
            this.lblCantidadPaletas.Name = "lblCantidadPaletas";
            this.lblCantidadPaletas.Size = new System.Drawing.Size(121, 13);
            this.lblCantidadPaletas.TabIndex = 13;
            this.lblCantidadPaletas.Text = "Cantidad de Paletas";
            // 
            // txtCantidadPaletas
            // 
            this.txtCantidadPaletas.Location = new System.Drawing.Point(239, 252);
            this.txtCantidadPaletas.Name = "txtCantidadPaletas";
            this.txtCantidadPaletas.Size = new System.Drawing.Size(126, 20);
            this.txtCantidadPaletas.TabIndex = 12;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(236, 275);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(105, 13);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio por Paleta";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(239, 291);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(126, 20);
            this.txtPrecio.TabIndex = 14;
            // 
            // frmEjercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblCantidadPaletas);
            this.Controls.Add(this.txtCantidadPaletas);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnCalcularVenta);
            this.Controls.Add(this.lblNombreVendedor);
            this.Controls.Add(this.txtNombreVendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEjercicio5";
            this.Text = "frmEjercicio5";
            this.Load += new System.EventHandler(this.frmEjercicio5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnCalcularVenta;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.Label lblCantidadPaletas;
        private System.Windows.Forms.TextBox txtCantidadPaletas;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}
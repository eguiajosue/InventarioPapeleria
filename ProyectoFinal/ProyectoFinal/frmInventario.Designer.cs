namespace ProyectoFinal
{
    partial class frmInventario
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
            this.lstColecciones = new System.Windows.Forms.ListBox();
            this.dtgInventario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarPrenda = new System.Windows.Forms.Button();
            this.lstTiposPrenda = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // lstColecciones
            // 
            this.lstColecciones.FormattingEnabled = true;
            this.lstColecciones.Location = new System.Drawing.Point(12, 57);
            this.lstColecciones.Name = "lstColecciones";
            this.lstColecciones.Size = new System.Drawing.Size(92, 212);
            this.lstColecciones.TabIndex = 0;
            this.lstColecciones.Click += new System.EventHandler(this.lstColecciones_Click);
            // 
            // dtgInventario
            // 
            this.dtgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInventario.Location = new System.Drawing.Point(208, 57);
            this.dtgInventario.Name = "dtgInventario";
            this.dtgInventario.Size = new System.Drawing.Size(437, 212);
            this.dtgInventario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "I N V E N T A R I O";
            // 
            // btnAgregarPrenda
            // 
            this.btnAgregarPrenda.Location = new System.Drawing.Point(485, 19);
            this.btnAgregarPrenda.Name = "btnAgregarPrenda";
            this.btnAgregarPrenda.Size = new System.Drawing.Size(160, 32);
            this.btnAgregarPrenda.TabIndex = 3;
            this.btnAgregarPrenda.Text = "Nueva Prenda";
            this.btnAgregarPrenda.UseVisualStyleBackColor = true;
            this.btnAgregarPrenda.Click += new System.EventHandler(this.btnAgregarPrenda_Click);
            // 
            // lstTiposPrenda
            // 
            this.lstTiposPrenda.FormattingEnabled = true;
            this.lstTiposPrenda.Location = new System.Drawing.Point(110, 57);
            this.lstTiposPrenda.Name = "lstTiposPrenda";
            this.lstTiposPrenda.Size = new System.Drawing.Size(92, 212);
            this.lstTiposPrenda.TabIndex = 4;
            this.lstTiposPrenda.Click += new System.EventHandler(this.lstTiposPrenda_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 287);
            this.Controls.Add(this.lstTiposPrenda);
            this.Controls.Add(this.btnAgregarPrenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgInventario);
            this.Controls.Add(this.lstColecciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventario";
            this.Text = "frmInventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstColecciones;
        private System.Windows.Forms.DataGridView dtgInventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarPrenda;
        private System.Windows.Forms.ListBox lstTiposPrenda;
    }
}
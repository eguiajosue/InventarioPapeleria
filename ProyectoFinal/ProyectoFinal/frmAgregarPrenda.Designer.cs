namespace ProyectoFinal
{
    partial class frmAgregarPrenda
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
            this.cboColecciones = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cboTalla = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTipoPrenda = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregarNuevaPrenda = new System.Windows.Forms.Button();
            this.chkEstampado = new System.Windows.Forms.CheckBox();
            this.lblTipoMaterial = new System.Windows.Forms.Label();
            this.txtTipoMaterial = new System.Windows.Forms.TextBox();
            this.lblCantidadPiezas = new System.Windows.Forms.Label();
            this.txtCantidadPiezas = new System.Windows.Forms.TextBox();
            this.chkCierre = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboColecciones
            // 
            this.cboColecciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColecciones.FormattingEnabled = true;
            this.cboColecciones.Items.AddRange(new object[] {
            "Primavera",
            "Verano",
            "Otoño",
            "Invierno"});
            this.cboColecciones.Location = new System.Drawing.Point(12, 30);
            this.cboColecciones.Name = "cboColecciones";
            this.cboColecciones.Size = new System.Drawing.Size(206, 21);
            this.cboColecciones.TabIndex = 0;
            this.cboColecciones.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTipoPrenda);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.lblTalla);
            this.groupBox1.Controls.Add(this.lblColor);
            this.groupBox1.Controls.Add(this.cboTalla);
            this.groupBox1.Controls.Add(this.txtCantidadPiezas);
            this.groupBox1.Controls.Add(this.lblTipoMaterial);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.lblCantidadPiezas);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtTipoMaterial);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Prenda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione la colección a la que pertenece";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(6, 88);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(194, 20);
            this.txtColor.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(6, 167);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(194, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // cboTalla
            // 
            this.cboTalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTalla.FormattingEnabled = true;
            this.cboTalla.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL"});
            this.cboTalla.Location = new System.Drawing.Point(6, 127);
            this.cboTalla.Name = "cboTalla";
            this.cboTalla.Size = new System.Drawing.Size(194, 21);
            this.cboTalla.TabIndex = 3;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(6, 72);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Color";
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Location = new System.Drawing.Point(6, 111);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(30, 13);
            this.lblTalla.TabIndex = 7;
            this.lblTalla.Text = "Talla";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 151);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca";
            // 
            // lblTipoPrenda
            // 
            this.lblTipoPrenda.AutoSize = true;
            this.lblTipoPrenda.Location = new System.Drawing.Point(6, 32);
            this.lblTipoPrenda.Name = "lblTipoPrenda";
            this.lblTipoPrenda.Size = new System.Drawing.Size(80, 13);
            this.lblTipoPrenda.TabIndex = 10;
            this.lblTipoPrenda.Text = "Tipo de Prenda";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(6, 48);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(194, 21);
            this.cboCategoria.TabIndex = 9;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // btnAgregarNuevaPrenda
            // 
            this.btnAgregarNuevaPrenda.Location = new System.Drawing.Point(12, 330);
            this.btnAgregarNuevaPrenda.Name = "btnAgregarNuevaPrenda";
            this.btnAgregarNuevaPrenda.Size = new System.Drawing.Size(206, 44);
            this.btnAgregarNuevaPrenda.TabIndex = 3;
            this.btnAgregarNuevaPrenda.Text = "Agregar Nueva Prenda";
            this.btnAgregarNuevaPrenda.UseVisualStyleBackColor = true;
            this.btnAgregarNuevaPrenda.Click += new System.EventHandler(this.btnAgregarNuevaPrenda_Click);
            // 
            // chkEstampado
            // 
            this.chkEstampado.AutoSize = true;
            this.chkEstampado.Location = new System.Drawing.Point(18, 282);
            this.chkEstampado.Name = "chkEstampado";
            this.chkEstampado.Size = new System.Drawing.Size(120, 17);
            this.chkEstampado.TabIndex = 4;
            this.chkEstampado.Text = "¿Tiene estampado?";
            this.chkEstampado.UseVisualStyleBackColor = true;
            // 
            // lblTipoMaterial
            // 
            this.lblTipoMaterial.AutoSize = true;
            this.lblTipoMaterial.Location = new System.Drawing.Point(6, 196);
            this.lblTipoMaterial.Name = "lblTipoMaterial";
            this.lblTipoMaterial.Size = new System.Drawing.Size(83, 13);
            this.lblTipoMaterial.TabIndex = 12;
            this.lblTipoMaterial.Text = "Tipo de Material";
            // 
            // txtTipoMaterial
            // 
            this.txtTipoMaterial.Location = new System.Drawing.Point(6, 212);
            this.txtTipoMaterial.Name = "txtTipoMaterial";
            this.txtTipoMaterial.Size = new System.Drawing.Size(194, 20);
            this.txtTipoMaterial.TabIndex = 11;
            // 
            // lblCantidadPiezas
            // 
            this.lblCantidadPiezas.AutoSize = true;
            this.lblCantidadPiezas.Location = new System.Drawing.Point(3, 196);
            this.lblCantidadPiezas.Name = "lblCantidadPiezas";
            this.lblCantidadPiezas.Size = new System.Drawing.Size(98, 13);
            this.lblCantidadPiezas.TabIndex = 14;
            this.lblCantidadPiezas.Text = "Cantidad de Piezas";
            // 
            // txtCantidadPiezas
            // 
            this.txtCantidadPiezas.Location = new System.Drawing.Point(6, 212);
            this.txtCantidadPiezas.Name = "txtCantidadPiezas";
            this.txtCantidadPiezas.Size = new System.Drawing.Size(194, 20);
            this.txtCantidadPiezas.TabIndex = 13;
            // 
            // chkCierre
            // 
            this.chkCierre.AutoSize = true;
            this.chkCierre.Location = new System.Drawing.Point(18, 282);
            this.chkCierre.Name = "chkCierre";
            this.chkCierre.Size = new System.Drawing.Size(135, 17);
            this.chkCierre.TabIndex = 15;
            this.chkCierre.Text = "¿Tiene cierre / Zipper?";
            this.chkCierre.UseVisualStyleBackColor = true;
            // 
            // frmAgregarPrenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 382);
            this.Controls.Add(this.chkEstampado);
            this.Controls.Add(this.btnAgregarNuevaPrenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkCierre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboColecciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarPrenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVA PRENDA";
            this.Load += new System.EventHandler(this.frmAgregarPrenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboColecciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.ComboBox cboTalla;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblTipoPrenda;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnAgregarNuevaPrenda;
        private System.Windows.Forms.CheckBox chkEstampado;
        private System.Windows.Forms.Label lblTipoMaterial;
        private System.Windows.Forms.TextBox txtTipoMaterial;
        private System.Windows.Forms.Label lblCantidadPiezas;
        private System.Windows.Forms.TextBox txtCantidadPiezas;
        private System.Windows.Forms.CheckBox chkCierre;
    }
}
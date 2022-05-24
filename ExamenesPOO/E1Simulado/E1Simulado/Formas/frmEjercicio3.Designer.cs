namespace E1Simulado.Formas
{
    partial class frmEjercicio3
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
            this.btnPromediar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMateria1 = new System.Windows.Forms.Label();
            this.txtMateria1 = new System.Windows.Forms.TextBox();
            this.lblMateria2 = new System.Windows.Forms.Label();
            this.txtMateria2 = new System.Windows.Forms.TextBox();
            this.lblMateria3 = new System.Windows.Forms.Label();
            this.txtMateria3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(265, 350);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(132, 23);
            this.btnCapturar.TabIndex = 7;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnPromediar
            // 
            this.btnPromediar.Location = new System.Drawing.Point(265, 377);
            this.btnPromediar.Name = "btnPromediar";
            this.btnPromediar.Size = new System.Drawing.Size(132, 37);
            this.btnPromediar.TabIndex = 6;
            this.btnPromediar.Text = "Calcular Promedio";
            this.btnPromediar.UseVisualStyleBackColor = true;
            this.btnPromediar.Click += new System.EventHandler(this.btnPromediar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(262, 186);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(135, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre del Estudiante";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(265, 203);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblMateria1
            // 
            this.lblMateria1.AutoSize = true;
            this.lblMateria1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria1.Location = new System.Drawing.Point(265, 227);
            this.lblMateria1.Name = "lblMateria1";
            this.lblMateria1.Size = new System.Drawing.Size(82, 13);
            this.lblMateria1.TabIndex = 9;
            this.lblMateria1.Text = "Materia N°1: ";
            // 
            // txtMateria1
            // 
            this.txtMateria1.Location = new System.Drawing.Point(265, 244);
            this.txtMateria1.Name = "txtMateria1";
            this.txtMateria1.Size = new System.Drawing.Size(100, 20);
            this.txtMateria1.TabIndex = 8;
            // 
            // lblMateria2
            // 
            this.lblMateria2.AutoSize = true;
            this.lblMateria2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria2.Location = new System.Drawing.Point(265, 268);
            this.lblMateria2.Name = "lblMateria2";
            this.lblMateria2.Size = new System.Drawing.Size(82, 13);
            this.lblMateria2.TabIndex = 11;
            this.lblMateria2.Text = "Materia N°2: ";
            // 
            // txtMateria2
            // 
            this.txtMateria2.Location = new System.Drawing.Point(265, 285);
            this.txtMateria2.Name = "txtMateria2";
            this.txtMateria2.Size = new System.Drawing.Size(100, 20);
            this.txtMateria2.TabIndex = 10;
            // 
            // lblMateria3
            // 
            this.lblMateria3.AutoSize = true;
            this.lblMateria3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria3.Location = new System.Drawing.Point(265, 309);
            this.lblMateria3.Name = "lblMateria3";
            this.lblMateria3.Size = new System.Drawing.Size(82, 13);
            this.lblMateria3.TabIndex = 13;
            this.lblMateria3.Text = "Materia N°3: ";
            // 
            // txtMateria3
            // 
            this.txtMateria3.Location = new System.Drawing.Point(265, 326);
            this.txtMateria3.Name = "txtMateria3";
            this.txtMateria3.Size = new System.Drawing.Size(100, 20);
            this.txtMateria3.TabIndex = 12;
            // 
            // frmEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 601);
            this.Controls.Add(this.lblMateria3);
            this.Controls.Add(this.txtMateria3);
            this.Controls.Add(this.lblMateria2);
            this.Controls.Add(this.txtMateria2);
            this.Controls.Add(this.lblMateria1);
            this.Controls.Add(this.txtMateria1);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnPromediar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEjercicio3";
            this.Text = "frmEjercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnPromediar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMateria1;
        private System.Windows.Forms.TextBox txtMateria1;
        private System.Windows.Forms.Label lblMateria2;
        private System.Windows.Forms.TextBox txtMateria2;
        private System.Windows.Forms.Label lblMateria3;
        private System.Windows.Forms.TextBox txtMateria3;
    }
}
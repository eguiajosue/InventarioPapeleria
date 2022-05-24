// Decompiled with JetBrains decompiler
// Type: ExamenDistancia.frmAyuda
// Assembly: ExamenDistancia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 929C66B3-BE42-4041-A340-38CD61776081
// Assembly location: C:\Users\josue\OneDrive\Desktop\ExamenDistancia_2.exe

using ExamenDistancia.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ExamenDistancia
{
  public class frmAyuda : Form
  {
    private IContainer components = (IContainer) null;
    private PictureBox picAyuda;
    private LinkLabel lblSitioWebAyuda;

    public frmAyuda(string strSitioWebAyuda, bool blnImagenAyuda)
    {
      this.InitializeComponent();
      if (strSitioWebAyuda != "")
        this.lblSitioWebAyuda.Text = strSitioWebAyuda;
      else
        this.lblSitioWebAyuda.Visible = false;
      if (blnImagenAyuda)
        this.picAyuda.Visible = true;
      else
        this.picAyuda.Visible = false;
    }

    private void MostrarImagen(string strNombreArchivo)
    {
      try
      {
        Bitmap bitmap = new Bitmap(strNombreArchivo);
        this.picAyuda.SizeMode = PictureBoxSizeMode.StretchImage;
        this.picAyuda.Image = (Image) bitmap;
        this.picAyuda.Refresh();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al mostrar la imagen de ayuda\n\n" + ex.Message);
        this.picAyuda.Visible = false;
      }
    }

    private void lblSitioWebAyuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      try
      {
        Process.Start(this.lblSitioWebAyuda.Text);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al abrir el sitio web de ayuda\n\n" + ex.Message);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.picAyuda = new PictureBox();
      this.lblSitioWebAyuda = new LinkLabel();
      ((ISupportInitialize) this.picAyuda).BeginInit();
      this.SuspendLayout();
      this.picAyuda.Image = (Image) Resources.FigurasGeometricas;
      this.picAyuda.Location = new Point(12, 41);
      this.picAyuda.Name = "picAyuda";
      this.picAyuda.Size = new Size(716, 608);
      this.picAyuda.SizeMode = PictureBoxSizeMode.Zoom;
      this.picAyuda.TabIndex = 0;
      this.picAyuda.TabStop = false;
      this.lblSitioWebAyuda.AutoSize = true;
      this.lblSitioWebAyuda.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblSitioWebAyuda.LinkVisited = true;
      this.lblSitioWebAyuda.Location = new Point(12, 9);
      this.lblSitioWebAyuda.Name = "lblSitioWebAyuda";
      this.lblSitioWebAyuda.Size = new Size(131, 18);
      this.lblSitioWebAyuda.TabIndex = 2;
      this.lblSitioWebAyuda.TabStop = true;
      this.lblSitioWebAyuda.Text = "Sitio web de ayuda";
      this.lblSitioWebAyuda.TextAlign = ContentAlignment.TopCenter;
      this.lblSitioWebAyuda.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lblSitioWebAyuda_LinkClicked);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(773, 661);
      this.Controls.Add((Control) this.lblSitioWebAyuda);
      this.Controls.Add((Control) this.picAyuda);
      this.Name = nameof (frmAyuda);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Ayuda";
      ((ISupportInitialize) this.picAyuda).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

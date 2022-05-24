// Decompiled with JetBrains decompiler
// Type: EnviarEmail.Form1
// Assembly: EnviarEmail, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 18E8F7DE-84B0-41DB-B957-D2041674B30F
// Assembly location: C:\Users\josue\OneDrive\Desktop\EnviarEmail.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace EnviarEmail
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private GroupBox grpRemitente;
    private ComboBox cboServidor;
    private Label label3;
    private TextBox txtContraseña;
    private Label label2;
    private TextBox txtDireccionRemitente;
    private Label label1;
    private TextBox txtNombreRemitente;
    private Label lblNombreRemitente;
    private GroupBox grpDestinatario;
    private TextBox txtDireccionDestinatario;
    private Label label6;
    private GroupBox grpMensaje;
    private RichTextBox rtxtMensaje;
    private TextBox txtAsunto;
    private Label label8;
    private Button btnEnviar;

    public Form1() => this.InitializeComponent();

    private void btnEnviar_Click(object sender, EventArgs e)
    {
      MailMessage miMensaje = new MailMessage();
      try
      {
        miMensaje.Subject = this.txtAsunto.Text;
        miMensaje.To.Add(new MailAddress(this.txtDireccionDestinatario.Text));
        miMensaje.From = new MailAddress(this.txtDireccionRemitente.Text, this.txtNombreRemitente.Text);
        miMensaje.Body = this.rtxtMensaje.Text;
        string strDireccionServidor;
        int intPuerto;
        this.DetectarDireccionServidor(out strDireccionServidor, out intPuerto);
        new CorreoElectronico(strDireccionServidor, intPuerto, this.txtDireccionRemitente.Text, this.txtContraseña.Text).Enviar(miMensaje);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message, "ERROR AL INTENTAR ENVIAR EL CORREO ELECTRÓNICO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return;
      }
      int num1 = (int) MessageBox.Show("Correo electrónico enviado correctamente !!!");
    }

    private void DetectarDireccionServidor(out string strDireccionServidor, out int intPuerto)
    {
      switch (this.cboServidor.Text)
      {
        case "Hotmail":
          intPuerto = 25;
          strDireccionServidor = "smtp.live.com";
          break;
        case "Yahoo !":
          intPuerto = 587;
          strDireccionServidor = "smtp.yahoo.com";
          break;
        case "Gmail":
          intPuerto = 25;
          strDireccionServidor = "smtp.gmail.com";
          break;
        default:
          throw new Exception("Servidor desconocido");
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
      this.grpRemitente = new GroupBox();
      this.lblNombreRemitente = new Label();
      this.txtNombreRemitente = new TextBox();
      this.txtDireccionRemitente = new TextBox();
      this.label1 = new Label();
      this.txtContraseña = new TextBox();
      this.label2 = new Label();
      this.label3 = new Label();
      this.cboServidor = new ComboBox();
      this.grpDestinatario = new GroupBox();
      this.txtDireccionDestinatario = new TextBox();
      this.label6 = new Label();
      this.grpMensaje = new GroupBox();
      this.txtAsunto = new TextBox();
      this.label8 = new Label();
      this.rtxtMensaje = new RichTextBox();
      this.btnEnviar = new Button();
      this.grpRemitente.SuspendLayout();
      this.grpDestinatario.SuspendLayout();
      this.grpMensaje.SuspendLayout();
      this.SuspendLayout();
      this.grpRemitente.Controls.Add((Control) this.cboServidor);
      this.grpRemitente.Controls.Add((Control) this.label3);
      this.grpRemitente.Controls.Add((Control) this.txtContraseña);
      this.grpRemitente.Controls.Add((Control) this.label2);
      this.grpRemitente.Controls.Add((Control) this.txtDireccionRemitente);
      this.grpRemitente.Controls.Add((Control) this.label1);
      this.grpRemitente.Controls.Add((Control) this.txtNombreRemitente);
      this.grpRemitente.Controls.Add((Control) this.lblNombreRemitente);
      this.grpRemitente.Location = new Point(24, 22);
      this.grpRemitente.Name = "grpRemitente";
      this.grpRemitente.Size = new Size(381, 148);
      this.grpRemitente.TabIndex = 0;
      this.grpRemitente.TabStop = false;
      this.grpRemitente.Text = "Datos del remitente";
      this.lblNombreRemitente.AutoSize = true;
      this.lblNombreRemitente.Location = new Point(79, 33);
      this.lblNombreRemitente.Name = "lblNombreRemitente";
      this.lblNombreRemitente.Size = new Size(44, 13);
      this.lblNombreRemitente.TabIndex = 0;
      this.lblNombreRemitente.Text = "Nombre";
      this.txtNombreRemitente.Location = new Point(126, 30);
      this.txtNombreRemitente.Name = "txtNombreRemitente";
      this.txtNombreRemitente.Size = new Size(235, 20);
      this.txtNombreRemitente.TabIndex = 1;
      this.txtDireccionRemitente.Location = new Point(125, 56);
      this.txtDireccionRemitente.Name = "txtDireccionRemitente";
      this.txtDireccionRemitente.Size = new Size(235, 20);
      this.txtDireccionRemitente.TabIndex = 3;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(20, 59);
      this.label1.Name = "label1";
      this.label1.Size = new Size(100, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Dirección de correo";
      this.txtContraseña.Location = new Point(126, 82);
      this.txtContraseña.Name = "txtContraseña";
      this.txtContraseña.PasswordChar = '*';
      this.txtContraseña.Size = new Size(235, 20);
      this.txtContraseña.TabIndex = 5;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(61, 85);
      this.label2.Name = "label2";
      this.label2.Size = new Size(61, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Contraseña";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(74, 112);
      this.label3.Name = "label3";
      this.label3.Size = new Size(46, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Servidor";
      this.cboServidor.FormattingEnabled = true;
      this.cboServidor.Items.AddRange(new object[3]
      {
        (object) "Hotmail",
        (object) "Yahoo !",
        (object) "Gmail"
      });
      this.cboServidor.Location = new Point(125, 109);
      this.cboServidor.Name = "cboServidor";
      this.cboServidor.Size = new Size(121, 21);
      this.cboServidor.TabIndex = 7;
      this.cboServidor.Text = "Hotmail";
      this.grpDestinatario.Controls.Add((Control) this.txtDireccionDestinatario);
      this.grpDestinatario.Controls.Add((Control) this.label6);
      this.grpDestinatario.Location = new Point(24, 186);
      this.grpDestinatario.Name = "grpDestinatario";
      this.grpDestinatario.Size = new Size(381, 66);
      this.grpDestinatario.TabIndex = 1;
      this.grpDestinatario.TabStop = false;
      this.grpDestinatario.Text = "Datos del destinatario";
      this.txtDireccionDestinatario.Location = new Point(125, 26);
      this.txtDireccionDestinatario.Name = "txtDireccionDestinatario";
      this.txtDireccionDestinatario.Size = new Size(235, 20);
      this.txtDireccionDestinatario.TabIndex = 3;
      this.label6.AutoSize = true;
      this.label6.Location = new Point(20, 29);
      this.label6.Name = "label6";
      this.label6.Size = new Size(100, 13);
      this.label6.TabIndex = 2;
      this.label6.Text = "Dirección de correo";
      this.grpMensaje.Controls.Add((Control) this.rtxtMensaje);
      this.grpMensaje.Controls.Add((Control) this.txtAsunto);
      this.grpMensaje.Controls.Add((Control) this.label8);
      this.grpMensaje.Location = new Point(24, 274);
      this.grpMensaje.Name = "grpMensaje";
      this.grpMensaje.Size = new Size(381, 164);
      this.grpMensaje.TabIndex = 2;
      this.grpMensaje.TabStop = false;
      this.grpMensaje.Text = "Mensaje";
      this.txtAsunto.Location = new Point(126, 30);
      this.txtAsunto.Name = "txtAsunto";
      this.txtAsunto.Size = new Size(235, 20);
      this.txtAsunto.TabIndex = 1;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(79, 33);
      this.label8.Name = "label8";
      this.label8.Size = new Size(40, 13);
      this.label8.TabIndex = 0;
      this.label8.Text = "Asunto";
      this.rtxtMensaje.Location = new Point(6, 67);
      this.rtxtMensaje.Name = "rtxtMensaje";
      this.rtxtMensaje.Size = new Size(355, 75);
      this.rtxtMensaje.TabIndex = 2;
      this.rtxtMensaje.Text = "";
      this.btnEnviar.Location = new Point(24, 458);
      this.btnEnviar.Name = "btnEnviar";
      this.btnEnviar.Size = new Size(381, 23);
      this.btnEnviar.TabIndex = 3;
      this.btnEnviar.Text = "&Enviar correo electrónico";
      this.btnEnviar.UseVisualStyleBackColor = true;
      this.btnEnviar.Click += new EventHandler(this.btnEnviar_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(431, 495);
      this.Controls.Add((Control) this.btnEnviar);
      this.Controls.Add((Control) this.grpMensaje);
      this.Controls.Add((Control) this.grpDestinatario);
      this.Controls.Add((Control) this.grpRemitente);
      this.Name = nameof (Form1);
      this.Text = "Enviar correo electrónico";
      this.grpRemitente.ResumeLayout(false);
      this.grpRemitente.PerformLayout();
      this.grpDestinatario.ResumeLayout(false);
      this.grpDestinatario.PerformLayout();
      this.grpMensaje.ResumeLayout(false);
      this.grpMensaje.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}

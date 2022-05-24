// Decompiled with JetBrains decompiler
// Type: ExamenDistancia.frmForma1
// Assembly: ExamenDistancia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 01C7BE8D-DB77-46F9-93C2-215C98B0A0C1
// Assembly location: C:\Users\josue\OneDrive\Desktop\ExamenDistancia_1.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExamenDistancia
{
  public class frmForma1 : Form
  {
    private DatosExamen misDatosExamen = new DatosExamen();
    private List<Estudiante> miListaEstudiantes = new List<Estudiante>();
    private Estudiante miEstudiante;
    private ArchivoSecuencialSerializadoBinario<Estudiante> miArchivo;
    private static bool blnAdministrador = true;
    private IContainer components = (IContainer) null;
    private TabControl tabExamen;
    private TabPage tabRegistrarEstudiantes;
    private ListBox lstParticipantes;
    private GroupBox grpNoCtrl;
    private Button btnAgregarParticipante;
    private TextBox txtNoCtrl;
    private Label lblNoCtrl;
    private RichTextBox rtxtExamenAsignado;
    private RichTextBox rtxtInstrucciones;
    private TabPage tabExamenAsignado;
    private Button btnAsignarExamenes;
    private DataGridView dgExamenesAsignados;
    private ListBox lstExamenesDisponibles;
    private Button btnLimpiarListaEstudiantes;
    private DataGridView dgCantidadExamenes;
    private TextBox txtCantEstudiantes;
    private Label label3;
    private Button btnAyuda;
    private Button btnCambiarEstudiante;
    private TextBox txtCantIncisos;
    private Label label1;
    private Label lblNombreMateria;
    private Label lblClaveExamenAsignado;
    private Label lblTemaExamen;
    private DataGridView dgExamenesAsignadosManualmente;
    private Label label4;
    private Label label2;
    private TabPage tabListasEstudiantes;
    private TextBox txtCantidadEstudiantesED;
    private Label label9;
    private ListBox lstEstudiantesED;
    private Label label10;
    private TextBox txtCantidadEstudiantesPOO;
    private Label label7;
    private ListBox lstEstudiantesPOO;
    private Label label8;
    private TextBox txtCantidadEstudiantesFP;
    private Label label6;
    private ListBox lstEstudiantesFP;
    private Label label5;
    private DataGridView dgSinDerecho;
    private Label label11;
    private ListBox lstEstudiantesNOpresentan;
    private Label label12;

    public frmForma1() => this.InitializeComponent();

    private void MostrarExamenAsignado()
    {
      if (frmForma1.blnAdministrador)
        this.tabExamen.Enabled = true;
      else
        this.tabExamen.Enabled = false;
      Estudiante estudiante = new Estudiante("", "");
      Estudiante miEstudiante = this.miListaEstudiantes.Find((Predicate<Estudiante>) (x => x.NoCtrl == this.miEstudiante.NoCtrl));
      if (miEstudiante == null)
      {
        int num1 = (int) MessageBox.Show("Estudiante no registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        Examen examen = new Examen();
        if (miEstudiante != null)
          examen = this.misDatosExamen.BuscarExamen(miEstudiante);
        if (examen == null && !frmForma1.blnAdministrador)
          throw new Exception("No se encuentra este examen");
        if (miEstudiante == null)
          return;
        this.BuscarSinDerecho(ref miEstudiante);
        if (miEstudiante.MotivoSinDerecho != "" && !frmForma1.blnAdministrador)
        {
          int num2 = (int) MessageBox.Show("El estudiante " + miEstudiante.NoCtrl + " NO presenta este examen\n\nMotivo: " + miEstudiante.MotivoSinDerecho, "ESTUDIANTE NO PRESENTA ESTE EXAMEN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Application.Exit();
        }
        else
        {
          int num3 = (int) MessageBox.Show("No cierre esta aplicación antes de terminar el examen\n\nNo le permitirá acceder nuevamente\n\nDuración del examen: " + this.misDatosExamen.DuracionMinutos.ToString() + " minutos", "I M P O R T A N T E", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.rtxtExamenAsignado.Text = "";
          this.rtxtExamenAsignado.Text = this.Decodificar(examen.Redaccion) + "\n" + this.Decodificar(examen.Inciso);
          this.tabExamen.SelectedTab = this.tabExamenAsignado;
        }
      }
    }

    private void btnAgregarParticipante_Click(object sender, EventArgs e)
    {
      if (this.txtNoCtrl.Text == "")
      {
        int num = (int) MessageBox.Show("No deje en blanco el número de control");
      }
      else
      {
        this.lstParticipantes.Items.Add((object) this.txtNoCtrl.Text);
        this.txtCantEstudiantes.Text = this.lstParticipantes.Items.Count.ToString();
        this.txtNoCtrl.Clear();
        this.txtNoCtrl.Focus();
      }
    }

    private void CrearFormaLogin()
    {
      Form form = new Form();
      Label label1 = new Label();
      Label label2 = new Label();
      Label label3 = new Label();
      Label label4 = new Label();
      TextBox textBox = new TextBox();
      Button button1 = new Button();
      Button button2 = new Button();
      label1.Text = this.misDatosExamen.NombreMateria;
      label1.Font = new Font("Tahoma", 12f);
      label1.ForeColor = Color.Red;
      label2.Text = this.misDatosExamen.TipoExamen;
      label2.Font = new Font("Tahoma", 10f);
      label2.ForeColor = Color.Green;
      label3.Text = this.misDatosExamen.TemaExamen;
      label3.Font = new Font("Tahoma", 10f);
      label3.ForeColor = Color.DarkRed;
      label4.Text = "No.Control ";
      button1.Text = "&Acceder";
      button2.Text = "&Salir";
      button1.DialogResult = DialogResult.OK;
      button2.DialogResult = DialogResult.Cancel;
      label1.SetBounds(10, 10, label1.Text.Length * 10, 20);
      label2.SetBounds(10, label1.Top + 25, label2.Text.Length * 10, 20);
      label3.SetBounds(10, label2.Top + 25, label3.Text.Length * 10, 20);
      label4.SetBounds(40, label3.Top + 40, 65, 20);
      textBox.SetBounds(label4.Right + 1, label4.Top - 3, 150, 20);
      form.Text = "Examen a distancia - " + this.misDatosExamen.FechaInicio.ToLongDateString();
      form.Controls.AddRange(new Control[7]
      {
        (Control) label1,
        (Control) label2,
        (Control) label3,
        (Control) label4,
        (Control) textBox,
        (Control) button1,
        (Control) button2
      });
      form.ClientSize = new Size(Math.Max(80, textBox.Right + 70), Math.Max(80, textBox.Top + 80));
      button2.SetBounds(form.Right - 110, form.Bottom - 80, 75, 23);
      button1.SetBounds(button2.Left - 90, form.Bottom - 80, 75, 23);
      form.FormBorderStyle = FormBorderStyle.FixedDialog;
      form.StartPosition = FormStartPosition.CenterScreen;
      form.MinimizeBox = false;
      form.MaximizeBox = false;
      form.ControlBox = false;
      form.ShowInTaskbar = false;
      form.AcceptButton = (IButtonControl) button1;
      form.CancelButton = (IButtonControl) button2;
      if (form.ShowDialog() == DialogResult.OK)
      {
        try
        {
          this.miEstudiante = new Estudiante(textBox.Text, "");
          this.miArchivo = new ArchivoSecuencialSerializadoBinario<Estudiante>(this.misDatosExamen.NombreArchivoConfiguracion);
          //if (!this.miListaEstudiantes.Contains(this.miEstudiante) && !frmForma1.blnAdministrador)
          //  throw new Exception("Estudiante NO registrado en este examen");
          //if (this.miArchivo.RevisarSiExiste() && !frmForma1.blnAdministrador)
          //  throw new Exception("Fecha del examen: " + this.misDatosExamen.FechaInicio.ToLongDateString() + "\n\nNo puede consultar nuevamente el examen");
          //if (DateTime.Now < this.misDatosExamen.FechaInicio && !frmForma1.blnAdministrador)
          //  throw new Exception("Aún no es hora de iniciar el examen");
          //if (DateTime.Now > this.misDatosExamen.CalcularHoraVencimiento() && !frmForma1.blnAdministrador)
          //  throw new Exception("Ha expirado el límite de tiempo");
          this.miArchivo.CrearCarpeta();
          this.miArchivo.AbrirEnModoEscritura();
          this.miArchivo.GrabarObjeto(this.miEstudiante);
          this.miArchivo.Cerrar();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.Close();
          Application.Exit();
        }
      }
      else
      {
        this.Close();
        Application.Exit();
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.Text = "Examen a distancia Por Ing. Bruno López Takeyas - " + this.misDatosExamen.NombreMateria + " - " + this.misDatosExamen.TipoExamen + " - " + this.misDatosExamen.TemaExamen + " - " + this.misDatosExamen.FechaInicio.ToLongDateString();
      this.dgSinDerecho.Columns.Add("No Ctrl", "No Ctrl");
      this.dgSinDerecho.Columns.Add("Motivo", "Motivo");
      this.dgSinDerecho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgSinDerecho.Rows.Add((object) "21100777", (object) "No acumuló el 80 % de asistencia en este parcial");
      this.dgSinDerecho.Rows.Add((object) "21100164", (object) "No acumuló el 80 % de asistencia en este parcial");
      this.dgSinDerecho.Rows.Add((object) "21100192", (object) "No acumuló el 80 % de asistencia en este parcial");
      this.dgSinDerecho.Rows.Add((object) "19100792", (object) "No acumuló el 80 % de asistencia en este parcial");
      this.dgSinDerecho.Rows.Add((object) "20100222", (object) "No acumuló el 80 % de asistencia en este parcial");
      this.dgSinDerecho.Rows.Add((object) "21100232", (object) "No acumuló el 80 % de asistencia en este parcial");
      this.dgSinDerecho.Rows.Add((object) "20100246", (object) "No acumuló el 80 % de asistencia en este parcial");
      this.dgSinDerecho.Rows.Add((object) "20100247", (object) "No acumuló el 80 % de asistencia en este parcial");
      this.dgSinDerecho.Rows.Add((object) "21100267", (object) "No acumuló el 80 % de asistencia en este parcial");
      this.dgSinDerecho.Rows.Add((object) "21100277", (object) "No acumuló el 80 % de asistencia en este parcial");
      this.dgSinDerecho.Rows.Add((object) "21100280", (object) "No acumuló el 80 % de asistencia en este parcial");
      this.dgSinDerecho.Rows.Add((object) "21100302", (object) "No acumuló el 80 % de asistencia en este parcial");
      this.dgExamenesAsignados.Columns.Add("No Ctrl", "No Ctrl");
      this.dgExamenesAsignados.Columns.Add("Examen asignado", "Examen asignado");
      this.dgExamenesAsignadosManualmente.Columns.Add("No Ctrl", "No Ctrl");
      this.dgExamenesAsignadosManualmente.Columns.Add("Examen asignado", "Examen asignado");
      this.dgCantidadExamenes.Columns.Add("Examen", "Examen");
      this.dgCantidadExamenes.Columns.Add("Cant. estudiantes", "Cant. estudiantes");
      this.txtCantidadEstudiantesFP.Text = this.lstEstudiantesFP.Items.Count.ToString();
      this.txtCantidadEstudiantesPOO.Text = this.lstEstudiantesPOO.Items.Count.ToString();
      this.txtCantidadEstudiantesED.Text = this.lstEstudiantesED.Items.Count.ToString();
      this.LlenarListaParticipantesSegunMateria();
      this.btnCambiarEstudiante.Visible = false;
      this.tabExamen.Enabled = true;
      this.InicializarControlesVisuales();
      this.LogearEstudiante();
    }

    private void InicializarControlesVisuales()
    {
      foreach (object listaExamene in this.misDatosExamen.ListaExamenes)
        this.lstExamenesDisponibles.Items.Add(listaExamene);
      this.txtCantIncisos.Text = this.lstExamenesDisponibles.Items.Count.ToString();
      this.lblNombreMateria.Text = this.misDatosExamen.NombreMateria;
      this.lblClaveExamenAsignado.Text = "";
      this.lblTemaExamen.Text = this.misDatosExamen.TemaExamen;
      this.rtxtInstrucciones.Text = this.misDatosExamen.Instrucciones;
      if (this.misDatosExamen.BotonAyuda)
        this.btnAyuda.Visible = true;
      else
        this.btnAyuda.Visible = false;
      this.AsignarExamenes();
    }

    private void LogearEstudiante()
    {
      this.CrearFormaLogin();
      try
      {
        if (this.miEstudiante == null)
          return;
        this.MostrarExamenAsignado();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
        Application.Exit();
      }
    }

    private string Codificar(string strLineaOriginal)
    {
      string str = "";
      for (int index = 0; index < strLineaOriginal.Length; ++index)
      {
        char ch1 = strLineaOriginal[index];
        if (ch1 != '"')
        {
          char ch2 = (char) ((uint) ch1 + 5U);
          str += ch2.ToString();
        }
      }
      return str;
    }

    private string Decodificar(string strLineaCodificada)
    {
      string str = "";
      for (int index = 0; index < strLineaCodificada.Length; ++index)
      {
        char ch = (char) ((uint) strLineaCodificada[index] - 5U);
        str += ch.ToString();
      }
      return str;
    }

    private void btnAsignarExamenes_Click(object sender, EventArgs e)
    {
      this.AsignarExamenes();
      this.dgExamenesAsignados.Rows.Clear();
      foreach (Estudiante miListaEstudiante in this.miListaEstudiantes)
        this.dgExamenesAsignados.Rows.Add((object) miListaEstudiante.NoCtrl, (object) miListaEstudiante.ExamenAsignado);
      this.dgCantidadExamenes.Rows.Clear();
      foreach (Examen examen in this.lstExamenesDisponibles.Items)
      {
        int num = 0;
        for (int rowIndex = 0; rowIndex < this.dgExamenesAsignados.Rows.Count - 1; ++rowIndex)
        {
          string str = this.dgExamenesAsignados[1, rowIndex].Value.ToString();
          if (examen.Clave == str)
            ++num;
        }
        this.dgCantidadExamenes.Rows.Add((object) examen.Clave, (object) num);
      }
    }

    private void btnLimpiarListaEstudiantes_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("¿Está seguro que desea limpiar la lista de estudiantes?", "CONFIRME LA OPERACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      this.lstParticipantes.Items.Clear();
      this.txtCantEstudiantes.Text = this.lstParticipantes.Items.Count.ToString();
    }

    private void rtxtExamenAsignado_MouseClick(object sender, MouseEventArgs e) => Clipboard.Clear();

    private void btnAyuda_Click(object sender, EventArgs e) => new frmAyuda(this.misDatosExamen.SitioWebAyuda, this.misDatosExamen.ImagenAyuda).Show();

    private void btnCambiarEstudiante_Click(object sender, EventArgs e) => this.LogearEstudiante();

    private void label4_Click(object sender, EventArgs e)
    {
    }

    private void AsignarExamenes()
    {
      this.miListaEstudiantes = new List<Estudiante>();
      int num = 0;
      foreach (string strNoCtrl in this.lstParticipantes.Items)
      {
        this.miEstudiante = new Estudiante(strNoCtrl, "");
        this.BuscarExamenAsignadoManualmente(ref this.miEstudiante);
        if (this.miEstudiante.ExamenAsignado != "")
        {
          this.miListaEstudiantes.Add(this.miEstudiante);
        }
        else
        {
          if (num == this.misDatosExamen.ContarExamenes())
            num = 0;
          Examen examen = new Examen();
          this.miEstudiante.ExamenAsignado = ((Examen) this.lstExamenesDisponibles.Items[num++]).Clave;
          this.miListaEstudiantes.Add(this.miEstudiante);
        }
      }
    }

    private void BuscarExamenAsignadoManualmente(ref Estudiante miEstudiante)
    {
      for (int rowIndex = 0; rowIndex < this.dgExamenesAsignadosManualmente.Rows.Count; ++rowIndex)
      {
        if (this.dgExamenesAsignadosManualmente[0, rowIndex].Value != null && !(this.dgExamenesAsignadosManualmente[0, rowIndex].Value.ToString() != miEstudiante.NoCtrl))
        {
          miEstudiante.ExamenAsignado = this.dgExamenesAsignadosManualmente[1, rowIndex].Value.ToString();
          break;
        }
      }
    }

    private void LlenarListaParticipantesSegunMateria()
    {
      this.lstParticipantes.Items.Clear();
      switch (this.misDatosExamen.NombreMateria)
      {
        case "Fundamentos de Programación":
          this.LlenarListBox(this.lstEstudiantesFP);
          break;
        case "Programación Orientada a Objetos":
          this.LlenarListBox(this.lstEstudiantesPOO);
          break;
        case "Estructuras de Datos":
          this.LlenarListBox(this.lstEstudiantesED);
          break;
      }
      this.txtCantEstudiantes.Text = this.lstParticipantes.Items.Count.ToString();
    }

    private void LlenarListBox(ListBox lstOrigen)
    {
      foreach (string str in lstOrigen.Items)
        this.lstParticipantes.Items.Add((object) str);
    }

    private void lstEstudiantesFP_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void BuscarSinDerecho(ref Estudiante miEstudiante)
    {
      miEstudiante.MotivoSinDerecho = "";
      for (int rowIndex = 0; rowIndex < this.dgSinDerecho.Rows.Count; ++rowIndex)
      {
        if (this.dgSinDerecho[0, rowIndex].Value != null && !(this.dgSinDerecho[0, rowIndex].Value.ToString() != miEstudiante.NoCtrl))
        {
          miEstudiante.MotivoSinDerecho = this.dgSinDerecho[1, rowIndex].Value.ToString();
          break;
        }
      }
      foreach (string str in this.lstEstudiantesNOpresentan.Items)
      {
        if (str == miEstudiante.NoCtrl)
        {
          miEstudiante.MotivoSinDerecho = "Ud. no presenta este examen (hoy no le corresponde)";
          break;
        }
      }
    }

    private void lstEstudiantesNOpresentan_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void rtxtExamenAsignado_TextChanged(object sender, EventArgs e)
    {
    }

    private void lstEstudiantesPOO_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.tabExamen = new TabControl();
      this.tabExamenAsignado = new TabPage();
      this.lblTemaExamen = new Label();
      this.lblClaveExamenAsignado = new Label();
      this.lblNombreMateria = new Label();
      this.rtxtInstrucciones = new RichTextBox();
      this.rtxtExamenAsignado = new RichTextBox();
      this.tabRegistrarEstudiantes = new TabPage();
      this.label4 = new Label();
      this.label2 = new Label();
      this.dgExamenesAsignadosManualmente = new DataGridView();
      this.txtCantIncisos = new TextBox();
      this.label1 = new Label();
      this.txtCantEstudiantes = new TextBox();
      this.label3 = new Label();
      this.dgCantidadExamenes = new DataGridView();
      this.btnLimpiarListaEstudiantes = new Button();
      this.lstExamenesDisponibles = new ListBox();
      this.btnAsignarExamenes = new Button();
      this.dgExamenesAsignados = new DataGridView();
      this.lstParticipantes = new ListBox();
      this.grpNoCtrl = new GroupBox();
      this.btnAgregarParticipante = new Button();
      this.txtNoCtrl = new TextBox();
      this.lblNoCtrl = new Label();
      this.tabListasEstudiantes = new TabPage();
      this.lstEstudiantesNOpresentan = new ListBox();
      this.label12 = new Label();
      this.dgSinDerecho = new DataGridView();
      this.label11 = new Label();
      this.txtCantidadEstudiantesED = new TextBox();
      this.label9 = new Label();
      this.lstEstudiantesED = new ListBox();
      this.label10 = new Label();
      this.txtCantidadEstudiantesPOO = new TextBox();
      this.label7 = new Label();
      this.lstEstudiantesPOO = new ListBox();
      this.label8 = new Label();
      this.txtCantidadEstudiantesFP = new TextBox();
      this.label6 = new Label();
      this.lstEstudiantesFP = new ListBox();
      this.label5 = new Label();
      this.btnAyuda = new Button();
      this.btnCambiarEstudiante = new Button();
      this.tabExamen.SuspendLayout();
      this.tabExamenAsignado.SuspendLayout();
      this.tabRegistrarEstudiantes.SuspendLayout();
      ((ISupportInitialize) this.dgExamenesAsignadosManualmente).BeginInit();
      ((ISupportInitialize) this.dgCantidadExamenes).BeginInit();
      ((ISupportInitialize) this.dgExamenesAsignados).BeginInit();
      this.grpNoCtrl.SuspendLayout();
      this.tabListasEstudiantes.SuspendLayout();
      ((ISupportInitialize) this.dgSinDerecho).BeginInit();
      this.SuspendLayout();
      this.tabExamen.Controls.Add((Control) this.tabExamenAsignado);
      this.tabExamen.Controls.Add((Control) this.tabRegistrarEstudiantes);
      this.tabExamen.Controls.Add((Control) this.tabListasEstudiantes);
      this.tabExamen.Location = new Point(12, 34);
      this.tabExamen.Name = "tabExamen";
      this.tabExamen.SelectedIndex = 0;
      this.tabExamen.Size = new Size(1209, 652);
      this.tabExamen.TabIndex = 0;
      this.tabExamenAsignado.Controls.Add((Control) this.lblTemaExamen);
      this.tabExamenAsignado.Controls.Add((Control) this.lblClaveExamenAsignado);
      this.tabExamenAsignado.Controls.Add((Control) this.lblNombreMateria);
      this.tabExamenAsignado.Controls.Add((Control) this.rtxtInstrucciones);
      this.tabExamenAsignado.Controls.Add((Control) this.rtxtExamenAsignado);
      this.tabExamenAsignado.Location = new Point(4, 22);
      this.tabExamenAsignado.Name = "tabExamenAsignado";
      this.tabExamenAsignado.Size = new Size(1201, 626);
      this.tabExamenAsignado.TabIndex = 3;
      this.tabExamenAsignado.Text = "ExamenAsignado";
      this.tabExamenAsignado.UseVisualStyleBackColor = true;
      this.lblTemaExamen.AutoSize = true;
      this.lblTemaExamen.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTemaExamen.ForeColor = Color.Navy;
      this.lblTemaExamen.Location = new Point(694, 25);
      this.lblTemaExamen.Name = "lblTemaExamen";
      this.lblTemaExamen.Size = new Size(64, 25);
      this.lblTemaExamen.TabIndex = 5;
      this.lblTemaExamen.Text = "label2";
      this.lblClaveExamenAsignado.AutoSize = true;
      this.lblClaveExamenAsignado.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblClaveExamenAsignado.ForeColor = Color.Navy;
      this.lblClaveExamenAsignado.Location = new Point(368, 25);
      this.lblClaveExamenAsignado.Name = "lblClaveExamenAsignado";
      this.lblClaveExamenAsignado.Size = new Size(64, 25);
      this.lblClaveExamenAsignado.TabIndex = 4;
      this.lblClaveExamenAsignado.Text = "label2";
      this.lblNombreMateria.AutoSize = true;
      this.lblNombreMateria.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblNombreMateria.ForeColor = Color.Navy;
      this.lblNombreMateria.Location = new Point(7, 25);
      this.lblNombreMateria.Name = "lblNombreMateria";
      this.lblNombreMateria.Size = new Size(64, 25);
      this.lblNombreMateria.TabIndex = 3;
      this.lblNombreMateria.Text = "label2";
      this.rtxtInstrucciones.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.rtxtInstrucciones.ForeColor = Color.Blue;
      this.rtxtInstrucciones.Location = new Point(12, 486);
      this.rtxtInstrucciones.Name = "rtxtInstrucciones";
      this.rtxtInstrucciones.Size = new Size(1171, 132);
      this.rtxtInstrucciones.TabIndex = 2;
      this.rtxtInstrucciones.Text = "";
      this.rtxtExamenAsignado.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.rtxtExamenAsignado.ForeColor = Color.Red;
      this.rtxtExamenAsignado.Location = new Point(12, 68);
      this.rtxtExamenAsignado.Name = "rtxtExamenAsignado";
      this.rtxtExamenAsignado.Size = new Size(1171, 406);
      this.rtxtExamenAsignado.TabIndex = 1;
      this.rtxtExamenAsignado.Text = "";
      this.rtxtExamenAsignado.MouseClick += new MouseEventHandler(this.rtxtExamenAsignado_MouseClick);
      this.rtxtExamenAsignado.TextChanged += new EventHandler(this.rtxtExamenAsignado_TextChanged);
      this.tabRegistrarEstudiantes.Controls.Add((Control) this.label4);
      this.tabRegistrarEstudiantes.Controls.Add((Control) this.label2);
      this.tabRegistrarEstudiantes.Controls.Add((Control) this.dgExamenesAsignadosManualmente);
      this.tabRegistrarEstudiantes.Controls.Add((Control) this.txtCantIncisos);
      this.tabRegistrarEstudiantes.Controls.Add((Control) this.label1);
      this.tabRegistrarEstudiantes.Controls.Add((Control) this.txtCantEstudiantes);
      this.tabRegistrarEstudiantes.Controls.Add((Control) this.label3);
      this.tabRegistrarEstudiantes.Controls.Add((Control) this.dgCantidadExamenes);
      this.tabRegistrarEstudiantes.Controls.Add((Control) this.btnLimpiarListaEstudiantes);
      this.tabRegistrarEstudiantes.Controls.Add((Control) this.lstExamenesDisponibles);
      this.tabRegistrarEstudiantes.Controls.Add((Control) this.btnAsignarExamenes);
      this.tabRegistrarEstudiantes.Controls.Add((Control) this.dgExamenesAsignados);
      this.tabRegistrarEstudiantes.Controls.Add((Control) this.lstParticipantes);
      this.tabRegistrarEstudiantes.Controls.Add((Control) this.grpNoCtrl);
      this.tabRegistrarEstudiantes.Location = new Point(4, 22);
      this.tabRegistrarEstudiantes.Name = "tabRegistrarEstudiantes";
      this.tabRegistrarEstudiantes.Padding = new Padding(3);
      this.tabRegistrarEstudiantes.Size = new Size(1201, 626);
      this.tabRegistrarEstudiantes.TabIndex = 1;
      this.tabRegistrarEstudiantes.Text = "Asignar exámenes";
      this.tabRegistrarEstudiantes.UseVisualStyleBackColor = true;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(952, 321);
      this.label4.Name = "label4";
      this.label4.Size = new Size(173, 13);
      this.label4.TabIndex = 13;
      this.label4.Text = "Exámenes asignados manualmente";
      this.label4.Click += new EventHandler(this.label4_Click);
      this.label2.AutoSize = true;
      this.label2.Location = new Point(952, 31);
      this.label2.Name = "label2";
      this.label2.Size = new Size(191, 13);
      this.label2.TabIndex = 12;
      this.label2.Text = "Exámenes asignados automáticamente";
      this.dgExamenesAsignadosManualmente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgExamenesAsignadosManualmente.Location = new Point(955, 337);
      this.dgExamenesAsignadosManualmente.Name = "dgExamenesAsignadosManualmente";
      this.dgExamenesAsignadosManualmente.Size = new Size(240, 135);
      this.dgExamenesAsignadosManualmente.TabIndex = 11;
      this.txtCantIncisos.Location = new Point(612, 595);
      this.txtCantIncisos.Name = "txtCantIncisos";
      this.txtCantIncisos.ReadOnly = true;
      this.txtCantIncisos.Size = new Size(40, 20);
      this.txtCantIncisos.TabIndex = 10;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(429, 598);
      this.label1.Name = "label1";
      this.label1.Size = new Size(179, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "Cant. incisos (exámenes disponibles)";
      this.txtCantEstudiantes.Location = new Point(131, 490);
      this.txtCantEstudiantes.Name = "txtCantEstudiantes";
      this.txtCantEstudiantes.ReadOnly = true;
      this.txtCantEstudiantes.Size = new Size(39, 20);
      this.txtCantEstudiantes.TabIndex = 8;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(36, 493);
      this.label3.Name = "label3";
      this.label3.Size = new Size(89, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Cant. estudiantes";
      this.dgCantidadExamenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgCantidadExamenes.Location = new Point(955, 479);
      this.dgCantidadExamenes.Name = "dgCantidadExamenes";
      this.dgCantidadExamenes.Size = new Size(240, 138);
      this.dgCantidadExamenes.TabIndex = 6;
      this.btnLimpiarListaEstudiantes.Location = new Point(16, 558);
      this.btnLimpiarListaEstudiantes.Name = "btnLimpiarListaEstudiantes";
      this.btnLimpiarListaEstudiantes.Size = new Size(154, 23);
      this.btnLimpiarListaEstudiantes.TabIndex = 5;
      this.btnLimpiarListaEstudiantes.Text = "&Limpiar lista estudiantes";
      this.btnLimpiarListaEstudiantes.UseVisualStyleBackColor = true;
      this.btnLimpiarListaEstudiantes.Click += new EventHandler(this.btnLimpiarListaEstudiantes_Click);
      this.lstExamenesDisponibles.FormattingEnabled = true;
      this.lstExamenesDisponibles.Location = new Point(190, 31);
      this.lstExamenesDisponibles.Name = "lstExamenesDisponibles";
      this.lstExamenesDisponibles.Size = new Size(744, 550);
      this.lstExamenesDisponibles.TabIndex = 4;
      this.btnAsignarExamenes.Location = new Point(16, 525);
      this.btnAsignarExamenes.Name = "btnAsignarExamenes";
      this.btnAsignarExamenes.Size = new Size(154, 23);
      this.btnAsignarExamenes.TabIndex = 3;
      this.btnAsignarExamenes.Text = "Asignar &exámenes";
      this.btnAsignarExamenes.UseVisualStyleBackColor = true;
      this.btnAsignarExamenes.Click += new EventHandler(this.btnAsignarExamenes_Click);
      this.dgExamenesAsignados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgExamenesAsignados.Location = new Point(955, 48);
      this.dgExamenesAsignados.Name = "dgExamenesAsignados";
      this.dgExamenesAsignados.Size = new Size(240, 257);
      this.dgExamenesAsignados.TabIndex = 2;
      this.lstParticipantes.FormattingEnabled = true;
      this.lstParticipantes.Items.AddRange(new object[54]
      {
        (object) "19100155",
        (object) "19100158",
        (object) "19100159",
        (object) "19100170",
        (object) "19100168",
        (object) "19100173",
        (object) "19100175",
        (object) "19100176",
        (object) "19100180",
        (object) "19100190",
        (object) "19100197",
        (object) "19100199",
        (object) "19100204",
        (object) "19100208",
        (object) "19100212",
        (object) "19100214",
        (object) "19100218",
        (object) "19100221",
        (object) "19100222",
        (object) "19100234",
        (object) "19100238",
        (object) "19100241",
        (object) "19100243",
        (object) "19100249",
        (object) "19100254",
        (object) "19100255",
        (object) "19100257",
        (object) "19100265",
        (object) "19100140",
        (object) "19100141",
        (object) "19100154",
        (object) "19100157",
        (object) "19100162",
        (object) "19100165",
        (object) "19100166",
        (object) "18100171",
        (object) "17100767",
        (object) "19100187",
        (object) "19100196",
        (object) "19100195",
        (object) "19100201",
        (object) "19100202",
        (object) "19100797",
        (object) "19100209",
        (object) "19100211",
        (object) "19100217",
        (object) "19100798",
        (object) "19100226",
        (object) "19100231",
        (object) "19100236",
        (object) "19100800",
        (object) "19100242",
        (object) "19100252",
        (object) "18100244"
      });
      this.lstParticipantes.Location = new Point(16, 143);
      this.lstParticipantes.Name = "lstParticipantes";
      this.lstParticipantes.Size = new Size(154, 329);
      this.lstParticipantes.TabIndex = 1;
      this.grpNoCtrl.Controls.Add((Control) this.btnAgregarParticipante);
      this.grpNoCtrl.Controls.Add((Control) this.txtNoCtrl);
      this.grpNoCtrl.Controls.Add((Control) this.lblNoCtrl);
      this.grpNoCtrl.Location = new Point(16, 18);
      this.grpNoCtrl.Name = "grpNoCtrl";
      this.grpNoCtrl.Size = new Size(154, 100);
      this.grpNoCtrl.TabIndex = 0;
      this.grpNoCtrl.TabStop = false;
      this.grpNoCtrl.Text = "No Control Estudiante";
      this.btnAgregarParticipante.Location = new Point(19, 71);
      this.btnAgregarParticipante.Name = "btnAgregarParticipante";
      this.btnAgregarParticipante.Size = new Size(75, 23);
      this.btnAgregarParticipante.TabIndex = 2;
      this.btnAgregarParticipante.Text = "&Agregar";
      this.btnAgregarParticipante.UseVisualStyleBackColor = true;
      this.btnAgregarParticipante.Click += new EventHandler(this.btnAgregarParticipante_Click);
      this.txtNoCtrl.Location = new Point(62, 30);
      this.txtNoCtrl.Name = "txtNoCtrl";
      this.txtNoCtrl.Size = new Size(81, 20);
      this.txtNoCtrl.TabIndex = 1;
      this.lblNoCtrl.AutoSize = true;
      this.lblNoCtrl.Location = new Point(16, 30);
      this.lblNoCtrl.Name = "lblNoCtrl";
      this.lblNoCtrl.Size = new Size(39, 13);
      this.lblNoCtrl.TabIndex = 0;
      this.lblNoCtrl.Text = "No Ctrl";
      this.tabListasEstudiantes.Controls.Add((Control) this.lstEstudiantesNOpresentan);
      this.tabListasEstudiantes.Controls.Add((Control) this.label12);
      this.tabListasEstudiantes.Controls.Add((Control) this.dgSinDerecho);
      this.tabListasEstudiantes.Controls.Add((Control) this.label11);
      this.tabListasEstudiantes.Controls.Add((Control) this.txtCantidadEstudiantesED);
      this.tabListasEstudiantes.Controls.Add((Control) this.label9);
      this.tabListasEstudiantes.Controls.Add((Control) this.lstEstudiantesED);
      this.tabListasEstudiantes.Controls.Add((Control) this.label10);
      this.tabListasEstudiantes.Controls.Add((Control) this.txtCantidadEstudiantesPOO);
      this.tabListasEstudiantes.Controls.Add((Control) this.label7);
      this.tabListasEstudiantes.Controls.Add((Control) this.lstEstudiantesPOO);
      this.tabListasEstudiantes.Controls.Add((Control) this.label8);
      this.tabListasEstudiantes.Controls.Add((Control) this.txtCantidadEstudiantesFP);
      this.tabListasEstudiantes.Controls.Add((Control) this.label6);
      this.tabListasEstudiantes.Controls.Add((Control) this.lstEstudiantesFP);
      this.tabListasEstudiantes.Controls.Add((Control) this.label5);
      this.tabListasEstudiantes.Location = new Point(4, 22);
      this.tabListasEstudiantes.Name = "tabListasEstudiantes";
      this.tabListasEstudiantes.Size = new Size(1201, 626);
      this.tabListasEstudiantes.TabIndex = 4;
      this.tabListasEstudiantes.Text = "Listas de estudiantes";
      this.tabListasEstudiantes.UseVisualStyleBackColor = true;
      this.lstEstudiantesNOpresentan.FormattingEnabled = true;
      this.lstEstudiantesNOpresentan.Items.AddRange(new object[23]
      {
        (object) "21100152",
        (object) "21100156",
        (object) "21100157",
        (object) "21100165",
        (object) "21100177",
        (object) "21100185",
        (object) "21100186",
        (object) "21100187",
        (object) "21100196",
        (object) "21100206",
        (object) "21100207",
        (object) "21100209",
        (object) "21100211",
        (object) "21100215",
        (object) "20100221",
        (object) "21100237",
        (object) "21100239",
        (object) "21100247",
        (object) "20100255",
        (object) "21100284",
        (object) "21100291",
        (object) "21100292",
        (object) "21100296"
      });
      this.lstEstudiantesNOpresentan.Location = new Point(458, 68);
      this.lstEstudiantesNOpresentan.Name = "lstEstudiantesNOpresentan";
      this.lstEstudiantesNOpresentan.Size = new Size(160, 511);
      this.lstEstudiantesNOpresentan.TabIndex = 15;
      this.lstEstudiantesNOpresentan.SelectedIndexChanged += new EventHandler(this.lstEstudiantesNOpresentan_SelectedIndexChanged);
      this.label12.AutoSize = true;
      this.label12.Location = new Point(466, 38);
      this.label12.Name = "label12";
      this.label12.Size = new Size(152, 13);
      this.label12.TabIndex = 14;
      this.label12.Text = "Estudiantes que NO presentan";
      this.dgSinDerecho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgSinDerecho.Location = new Point(642, 68);
      this.dgSinDerecho.Name = "dgSinDerecho";
      this.dgSinDerecho.Size = new Size(498, 150);
      this.dgSinDerecho.TabIndex = 13;
      this.label11.AutoSize = true;
      this.label11.Location = new Point(639, 38);
      this.label11.Name = "label11";
      this.label11.Size = new Size(174, 13);
      this.label11.TabIndex = 12;
      this.label11.Text = "Estudiantes SIN derecho a examen";
      this.txtCantidadEstudiantesED.Location = new Point(517, 591);
      this.txtCantidadEstudiantesED.Name = "txtCantidadEstudiantesED";
      this.txtCantidadEstudiantesED.ReadOnly = true;
      this.txtCantidadEstudiantesED.Size = new Size(40, 20);
      this.txtCantidadEstudiantesED.TabIndex = 11;
      this.label9.AutoSize = true;
      this.label9.Location = new Point(445, 594);
      this.label9.Name = "label9";
      this.label9.Size = new Size(49, 13);
      this.label9.TabIndex = 10;
      this.label9.Text = "Cantidad";
      this.lstEstudiantesED.FormattingEnabled = true;
      this.lstEstudiantesED.Location = new Point(303, 68);
      this.lstEstudiantesED.Name = "lstEstudiantesED";
      this.lstEstudiantesED.Size = new Size(120, 511);
      this.lstEstudiantesED.TabIndex = 9;
      this.label10.AutoSize = true;
      this.label10.Location = new Point(311, 38);
      this.label10.Name = "label10";
      this.label10.Size = new Size(105, 13);
      this.label10.TabIndex = 8;
      this.label10.Text = "Lista Estudiantes ED";
      this.txtCantidadEstudiantesPOO.Location = new Point(318, 591);
      this.txtCantidadEstudiantesPOO.Name = "txtCantidadEstudiantesPOO";
      this.txtCantidadEstudiantesPOO.ReadOnly = true;
      this.txtCantidadEstudiantesPOO.Size = new Size(40, 20);
      this.txtCantidadEstudiantesPOO.TabIndex = 7;
      this.label7.AutoSize = true;
      this.label7.Location = new Point(246, 594);
      this.label7.Name = "label7";
      this.label7.Size = new Size(49, 13);
      this.label7.TabIndex = 6;
      this.label7.Text = "Cantidad";
      this.lstEstudiantesPOO.FormattingEnabled = true;
      this.lstEstudiantesPOO.Items.AddRange(new object[42]
      {
        (object) "21100152",
        (object) "21100156",
        (object) "21100157",
        (object) "21100165",
        (object) "21100177",
        (object) "21100185",
        (object) "21100186",
        (object) "21100187",
        (object) "21100196",
        (object) "21100206",
        (object) "21100207",
        (object) "21100209",
        (object) "21100211",
        (object) "21100215",
        (object) "20100221",
        (object) "21100237",
        (object) "21100239",
        (object) "21100247",
        (object) "20100255",
        (object) "21100284",
        (object) "21100291",
        (object) "21100292",
        (object) "21100296",
        (object) "21100777",
        (object) "21100154",
        (object) "21100160",
        (object) "21100164",
        (object) "20100187",
        (object) "21100192",
        (object) "19100792",
        (object) "20100222",
        (object) "20100230",
        (object) "21100232",
        (object) "21100259",
        (object) "20100246",
        (object) "20100247",
        (object) "21100267",
        (object) "21100277",
        (object) "21100280",
        (object) "21100290",
        (object) "21100294",
        (object) "21100302"
      });
      this.lstEstudiantesPOO.Location = new Point(169, 68);
      this.lstEstudiantesPOO.Name = "lstEstudiantesPOO";
      this.lstEstudiantesPOO.Size = new Size(120, 511);
      this.lstEstudiantesPOO.TabIndex = 5;
      this.lstEstudiantesPOO.SelectedIndexChanged += new EventHandler(this.lstEstudiantesPOO_SelectedIndexChanged);
      this.label8.AutoSize = true;
      this.label8.Location = new Point(177, 38);
      this.label8.Name = "label8";
      this.label8.Size = new Size(113, 13);
      this.label8.TabIndex = 4;
      this.label8.Text = "Lista Estudiantes POO";
      this.txtCantidadEstudiantesFP.Location = new Point(120, 591);
      this.txtCantidadEstudiantesFP.Name = "txtCantidadEstudiantesFP";
      this.txtCantidadEstudiantesFP.ReadOnly = true;
      this.txtCantidadEstudiantesFP.Size = new Size(40, 20);
      this.txtCantidadEstudiantesFP.TabIndex = 3;
      this.label6.AutoSize = true;
      this.label6.Location = new Point(48, 594);
      this.label6.Name = "label6";
      this.label6.Size = new Size(49, 13);
      this.label6.TabIndex = 2;
      this.label6.Text = "Cantidad";
      this.lstEstudiantesFP.FormattingEnabled = true;
      this.lstEstudiantesFP.Location = new Point(40, 68);
      this.lstEstudiantesFP.Name = "lstEstudiantesFP";
      this.lstEstudiantesFP.Size = new Size(120, 511);
      this.lstEstudiantesFP.TabIndex = 1;
      this.lstEstudiantesFP.SelectedIndexChanged += new EventHandler(this.lstEstudiantesFP_SelectedIndexChanged);
      this.label5.AutoSize = true;
      this.label5.Location = new Point(48, 38);
      this.label5.Name = "label5";
      this.label5.Size = new Size(103, 13);
      this.label5.TabIndex = 0;
      this.label5.Text = "Lista Estudiantes FP";
      this.btnAyuda.Location = new Point(463, 13);
      this.btnAyuda.Name = "btnAyuda";
      this.btnAyuda.Size = new Size(75, 23);
      this.btnAyuda.TabIndex = 1;
      this.btnAyuda.Text = "&Ayuda";
      this.btnAyuda.UseVisualStyleBackColor = true;
      this.btnAyuda.Click += new EventHandler(this.btnAyuda_Click);
      this.btnCambiarEstudiante.Location = new Point(926, 13);
      this.btnCambiarEstudiante.Name = "btnCambiarEstudiante";
      this.btnCambiarEstudiante.Size = new Size(111, 23);
      this.btnCambiarEstudiante.TabIndex = 2;
      this.btnCambiarEstudiante.Text = "&Cambiar estudiante";
      this.btnCambiarEstudiante.UseVisualStyleBackColor = true;
      this.btnCambiarEstudiante.Click += new EventHandler(this.btnCambiarEstudiante_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1233, 684);
      this.Controls.Add((Control) this.btnCambiarEstudiante);
      this.Controls.Add((Control) this.btnAyuda);
      this.Controls.Add((Control) this.tabExamen);
      this.Name = nameof (frmForma1);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "/";
      this.Load += new EventHandler(this.Form1_Load);
      this.tabExamen.ResumeLayout(false);
      this.tabExamenAsignado.ResumeLayout(false);
      this.tabExamenAsignado.PerformLayout();
      this.tabRegistrarEstudiantes.ResumeLayout(false);
      this.tabRegistrarEstudiantes.PerformLayout();
      ((ISupportInitialize) this.dgExamenesAsignadosManualmente).EndInit();
      ((ISupportInitialize) this.dgCantidadExamenes).EndInit();
      ((ISupportInitialize) this.dgExamenesAsignados).EndInit();
      this.grpNoCtrl.ResumeLayout(false);
      this.grpNoCtrl.PerformLayout();
      this.tabListasEstudiantes.ResumeLayout(false);
      this.tabListasEstudiantes.PerformLayout();
      ((ISupportInitialize) this.dgSinDerecho).EndInit();
      this.ResumeLayout(false);
    }
  }
}

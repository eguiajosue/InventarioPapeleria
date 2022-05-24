// Decompiled with JetBrains decompiler
// Type: ExamenDistancia.Configuracion
// Assembly: ExamenDistancia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 929C66B3-BE42-4041-A340-38CD61776081
// Assembly location: C:\Users\josue\OneDrive\Desktop\ExamenDistancia_2.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamenDistancia
{
  internal abstract class Configuracion
  {
    private string _strNombreMateria;
    private string _strClaveExamenAsignado;
    private string _strTemaExamen;
    private string _strTipoExamen;
    private int _intDuracionMinutos;
    private string _strNombreArchivoConfiguracion;
    public List<Examen> miListaExamenes = new List<Examen>();

    public string NombreMateria
    {
      get => this._strNombreMateria;
      set => this._strNombreMateria = !(value == "") ? value : throw new Exception("No deje en blanco el nombre de la materia");
    }

    public string ClaveExamenAsignado
    {
      get => this._strClaveExamenAsignado;
      set => this._strClaveExamenAsignado = !(value == "") ? value : throw new Exception("No deje en blanco la clave del examen asignado");
    }

    public string TemaExamen
    {
      get => this._strTemaExamen;
      set => this._strTemaExamen = !(value == "") ? value : throw new Exception("No deje en blanco el tema del examen");
    }

    public string TipoExamen
    {
      get => this._strTipoExamen;
      set => this._strTipoExamen = value;
    }

    public DateTime FechaInicio { get; set; }

    public int DuracionMinutos
    {
      get => this._intDuracionMinutos;
      set => this._intDuracionMinutos = value > 0 ? value : throw new Exception("Dato inválido en la duración del examen");
    }

    public string NombreArchivoConfiguracion
    {
      get => this._strNombreArchivoConfiguracion;
      set => this._strNombreArchivoConfiguracion = !(value == "") ? value : throw new Exception("No deje en blanco el nombre del archivo de configuración");
    }

    public bool BotonAyuda { get; set; }

    public string SitioWebAyuda { get; set; }

    public bool ImagenAyuda { get; set; }

    public string Instrucciones { get; set; }

    public DateTime CalcularHoraVencimiento() => this.FechaInicio.AddMinutes((double) this.DuracionMinutos);

    public override string ToString() => "\nFecha de vencimiento: " + this.FechaInicio.ToLongDateString() + "\nHora: " + this.FechaInicio.ToShortTimeString() + "\nMinutos: " + this.DuracionMinutos.ToString() + "\n\nFecha vencimiento: " + this.CalcularHoraVencimiento().ToString();

    public IEnumerable<Examen> ListaExamenes
    {
      get
      {
        foreach (Examen miExamen in this.miListaExamenes)
          yield return miExamen;
      }
    }

    public int ContarExamenes() => this.miListaExamenes.Count<Examen>();

    public Examen BuscarExamen(Estudiante miEstudiante)
    {
      Examen examen = new Examen();
      return this.miListaExamenes.Find((Predicate<Examen>) (x => x.Clave == miEstudiante.ExamenAsignado));
    }
  }
}

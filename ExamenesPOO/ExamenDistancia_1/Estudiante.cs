// Decompiled with JetBrains decompiler
// Type: ExamenDistancia.Estudiante
// Assembly: ExamenDistancia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 01C7BE8D-DB77-46F9-93C2-215C98B0A0C1
// Assembly location: C:\Users\josue\OneDrive\Desktop\ExamenDistancia_1.exe

using System;

namespace ExamenDistancia
{
  [Serializable]
  internal class Estudiante : IEquatable<Estudiante>
  {
    private string _strNoCtrl;
    private string _strExamenAsignado;
    private string _strMotivoSinDerecho;

    public string NoCtrl
    {
      get => this._strNoCtrl;
      set => this._strNoCtrl = value;
    }

    public string ExamenAsignado
    {
      get => this._strExamenAsignado;
      set => this._strExamenAsignado = value;
    }

    public string MotivoSinDerecho
    {
      get => this._strMotivoSinDerecho;
      set => this._strMotivoSinDerecho = value;
    }

    public Estudiante(string strNoCtrl, string strExamenAsignado)
    {
      this.NoCtrl = strNoCtrl;
      this.ExamenAsignado = strExamenAsignado;
    }

    public override string ToString() => "Estudiante: " + this.NoCtrl + "\nExamen asignado: " + this.ExamenAsignado;

    public bool Equals(Estudiante otroEstudiante) => this.NoCtrl.CompareTo(otroEstudiante.NoCtrl) == 0;
  }
}

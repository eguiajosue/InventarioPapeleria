// Decompiled with JetBrains decompiler
// Type: ExamenDistancia.Examen
// Assembly: ExamenDistancia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 929C66B3-BE42-4041-A340-38CD61776081
// Assembly location: C:\Users\josue\OneDrive\Desktop\ExamenDistancia_2.exe

using System;

namespace ExamenDistancia
{
  internal class Examen : IEquatable<Examen>
  {
    public string Clave { get; set; }

    public string Redaccion { get; set; }

    public string Inciso { get; set; }

    public override string ToString() => this.Clave + " - " + this.Decodificar(this.Redaccion.Substring(0, 20)) + " - " + this.Decodificar(this.Inciso);

    public bool Equals(Examen otroExamen) => this.Clave.CompareTo(otroExamen.Clave) == 0;

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
  }
}

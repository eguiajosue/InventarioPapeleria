// Decompiled with JetBrains decompiler
// Type: ExamenDistancia.ArchivoSecuencialSerializadoBinario`1
// Assembly: ExamenDistancia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 01C7BE8D-DB77-46F9-93C2-215C98B0A0C1
// Assembly location: C:\Users\josue\OneDrive\Desktop\ExamenDistancia_1.exe

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ExamenDistancia
{
  internal class ArchivoSecuencialSerializadoBinario<Tipo>
  {
    private string _strNombreArchivo;
    private FileStream flujo = (FileStream) null;
    private BinaryFormatter seriador = (BinaryFormatter) null;
    private long _lngPosicionAnterior;

    public string NombreArchivo
    {
      get => this._strNombreArchivo;
      set => this._strNombreArchivo = value;
    }

    public long PosicionAnterior
    {
      get => this._lngPosicionAnterior;
      set => this._lngPosicionAnterior = value;
    }

    public void CrearCarpeta(string strCarpeta)
    {
      if (strCarpeta.Length <= 0 || Directory.Exists(strCarpeta))
        return;
      Directory.CreateDirectory(strCarpeta);
    }

    public void CrearCarpeta()
    {
      string directoryName = Path.GetDirectoryName(this.NombreArchivo);
      if (directoryName.Length <= 0 || Directory.Exists(directoryName))
        return;
      Directory.CreateDirectory(directoryName);
    }

    public ArchivoSecuencialSerializadoBinario(string strNombreArchivo) => this.NombreArchivo = strNombreArchivo;

    ~ArchivoSecuencialSerializadoBinario() => this.Cerrar();

    private void Crear() => this.flujo = new FileStream(this.NombreArchivo, FileMode.Create);

    public void AbrirEnModoEscritura()
    {
      if (File.Exists(this.NombreArchivo))
        this.flujo = new FileStream(this.NombreArchivo, FileMode.Append);
      else
        this.Crear();
      this.seriador = new BinaryFormatter();
    }

    public bool RevisarSiExiste() => File.Exists(this.NombreArchivo);

    public void AbrirEnModoLectura()
    {
      this.flujo = File.Exists(this.NombreArchivo) ? new FileStream(this.NombreArchivo, FileMode.Open) : throw new Exception("NO existe el archivo " + this.NombreArchivo);
      this.seriador = new BinaryFormatter();
    }

    public void AbrirEnModoLecturaYEscritura()
    {
      if (File.Exists(this.NombreArchivo))
        this.flujo = new FileStream(this.NombreArchivo, FileMode.Open, FileAccess.ReadWrite);
      else
        this.Crear();
      this.seriador = new BinaryFormatter();
    }

    public void GrabarObjeto(Tipo miObjeto) => this.seriador.Serialize((Stream) this.flujo, (object) miObjeto);

    public Tipo LeerObjeto()
    {
      this.PosicionAnterior = this.flujo.Position;
      return (Tipo) this.seriador.Deserialize((Stream) this.flujo);
    }

    public void ModificarObjeto(Tipo miNuevoObjeto)
    {
      this.flujo.Seek(this.PosicionAnterior, SeekOrigin.Begin);
      this.GrabarObjeto(miNuevoObjeto);
    }

    public void Cerrar()
    {
      if (this.flujo == null)
        return;
      this.flujo.Close();
    }

    public void EliminarArchivo() => File.Delete(this.NombreArchivo);

    public void RenombrarArchivo(string strNuevoNombreArchivo) => File.Move(this.NombreArchivo, strNuevoNombreArchivo);
  }
}

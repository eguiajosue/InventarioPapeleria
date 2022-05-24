// Decompiled with JetBrains decompiler
// Type: EnviarEmail.CorreoElectronico
// Assembly: EnviarEmail, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 18E8F7DE-84B0-41DB-B957-D2041674B30F
// Assembly location: C:\Users\josue\OneDrive\Desktop\EnviarEmail.exe

using System;
using System.Net;
using System.Net.Mail;

namespace EnviarEmail
{
  internal class CorreoElectronico
  {
    private string _strEmailRemitente;
    private string _strPassword;
    private string _strDireccionServidor;
    private int _intPuerto;

    public CorreoElectronico(
      string strDireccionServidor,
      int intPuerto,
      string strEmailRemitente,
      string strPassword)
    {
      this.DireccionServidor = strDireccionServidor;
      this.Puerto = intPuerto;
      this.EmailRemitente = strEmailRemitente;
      this.Password = strPassword;
    }

    public string EmailRemitente
    {
      get => this._strEmailRemitente;
      set => this._strEmailRemitente = !(value == "") ? value : throw new Exception("No deje en blanco la dirección de correo electrónico del remitente");
    }

    public string Password
    {
      set => this._strPassword = !(value == "") ? value : throw new Exception("No deje en blanco la contraseña del correo electrónico del remitente");
      private get => this._strPassword;
    }

    private string DireccionServidor
    {
      get => this._strDireccionServidor;
      set => this._strDireccionServidor = !(value == "") ? value : throw new Exception("No deje en blanco la dirección del servidor SMTP");
    }

    public int Puerto
    {
      set
      {
        if (value <= 0)
          this._intPuerto = 25;
        else
          this._intPuerto = value;
      }
      private get => this._intPuerto;
    }

    public void Enviar(MailMessage miMensaje) => new SmtpClient(this.DireccionServidor, this.Puerto)
    {
      Credentials = ((ICredentialsByHost) new NetworkCredential(this.EmailRemitente, this.Password)),
      EnableSsl = true
    }.Send(miMensaje);
  }
}

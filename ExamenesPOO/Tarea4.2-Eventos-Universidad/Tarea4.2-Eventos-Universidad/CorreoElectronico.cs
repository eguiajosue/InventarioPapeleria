﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;

namespace Tarea4._2_Eventos_Universidad
{
    class CorreoElectronico
    {
        public CorreoElectronico(string strDireccionServidor, int intPuerto, string strEmailRemitente, string strPassword)
        {
            DireccionServidor = strDireccionServidor;
            Puerto = intPuerto;
            EmailRemitente = strEmailRemitente;
            Password = strPassword;
        }
        private string _strEmailRemitente;
        public string EmailRemitente
        {
            get { return _strEmailRemitente; }
            set
            {
                if (value == "")
                    throw new Exception("No deje en blanco la dirección de correo electrónico del remitente");
                else
                    _strEmailRemitente = value;
            }
        }
        private string _strPassword;
        public string Password
        {
            set
            {
                if (value == "")
                    throw new Exception("No deje en blanco la contraseña del correo electrónico del remitente");
                else
                    _strPassword = value;
            }
            private get { return _strPassword; }
        }
        private string _strDireccionServidor;
        private string DireccionServidor
        {
            get { return _strDireccionServidor; }
            set
            {
                if (value == "")
                    throw new Exception("No deje en blanco la dirección del servidor SMTP");
                else
                    _strDireccionServidor = value;
            }
        }
        private int _intPuerto;
        public int Puerto
        {
            set
            {
                if (value <= 0)
                    _intPuerto = 25;
                else
                    _intPuerto = value;
            }
            private get { return _intPuerto; }
        }
        public void Enviar(System.Net.Mail.MailMessage miMensaje)
        {
            System.Net.Mail.SmtpClient miCliente = new System.Net.Mail.SmtpClient(DireccionServidor, Puerto);
            // Autenticacion con el servidor
            miCliente.Credentials = new System.Net.NetworkCredential(EmailRemitente, Password);
            // Establece una conexión segura
            miCliente.EnableSsl = true;
            // Envía el mensaje
            miCliente.Send(miMensaje);
        }
    }
}

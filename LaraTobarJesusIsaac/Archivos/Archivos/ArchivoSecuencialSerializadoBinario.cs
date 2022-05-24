using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;// Para el uso de archivos
using System.Runtime.Serialization.Formatters.Binary;// Para el uso de la serialización

namespace Archivos
{
    internal class ArchivoSecuencialSerializadoBinario<Tipo>
    {
        private string _strNombreArchivo;
        public string NombreArchivo
        {
            get { return _strNombreArchivo; }
            private set { _strNombreArchivo = value; }
        }
        //Declaración de flujo del archivo
        private System.IO.FileStream flujo;
        private System.Runtime.Serialization.Formatters.Binary.BinaryFormatter seriador;
        //Constructor
        public ArchivoSecuencialSerializadoBinario(string strNombreArchivo)
        {
            NombreArchivo = strNombreArchivo;
        }
        //Destructor
        ~ArchivoSecuencialSerializadoBinario()
        {
            this.Cerrar();
        }
        //Método para crear el archivo
        private void Crear()
        {
            flujo = new FileStream(NombreArchivo, FileMode.Create);
            seriador = new BinaryFormatter();
        }
        //Método para abrir el archivo en modo escritura
        public void AbrirEnModoEscritura()
        {
            if (File.Exists(NombreArchivo))
            {
                flujo = new FileStream(NombreArchivo, FileMode.Append);
                seriador = new BinaryFormatter();
            }
            else
            {
                this.Crear();
            }
        }
        //Método para abrir el archivo en modo lectura
        public void AbrirEnModoLectura()
        {
            if (File.Exists(NombreArchivo))
            {
                flujo = new FileStream(NombreArchivo, FileMode.Open);
                seriador = new BinaryFormatter();
            }
            else
            {
                throw new Exception(" No existe el archivo" + NombreArchivo);
            }
        }
        //Método para abrir el archivo en modo lectura y escritura
        public void AbrirEnModoLecturaYEscritura()
        {
            if (File.Exists(NombreArchivo))
            {
                flujo = new FileStream(NombreArchivo, FileMode.Open, FileAccess.ReadWrite);
            }
            else
            {
                this.Crear();
            }
            seriador = new BinaryFormatter();
            return;
        }
        //Método para grabar un objeto en el archivo
        public void GrabarObjeto(Tipo miObjeto)
        {
            seriador.Serialize(flujo, miObjeto);
        }
        //Método para leer un objeto del archivo
        public Tipo LeerObjeto()
        {
            Tipo miObjeto;
            miObjeto = (Tipo)seriador.Deserialize(flujo);
            return (miObjeto);
        }
        //Propiedad de sólo lectura para determinar si se alcanza el final del archivo
        public bool FinArchivo
        {
            get
            {
                if (flujo.Position >= flujo.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //Método para cerrar el archivo
        public void Cerrar()
        {
            if (flujo != null)
            {
                flujo.Close();
            }
        }
        //Método para eliminar el archivo
        public void EliminarArchivo()
        {

            File.Delete(NombreArchivo);
        }
    }
}

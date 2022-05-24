using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public class Tienda
    {
        private List<Verano> listaVerano = new List<Verano>();
        private List<Primavera> listaPrimavera = new List<Primavera>();
        private List<Otoño> listaOtoño = new List<Otoño>();
        private List<Invierno> listaInvierno = new List<Invierno>();

        private string _strNombre;
        public string Nombre
        {
            get { return _strNombre; }
            set
            {
                if (value == "")
                    throw new Exception("El nombre de la tienda no puede estar vacía");
                else
                    _strNombre = value;
            }
        }

        private string _strDireccion;
        public string Direccion
        {
            get { return _strDireccion; }
            set
            {
                if (value == "")
                    throw new Exception("La dirección de la tienda no puede estar vacía");
                else
                    _strDireccion = value;
            }
        }

        private int _intTelefono;
        public int Telefono
        {
            get { return _intTelefono; }
            set
            {
                if (value < 0)
                    throw new Exception("El numero de teléfono no puede contener números negativos");
                else
                    _intTelefono = value;
            }
        }

        public IEnumerable<Verano> ListaVerano
        {
            get
            {
                foreach (Verano verano in listaVerano)
                    yield return verano;
                yield break;
            }
        }

        public IEnumerable<Primavera> ListaPrimavera
        {
            get
            {
                foreach (Primavera primavera in listaPrimavera)
                    yield return primavera;
                yield break;
            }
        }

        public IEnumerable<Otoño> ListOtoño
        {
            get
            {
                foreach (Otoño otoño in listaOtoño)
                    yield return otoño;
                yield break;
            }
        }

        public IEnumerable<Invierno> ListaInvierno
        {
            get
            {
                foreach (Invierno invierno in listaInvierno)
                    yield return invierno;
                yield break;
            }
        }
    }
}

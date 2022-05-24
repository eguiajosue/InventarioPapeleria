using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
 [Serializable]
    internal class Pelicula
    {
        private string _srtNombre;

        public string Nombre
        {
            get { return _srtNombre; }
            set { _srtNombre = value; }
        }
        private int _intCantidadDePeliculas;

        public int CantidadDePeliculas
        {
            get { return _intCantidadDePeliculas; }
            set { _intCantidadDePeliculas = value; }
        }
        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }
        private bool _blnPagada;

        public bool Pagada
        {
            get { return _blnPagada; }
            set { _blnPagada = value; }
        }
        private char _chrClasificacion;

        public char Clasificacion
        {
            get { return _chrClasificacion; }
            set { _chrClasificacion = value; }
        }
        private DateTime _dtmEstreno;

        public DateTime Estreno
        {
            get { return _dtmEstreno; }
            set { _dtmEstreno = value; }
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_I_Archivos
{
    [Serializable]
     class VideoJuego
    {
        private int _intCantidadDeJugadores;

        public int CantidadDeJugadores
        {
            get { return _intCantidadDeJugadores; }
            set { _intCantidadDeJugadores = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }

        private bool _blnVersionEspecial;

        public bool VersionEspecial
        {
            get { return _blnVersionEspecial; }
            set { _blnVersionEspecial = value; }
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

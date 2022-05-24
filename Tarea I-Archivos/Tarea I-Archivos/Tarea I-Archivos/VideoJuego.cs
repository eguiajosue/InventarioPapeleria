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
            set
            {
                if (value <= 0)
                    throw new Exception("El numero de jugadores no puede ser menor o igual a cero");
                else
                    _intCantidadDeJugadores = value;
            }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set
            {
                if (value == null)
                    throw new Exception("El nombre del videojuego no puede estar vacío");
                else
                    _strNombre = value;
            }
        }

        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set
            {
                if (value <= 0)
                    throw new Exception("El valor del videojuego no puede ser menor o igual a cero");
                else
                    _dblPrecio = value;
            }
        }

        private bool _blnVersionEspecial;

        public bool VersionEspecial
        {
            get { return _blnVersionEspecial; }
            set
            {
                if (value != true && value != false)
                    throw new Exception("Se tiene que especificar si el videojuego tiene una \"Versión Especial\" o no");

            }
        }

        private char _chrClasificacion;

        public char Clasificacion
        {
            get { return _chrClasificacion; }
            set
            {
                if (value == ' ')
                    throw new Exception("Se tiene que especificar la clasificación del videojuego");
            }
        }

        private DateTime _dtmEstreno;

        public DateTime Estreno
        {
            get { return _dtmEstreno; }
            set
            {
                if (value.Date > DateTime.Now)
                    throw new Exception("La fecha de estreno del videojuego no es válida");
            }
        }

    }
}

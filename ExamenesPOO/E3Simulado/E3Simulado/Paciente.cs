using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3Simulado
{
    public abstract class Paciente
    {
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private char _charSexo;

        public char Sexo
        {
            get { return _charSexo; }
            set { _charSexo = value; }
        }

        private int _intEdad;

        public int Edad
        {
            get { return _intEdad; }
            set { _intEdad = value; }
        }


        private double _dblCostoGeneralConsulta;

        public double CostoGeneralConsulta
        {
            get { return _dblCostoGeneralConsulta; }
            set { _dblCostoGeneralConsulta = value; }
        }

        public abstract double CalcularImporte();

    }
}

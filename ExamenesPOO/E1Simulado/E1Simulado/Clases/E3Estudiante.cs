using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1Simulado.Clases
{
    internal class E3Estudiante
    {
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private int _intSemestre;

        public int Semestre
        {
            get { return _intSemestre; }
            set { _intSemestre = value; }
        }

        private double _dblMateria1;

        public double Materia1
        {
            get { return _dblMateria1; }
            set { _dblMateria1 = value; }
        }

        private double _dblMateria2;

        public double Materia2
        {
            get { return _dblMateria2; }
            set { _dblMateria2 = value; }
        }

        private double _dblMateria3;

        public double Materia3
        {
            get { return _dblMateria3; }
            set { _dblMateria3 = value; }
        }

        public double CalcularPromedio()
        {
            return (Materia1 + Materia2 + Materia3) / 3;
        }
    }
}

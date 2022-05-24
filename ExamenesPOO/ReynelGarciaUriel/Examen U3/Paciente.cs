using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U3
{
    abstract class Paciente:IComparable<Paciente> 
    {
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private string _strSexo;

        public string Sexo
        {
            get { return _strSexo; }
            set { _strSexo = value; }
        }

        private int _intEdad;

        public int Edad
        {
            get { return _intEdad; }
            set { _intEdad = value; }
        }

        private double _dblCostoDeConsultaGeneral;

        public double CostoDeConsultaGeneral
        {
            get { return _dblCostoDeConsultaGeneral; }
            set { _dblCostoDeConsultaGeneral = value; }
        }

        public Paciente(string strNombre , string strSexo ,int intEdadint, double dblCostoDeConsultaGeneral )
        {

        }

        public abstract double CalcularPago();

        public int CompareTo(Paciente otroPaciente)
        {
            if (this.CalcularPago() > otroPaciente.CalcularPago())
            {
                return 1;
            }
            else if (this.CalcularPago() < otroPaciente.CalcularPago())
            {
                return -1;
            }
            else 
                return 0;
        }
    }
}

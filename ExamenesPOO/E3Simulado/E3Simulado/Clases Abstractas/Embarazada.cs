using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3Simulado.Clases_Pacientes
{
    internal class Embarazada : Paciente, IComparable<Embarazada>
    {
        private bool _esCesarea;

        public bool EsCesarea
        {
            get { return _esCesarea; }
            set { _esCesarea = value; }
        }

        public Embarazada(string strNombre, int intEdad, char charSexo, double dblCostoGeneral, bool blnEsCesarea)
        {
            Nombre = strNombre;
            Edad = intEdad;
            Sexo = charSexo;
            CostoGeneralConsulta = dblCostoGeneral;
            EsCesarea = blnEsCesarea;
        }

        public override double CalcularImporte()
        {
            if (EsCesarea)
                return CostoGeneralConsulta + 23000.50;
            else
                return CostoGeneralConsulta + 15000;
        }

        public int CompareTo(Embarazada otraEmbarazada)
        {
            if (this.CalcularImporte() > otraEmbarazada.CalcularImporte() )
                return 1;
            if (this.CalcularImporte() < otraEmbarazada.CalcularImporte())
                return -1;
            return 0;
        }

        public override string ToString()
        {
            string strSexo = "";

            if (this.Sexo == 'M')
                strSexo = "Masculino";
            if (this.Sexo == 'F')
                strSexo = "Femenino";

            string strNacimiento = "";

            if (this.EsCesarea)
                strNacimiento = "Cesarea";
            if (this.EsCesarea == false)
                strNacimiento = "Natural";

            return $"Nombre: {this.Nombre}\nSexo: {strSexo}\nEdad: {this.Edad}\nTipo de Nacimiento: {strNacimiento}\nCosto de la Consulta General: {this.CostoGeneralConsulta.ToString("C")}\nCosto Total: {this.CalcularImporte().ToString("C")}";
        }
    }
}

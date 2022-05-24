using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3Simulado.Clases_Abstractas
{
    internal class RayosX : Paciente, IComparable<RayosX>
    {
        private int _intCantidadPlacas;

        public int CantidadPlacas
        {
            get { return _intCantidadPlacas; }
            set { _intCantidadPlacas = value; }
        }

        public RayosX()
        {
            
        }

        public override double CalcularImporte()
        {
            return CostoGeneralConsulta + ( CantidadPlacas * 550.75 );
        }

        public int CompareTo(RayosX otroPaciente)
        {
            return this.CalcularImporte().CompareTo(otroPaciente.CalcularImporte());
        }

        public override string ToString()
        {
            string strSexo = "";

            if (this.Sexo == 'M')
                strSexo = "Masculino";
            if (this.Sexo == 'F')
                strSexo = "Femenino";

            return $"Nombre: {this.Nombre}\nSexo: {strSexo}\nEdad: {this.Edad}\nCantidad de Placas: {this.CantidadPlacas}\nCosto de la Consulta General: {this.CostoGeneralConsulta.ToString("C")}\nCosto Total: {this.CalcularImporte().ToString("C")}";
        }
    }
}

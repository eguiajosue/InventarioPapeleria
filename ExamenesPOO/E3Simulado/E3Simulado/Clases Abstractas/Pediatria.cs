using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3Simulado.Clases_Abstractas
{
    internal class Pediatria : Paciente, IComparable<Pediatria>
    {
        private int _intEdad;

        public int Edad
        {
            get { return _intEdad; }
            set { _intEdad = value; }
        }

        public Pediatria()
        {
            
        }

        public override double CalcularImporte()
        {
            if (Edad > 1)
                return CostoGeneralConsulta + 500;
            else
                return CostoGeneralConsulta + 700;
        }

        public int CompareTo(Pediatria otroPacientePediatria)
        {
            return this.CalcularImporte().CompareTo(otroPacientePediatria.CalcularImporte());
        }
    }
}

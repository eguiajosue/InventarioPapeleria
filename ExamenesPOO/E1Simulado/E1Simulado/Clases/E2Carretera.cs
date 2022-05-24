using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1Simulado.Clases
{
    internal class E2Carretera
    {
        private double _dblCantidadKilometros;

        public double CantidadKilometros
        {
            get { return _dblCantidadKilometros; }
            set { _dblCantidadKilometros = value; }
        }

        public double Convertir()
        {
            return CantidadKilometros / 1.609;
        }
    }
}

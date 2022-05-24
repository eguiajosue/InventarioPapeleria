using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1Simulado.Clases
{
    internal class E6Empleado
    {
        private int _intCantidadVentas;

        public int CantidadVentas
        {
            get { return _intCantidadVentas; }
            set { _intCantidadVentas = value; }
        }

        public double CalcularBono()
        {
            return CantidadVentas * 0.05;
        }
    }
}

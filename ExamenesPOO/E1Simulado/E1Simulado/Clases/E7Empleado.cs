using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1Simulado.Clases
{
    internal class E7Empleado
    {
        private double _dblSueldo;

        public double Sueldo
        {
            get { return _dblSueldo; }
            set { _dblSueldo = value; }
        }

        public double CalcularSueldo()
        {
            double dblBono = Sueldo * 0.04;
            return dblBono + Sueldo;
        }

    }
}

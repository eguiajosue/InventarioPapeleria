using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1Simulado.Clases
{
    internal class E1LitroAgua
    {
        private double _dblCantidadLitros;

        public double CantidadLitros
        {
            get { return _dblCantidadLitros; }
            set { _dblCantidadLitros = value; }
        }

        public double ConvertirLitrosAGalones()
        {
            return CantidadLitros / 3.785;
        }
    }
}

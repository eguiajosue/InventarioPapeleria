using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1Simulado.Clases
{
    internal class E5Vendedor
    {
        private string _strNombreVendedor;

        public string NombreVendedor
        {
            get { return _strNombreVendedor; }
            set { _strNombreVendedor = value; }
        }

        private int _intCantidadPaletasVendidas;

        public int CantidadPaletasVendidas
        {
            get { return _intCantidadPaletasVendidas; }
            set { _intCantidadPaletasVendidas = value; }
        }

        private double _dblPrecioPaleta;

        public double PrecioPaleta
        {
            get { return _dblPrecioPaleta; }
            set { _dblPrecioPaleta = value; }
        }

        public double CalcularTotalVentas()
        {
            return CantidadPaletasVendidas * PrecioPaleta;
        }
    }
}

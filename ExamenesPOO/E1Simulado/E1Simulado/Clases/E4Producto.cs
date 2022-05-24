using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1Simulado.Clases
{
    internal class E4Producto
    {
        private string _strNombreProducto;

        public string NombreProducto
        {
            get { return _strNombreProducto; }
            set { _strNombreProducto = value; }
        }

        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }

        public double CalcularIVA()
        {
            return Precio * 0.10;
        }
    }
}

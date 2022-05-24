using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Ropa
    {
        private string _strColor;

        public string Color
        {
            get { return _strColor; }
            set { _strColor = value; }
        }

        private string _strTalla;

        public string Talla
        {
            get { return _strTalla; }
            set { _strTalla = value; }
        }

        private string _strMarca;

        public string Marca
        {
            get { return _strMarca; }
            set { _strMarca = value; }
        }



    }
}

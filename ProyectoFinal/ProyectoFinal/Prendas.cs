using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class CamisaMangaCorta : Ropa
    {
        private bool _blnEstampado;
        public bool Estampado
        {
            get { return _blnEstampado; }
            set { _blnEstampado = value; }
        }
    }


    public class Shorts : Ropa
    {
        private string _strTipoDeMaterial;
        public string TipoDeMaterial
        {
            get { return _strTipoDeMaterial; }
            set { _strTipoDeMaterial = value; }
        }
    }

    public class TrajeDeBaño : Ropa
    {
        private int _intCantidadDePizas;
        public int CantidadDePiezas
        {
            get { return _intCantidadDePizas; }
            set { _intCantidadDePizas = value; }
        }
    }

    public class CamisaMangaLarga : Ropa
    {
        private string _strTipoDeMaterial;
        public string TipoDeMaterial
        {
            get { return _strTipoDeMaterial; }
            set { _strTipoDeMaterial = value; }
        }
    }

    public class Pants : Ropa
    {
        private string _strTipoDeMaterial;
        public string TipoDeMaterial
        {
            get { return _strTipoDeMaterial; }
            set { _strTipoDeMaterial = value; }
        }
    }

    public class Sueter : Ropa
    {
        private bool _strTieneCierre;
        public bool TieneCierre
        {
            get { return _strTieneCierre; }
            set { _strTieneCierre = value; }
        }
    }

    public class Chamarra : Ropa
    {
        private string _strTipoDeMaterial;
        public string TipoDeMaterial
        {
            get { return _strTipoDeMaterial; }
            set { _strTipoDeMaterial = value; }
        }
    }
}

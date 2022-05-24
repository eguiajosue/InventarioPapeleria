using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Tarea4._2_Eventos_Universidad
{
    internal class Universidad : INotifyPropertyChanged
    {
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private double _dblCostoColegiatura;

        public double CostoColegiatura
        {
            get { return _dblCostoColegiatura; }
            set 
            {
                if (_dblCostoColegiatura < 0)
                {
                    throw new Exception("No puede ingresar un numero menor a cero");
                }
                else
                {
                    _dblCostoColegiatura = value;
                    NotificarCambioPropiedad("CostoColegiatura");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotificarCambioPropiedad(string strNombrePropiedadCambiada)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(strNombrePropiedadCambiada));
        }

    }
}

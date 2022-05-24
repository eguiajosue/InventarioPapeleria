using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U3
{
    internal class PacienteEspecial: Paciente
    {
        private string _strTipoDeTratamiento;

        public string TipoDeTratamiento
        {
            get { return _strTipoDeTratamiento; }
            set { _strTipoDeTratamiento = value; }
        }

        public PacienteEspecial(string strNombre, string strSexo, int intEdadint, double dblCostoDeConsultaGeneral, string strTipoDeTratamiento):base(strNombre,  strSexo,  intEdadint, dblCostoDeConsultaGeneral)
        {

        }
        public override double CalcularPago()
        {
            if (this.TipoDeTratamiento == "Respirador Artifical")
            {
                return (this.CostoDeConsultaGeneral + 7600);
            }

            else if (this.TipoDeTratamiento == "Mediastino")
            {
                return (this.CostoDeConsultaGeneral + 6400);
            }
            else
            {
                return (this.CostoDeConsultaGeneral);
            }
        }

        
    }
}

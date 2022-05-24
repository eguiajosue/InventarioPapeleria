using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRenta
{
    //Ejercicio en Equipo
    //20100196, 20100192, 20100171, 20100183
    
    abstract class Vehiculo
    {
        //Propiedades
        public string Placa { get; set;}
        public bool Alquilado { get; set; }
        //Metodo abstracto
        public abstract double CalcularImporte();
    }
    class Autobus : Vehiculo
    {
        //Propiedades
        public double PrecioKilometro { get; set; }
        public double KilometroInicial { get; set; }
        public double KilometroFinal { get; set; }
        //Sobreescritura del metodo abstracto
        public override double CalcularImporte()
        {
            double dblPrecioTotal = 0;

            dblPrecioTotal = (KilometroInicial - KilometroFinal) * PrecioKilometro;

            return dblPrecioTotal;
        }
    }

    class Tractor : Vehiculo
    {
        //Propiedades
        public double PrecioPorDia { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        //Sobreescritura del metodo abstracto
        public override double CalcularImporte()
        {
            double dblPrecioTotal = 0;
            TimeSpan diferenciaDias = FechaFinal - FechaInicial;
            int intCantidadDias = diferenciaDias.Days;

            dblPrecioTotal = intCantidadDias * PrecioPorDia;

            return dblPrecioTotal;
        }
    }
}

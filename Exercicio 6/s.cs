using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    class Conversor
    {
        private double temperaturaCelsius;

        public Conversor(double temperaturaCelsius)
        {
            this.temperaturaCelsius = temperaturaCelsius;
        }

        public double CelsiusToFahrenheit()
        {
            return (temperaturaCelsius * 1.8) + 32;
        }
    }
}
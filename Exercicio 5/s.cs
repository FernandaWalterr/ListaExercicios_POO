using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Esfera
    {
        private double raio;

        public Esfera(double raio)
        {
            this.raio = raio;
        }

        public double CalcularVolume()
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
            return volume;
        }
    }
}
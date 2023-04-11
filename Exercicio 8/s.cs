using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    class LataDeOleo
    {
        private double raio;
        private double altura;

        public LataDeOleo(double raio, double altura)
        {
            this.raio = raio;
            this.altura = altura;
        }

        public double CalcularVolume()
        {
            double volume = Math.PI * raio * raio * altura;
            return volume;
        }
    }
}
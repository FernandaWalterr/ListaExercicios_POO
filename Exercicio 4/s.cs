using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Veiculo
    {
        private double quilometragemInicial;
        private double quilometragemFinal;
        private double consumoCombustivel;

        public Veiculo(double quilometragemInicial, double quilometragemFinal, double consumoCombustivel)
        {
            this.quilometragemInicial = quilometragemInicial;
            this.quilometragemFinal = quilometragemFinal;
            this.consumoCombustivel = consumoCombustivel;
        }

        public double CalcularConsumo()
        {
            double quilometrosPercorridos = quilometragemFinal - quilometragemInicial;
            double consumoTotal = consumoCombustivel * quilometrosPercorridos;
            return consumoTotal;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    class Aluno
    {
        public double nota1;
        public double nota2;

        public double CalcularMediaPonderada()
        {
            double peso1 = 2;
            double peso2 = 3;

            double mediaPonderada = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);

            return mediaPonderada;
        }
    }
}
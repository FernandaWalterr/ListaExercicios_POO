using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    class Aluno
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double CalcularMediaHarmonica()
        {
            return 3.0 / ((1.0 / Nota1) + (1.0 / Nota2) + (1.0 / Nota3));
        }
    }
}

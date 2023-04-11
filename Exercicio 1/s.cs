using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{

    class CaixaRetangular
    {
        public int comprimento;
        public int largura;
        public int altura;

        public decimal CalcularVolume()
        {
            return comprimento * largura * altura;
        }
    }
}
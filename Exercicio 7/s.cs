using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Vendedor
    {
        public double SalarioBase { get; set; }
        public double TotalVendas { get; set; }

        public double CalcularSalarioTotal(double percentualComissao)
        {
            double comissao = TotalVendas * (percentualComissao / 100);
            double salarioTotal = SalarioBase + comissao;
            return salarioTotal;
        }
    }
}
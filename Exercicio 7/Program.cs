namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria uma instância da classe Vendedor
            Vendedor vendedor = new Vendedor();

            Console.Write("Informe o salário base do vendedor: ");
            vendedor.SalarioBase = double.Parse(Console.ReadLine());

            Console.Write("Informe o total de vendas do vendedor: ");
            vendedor.TotalVendas = double.Parse(Console.ReadLine());

            // obtém o percentual de comissão do usuário
            Console.Write("Informe o percentual de comissão do vendedor: ");
            double percentualComissao = double.Parse(Console.ReadLine());

            // calcula o salário total do vendedor e exibe o resultado
            double salarioTotal = vendedor.CalcularSalarioTotal(percentualComissao);
            Console.WriteLine($"O salário total do vendedor é {salarioTotal:C}");
        }
    }
}
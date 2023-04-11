using System.Security.Cryptography.X509Certificates;

namespace Exercicio_4
{
    class Veiculo
    {
        static void Main(string[] args)
        {

            double quilometragemInicial = 20;
            double quilometragemFinal = 45;
            double consumoCombustivel = 15;

            Veiculo veiculo = new Veiculo(quilometragemInicial, quilometragemFinal, consumoCombustivel);

            double consumoTotal = veiculo.CalcularConsumo();

            Console.WriteLine($"O consumo total de combustível foi de {consumoTotal} litros.");
        }
    }
}
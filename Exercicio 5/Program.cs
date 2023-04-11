namespace Exercicio_5
{
    class Esfera
    {
        class Program
        {
            static void Main(string[] args)
            {
                Esfera esfera = new Esfera(raio);

                double raio = 10;
                double volume = esfera.CalcularVolume();

                Console.WriteLine($"O volume da esfera é de {volume} unidades cúbicas.");
            }
        }
    }
}
namespace Exercicio_8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe o raio da lata de óleo: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a altura da lata de óleo: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            LataDeOleo lata = new LataDeOleo(raio, altura);
            double volume = lata.CalcularVolume();

            Console.WriteLine("O volume da lata de óleo é: {0} litros", volume);
            Console.ReadLine();
        }
    }

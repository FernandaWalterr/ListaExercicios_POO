namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Celsius: ");
            double temperaturaCelsius = double.Parse(Console.ReadLine());

            Conversor conversor = new Conversor(temperaturaCelsius);
            double temperaturaFahrenheit = conversor.CelsiusToFahrenheit();

            Console.WriteLine("A temperatura em Fahrenheit é: " + temperaturaFahrenheit);
            Console.ReadKey();
        }
    }
}
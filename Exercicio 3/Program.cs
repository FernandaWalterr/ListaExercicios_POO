namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();

            cilindro.altura = 10;
            cilindro.raio = 15;

            Console.WriteLine("O volume do cilindro é: " + cilindro.Volume());
        }
    }
}
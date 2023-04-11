namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            aluno1.Nota1 = 5.5;
            aluno1.Nota2 = 7.5;
            aluno1.Nota3 = 9.0;

            double mediaHarmonica = aluno1.CalcularMediaHarmonica();
            Console.WriteLine($"A média harmônica do aluno é {mediaHarmonica:N2}");
        }
    }
}
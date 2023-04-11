namespace Exercicio_10
{
    class CalcularMediaPonderada
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            aluno.nota1 = 8;
            aluno.nota2 = 9;

            double mediaPonderada = aluno.CalcularMediaPonderada();

            // Exibe o resultado
            Console.WriteLine("A média ponderada do aluno é: " + mediaPonderada);
        }
    }
}
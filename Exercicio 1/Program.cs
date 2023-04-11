
    using System;

    namespace Exercicio_1

    class CaixaRetangular
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixa = new CaixaRetangular();

        // Chamando o método para calcular o volume e imprimindo o resultado
        caixa.largura = 5;
        caixa.altura = 5;
        caixa.comprimento = 10;

            Console.WriteLine("O volume da caixa é de: " + caixa.CalcularVolume());
        }
    }
}
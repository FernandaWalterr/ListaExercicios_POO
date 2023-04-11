using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    internal class Temperatura
    {
        public void ConversorParaCelsius()
        {
            int TemperaturaFahrenheit;

            Console.WriteLine("Digite a temperatura em Fahrenheit:");
            TemperaturaFahrenheit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A temperatura em Celsius é: " + ((TemperaturaFahrenheit - 32) / 1.8 + "°C"));
        }
    }
}

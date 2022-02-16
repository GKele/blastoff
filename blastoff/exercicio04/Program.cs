using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempC;

            Console.WriteLine("Digite a temperatura em Celsius: ");
            tempC = Convert.ToDouble(Console.ReadLine());

            var tempF = ((tempC * 9/5) + 32.0);

            Console.WriteLine("A temperatura em Fahrenheit é {0}°F", tempF);
        }
    }
}

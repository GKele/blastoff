using System;

namespace exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, numero, fatorial;
            Console.WriteLine("Informe um número:");
            numero = double.Parse(Console.ReadLine());

            fatorial = numero;
            for (i = numero - 1; i >= 1; i--)
            {
                Console.WriteLine($"{fatorial} * {i}");

                fatorial = fatorial * i;

                Console.WriteLine($"i={i}");
                Console.WriteLine($"fatorial={fatorial}");
                Console.WriteLine("  ");
            }
            Console.WriteLine("A fatorial de {0} é {1} ",numero, fatorial );
        }
    }
}

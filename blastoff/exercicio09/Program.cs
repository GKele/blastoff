using System;

namespace exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x <= 10; x++)
            {
                Console.WriteLine(numero + " * " + x + " = " + numero * x);
            }
        }
    }
}

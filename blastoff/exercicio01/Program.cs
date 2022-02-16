using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int I = 10;
            int J = 20;
            int K = 12;
            int X = 9;
            int Y = 20;

            int soma = I + J + K + X + Y;
            var media = (double)soma / 5;

            Console.WriteLine("A média das idades é " + media);
        }
    }
}

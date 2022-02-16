using System;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1%num2 == 0 || num2%num1 == 0)
            {
                Console.WriteLine("{0} e {1} são múltiplos", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} e {1} não são múltiplos!", num1, num2);
            }
        }
    }
}

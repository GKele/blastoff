using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Primeiro número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Terceiro número: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine("{0} é o menor número", a);
            }
            if (b < c && b < a)
            {
                Console.WriteLine("{0} é o menor número", b);
            }
            if (c < a && c < b)
            {
                Console.WriteLine("{0} é o menor número", c);
            }
        }
    }
}

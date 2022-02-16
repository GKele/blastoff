using System;

namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaA, horaB;

            Console.WriteLine("Digite o horário de início da partida:");
            horaA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o horário do fim da partida:");
            horaB = Convert.ToInt32(Console.ReadLine());

            var duracao = horaB - horaA;

            Console.WriteLine("A duração da partidade foi de {0}h", duracao);

        }
    }
}

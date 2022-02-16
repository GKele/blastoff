using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia = 450;
            int combustivel = 32;

            var consumo = (double) distancia / combustivel;

            Console.WriteLine("Dada a distancia de " + distancia + "KM e o combustível de " + combustivel + "L, o consumo médio foi de {0}KM/L",consumo);
        }
    }
}

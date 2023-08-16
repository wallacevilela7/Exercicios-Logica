using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro: ");
            int x = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Os divisores de {x}: ");
            for (int i = 1; i <= x; i++)
            {
                if(x % i == 0 )
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
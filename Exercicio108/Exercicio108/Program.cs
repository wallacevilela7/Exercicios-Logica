using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = LerInteiros(Console.ReadLine());

            int x = a[1] - a[0]; // Calcula a diferença entre o segundo e o primeiro elemento
            int y = a[2] - a[1]; // Calcula a diferença entre o terceiro e o segundo elemento

            if (y > x || (x == y && x > 0))
            {
                Console.WriteLine(":)");
            }
            else
            {
                Console.WriteLine(":(");
            }
        }

        static int[] LerInteiros(string input)
        {
            string[] valores = input.Split(' ');
            int[] inteiros = new int[valores.Length];

            for (int i = 0; i < valores.Length; i++)
            {
                inteiros[i] = int.Parse(valores[i]);
            }

            return inteiros; 
        }
    }
}
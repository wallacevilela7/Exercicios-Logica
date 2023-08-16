/*
 * Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
   Lembrando que, por definição, fatorial de 0 é 1.
 */
using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());
            int ft = 1;

            for(int i = 1; i <= n; i++)
            {
                ft = ft * i;
            }
            Console.WriteLine(ft);
        }
    }
}
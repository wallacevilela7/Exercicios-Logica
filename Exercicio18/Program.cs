/*
 * Leia um valor inteiro X (1 <= X <= 100). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o 
    X, se for o caso
 */

using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro entre 1 e 100");

            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
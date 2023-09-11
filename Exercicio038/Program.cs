/*
 * Fazer um programa para ler um número inteiro N e uma matrix de ordem N contendo números inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores negativos na matriz.
 */
using System;
using System.Runtime.Serialization.Formatters;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    string[] values = Console.ReadLine().Split(' ');

                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
        }
    }
}
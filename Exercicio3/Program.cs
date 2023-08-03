/*
 * Fazer um programa para ler quatro valores inteiros A,B,C e D. A seguir, calcule e mostre a diferença
 * do produto de A E B pelo produto de C e D.
 */

using System;
using System.Globalization;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor de A:  ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Valor de B:  ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Valor de C:  ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Valor de D:  ");
            int d = int.Parse(Console.ReadLine());


            Console.WriteLine();
            int dif = (a * b) - (c * d);
            Console.WriteLine($"Diferença de '(A * B) - (C * D)' é = {dif}");
        }
    }
}
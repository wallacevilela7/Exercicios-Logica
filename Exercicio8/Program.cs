/*
 * Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar
 */

using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(ParOuImpar(n));
        }
        static string ParOuImpar(int x)
        {
            return x % 2 == 0 ? "É par!" : "É impar!";
        }
    }
}
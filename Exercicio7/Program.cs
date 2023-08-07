/*
 * Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
 */

using System;
using System.Threading.Channels;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(VerificaPar(n));

        }
        static string VerificaPar(int x)
        {
            return x > 0 ? "É positivo" : "É negativo";
        }
    }
}
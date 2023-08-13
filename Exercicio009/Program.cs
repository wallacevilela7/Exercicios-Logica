/*
 *  Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
    Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
    ordem crescente ou decrescente.
 */

using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número inteiro B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"A = {a}\nB = {b}\n"+ VerifyMutiplicity(a,b));
        }
        static string VerifyMutiplicity(int x, int y)
        {
            if(x % y == 0 || y % x == 0)
            {
                return "São múltiplos";
            }
            return "Não são múltiplos";
        }
    }
}
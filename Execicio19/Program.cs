/*
 * Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
 */

using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite os {x} desejados: ");
            for (int i = 1; i <= x; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num >= 10 && num <= 20)
                {
                    Console.WriteLine($"{num} - in");
                }
                else
                {
                    Console.WriteLine($"{num} - out");
                }
            }
        }
    }
}
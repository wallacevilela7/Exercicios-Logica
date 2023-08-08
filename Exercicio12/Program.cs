/*
 * Fazer um programa para ler três números inteiros e mostrar na tela o maior deles.
 */


using System;
using System.Reflection.Metadata.Ecma335;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Maior = {FindBigger(a, b, c)}");
        }
        static int FindBigger(int x, int y, int z)
        {
            int bigger = 0;

            if(x > y && x > z)
            {
                bigger = x;
            }
            else if(y > x && y > z)
            {
                bigger = y;
            }
            else if(z > x && z > y)
            {
                bigger = z;
            }


        return bigger;
        }
    }
}
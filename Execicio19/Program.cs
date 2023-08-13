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

            int arrayLenght = x;
            int[] array = new int[arrayLenght];

            Console.WriteLine($"Digite os {x} desejados: ");
            
            for(int i = 0; i <= arrayLenght - 1; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            
            for(int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] >= 10 && array[i] <= 20)
                {
                    Console.WriteLine($"{array[i]} - in");
                }
                else
                {
                    Console.WriteLine($"{array[i]} - out");
                }
            }
            
        }
    }
}
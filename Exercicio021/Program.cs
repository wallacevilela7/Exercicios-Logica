/*
 * Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo 
segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
 */

using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para quantos pares de números será testada a divisão?  ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.Write("Valor A: ");
                double x1 = double.Parse(Console.ReadLine());
                Console.Write("Valor B: ");
                double x2 = double.Parse(Console.ReadLine());
                
                
                if(x2 == 0)
                {
                    Console.WriteLine("Divisão impossível");
                }
                else
                {
                    double result = x1 / x2;
                    Console.WriteLine($"Resultado: {result}");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
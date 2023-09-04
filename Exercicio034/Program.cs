/*Fazer um programa para ler um número N e a altura de N pessoas. Armazena as N alturas em um vetor. 
 Em seguida, mostrar a altura média dessas pessoas*/

using System;
using System.Globalization;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o numero de pessoas");
            int qtd = int.Parse(Console.ReadLine());

            double[] vect = new double[qtd];


            for(int i =0; i < qtd; i++)
            {
                Console.WriteLine($"Altura pessoa {i+1}: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double media = vect.Average();
            Console.WriteLine("----------------------");
            Console.WriteLine($"A altura média é {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}
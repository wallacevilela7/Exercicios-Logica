/*
    Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3
    valores reais, cada um deles com uma cada decimal. Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo tem peso 3 e o terceiro valor tem peso 5.
 */

using System;
using System.Globalization;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de testes");
            int n = int.Parse(Console.ReadLine());

            double x1, x2, x3,avg;

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite 3 valores reais:  ");
                x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                avg = (x1 * 2 + x2 * 3 + x3 * 5) / 10.0;
                Console.WriteLine($"Média: {avg.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
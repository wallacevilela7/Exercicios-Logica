/*
 * Fazer um programa que leia três valores com ponto flutuante de dupla precisão a b e c. Em seguida, calcule e mostre:
 * 1 - a area do circulo de raio c;
 */

using System;
using System.Globalization;
namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero A:");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero B:");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero C:");
            double C = double.Parse(Console.ReadLine());


            double areaCirculo = Math.PI * Math.Pow(C, 2);
            Console.WriteLine($"A area do círculo com raio c é: {areaCirculo.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
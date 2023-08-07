/*
 * Fazer um programa que leia três valores com ponto flutuante de dupla precisão a b e c. Em seguida, calcule e mostre:
 * 1 - a area do circulo de raio c;
 * 2 - a área do triangulo retangulo que tem A por base C por altura;
 * 3 - a área do trapézio que tem A e B por base e C por altura.
 * 4 - a área do quadrado que tem lado B;
 * 5 - a área do retângulo que tem lados A e B;
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
            Console.WriteLine($"A area do Círculo: {areaCirculo.ToString("F2", CultureInfo.InvariantCulture)}");

            double areaTriangulo = (A * C)/2;
            Console.WriteLine($"A area do Triângulo: {areaTriangulo.ToString("F2", CultureInfo.InvariantCulture)}");
            
            double areaTrapezio = ((A + B)*C) / 2;
            Console.WriteLine($"A area do Trapézio: {areaTrapezio.ToString("F2", CultureInfo.InvariantCulture)}");

            double areaQuadrado = B * B;
            Console.WriteLine($"A area do Quadrado: {areaQuadrado.ToString("F2", CultureInfo.InvariantCulture)}");

            double areaRetangulo = A * B;
            Console.WriteLine($"A area do Retângulo: {areaRetangulo.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
using Exercicio043;
using System;
using System.Collections.Concurrent;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os valores dos lados do retângulo");
            Console.Write("Largura: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double height = double.Parse(Console.ReadLine());

            Retangulo rtg = new Retangulo(width, height);

            Console.WriteLine("");
            Console.WriteLine("Dados do Retangulo: ");
            Console.WriteLine($"Área: {rtg.Area()}");
            Console.WriteLine($"Perímetro: {rtg.Perimetro()}");
            Console.WriteLine($"Diagonal: {rtg.Diagonal()}");
        }
    }
}
/*
 * Fazer um programa para ler os valores de largura e altura de um retângulo. Em seguida, mostrar na tela o valor de 
 * sua área, perímetro e diagonal.
 */

using Exercicio027.Entities;
using System.Globalization;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Console.Write("Largura: ");
            double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Retangulo r1 = new Retangulo(width, height);
            Console.WriteLine($"Area = {r1.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perimetro = {r1.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
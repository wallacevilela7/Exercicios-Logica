using System;
using System.Globalization;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter com o primeiro valor (A)");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter com o segundo valor (B)");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Enter com o terceiro valor (C)");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double delta = Math.Pow(b,2) - (4 * a * c);

        }
    }
}
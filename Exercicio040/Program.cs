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
            
            double x1 = (-b + Math.Sqrt(delta)/ (2 * a));
            double x2 = (-b - Math.Sqrt(delta)/ (2 * a));


            if(x1 <= 0 || x2 <= 0)
            {
                Console.WriteLine("Impossível calcular");
            }
            else
            {
                Console.WriteLine($"R1 {x1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R1 {x2.ToString("F5", CultureInfo.InvariantCulture)}");
            }
            //quando é impossível calcular as raizes????
        }
    }
}
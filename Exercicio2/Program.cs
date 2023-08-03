//Faça um porograma para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo
//com quatro casas decimais conforme exemplo.

using System;
using System.Globalization;

namespace Ex {
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio: ");
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Area do círculo: {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
/*
 Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.
    Calcule o valor total a ser pago e a quantidade de peças.
 */

using System;
using System.Globalization;
using System.Threading.Channels;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código da peça 1: ");
            int cod1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a quantidade de peças 1: ");
            int qtd1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código da peça 1: ");
            double vu1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código da peça 2: ");
            int cod2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a quantidade de peças 2: ");
            int qtd2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor unitario da peça 2: ");
            double vu2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int qtdTotal = qtd1 + qtd2;
            double totalValue = vu1 + vu2;

            Console.Clear();
            Console.WriteLine($"Quantidade de peças: {qtdTotal} peças");
            Console.WriteLine($"Valor total a pagar: R${totalValue.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}
/*
 Fazer um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais. 
 Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.
 */

using Exercicio031;
using System.Globalization;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotacao do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar?  ");
            double qtdCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorPagar = ConversorDeMoeda.CalcDolarPraReal(cotacao, qtdCompra);

            Console.WriteLine($"Valor a ser pago em reais: R${valorPagar.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
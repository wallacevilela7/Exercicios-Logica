/*Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N produtos. Armazene os N produitos em um vetor. Em seguida, mostrar o preço médio dos produtos */

using System;
using System.Globalization;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            Products[] produtcs = new Products[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Produto {i + 1}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produtcs[i] = new Products(name, price);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += produtcs[i].Price;
            }

            Console.WriteLine();
            double media = sum / n;
            Console.WriteLine($"Média de preço dos produtos: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public class Products
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public Products(string name, double price)
            {
                Name = name;
                Price = price;
            }
        }
    }
}
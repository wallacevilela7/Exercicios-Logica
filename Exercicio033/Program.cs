using Exercicio033.Entities;
using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int rented = int.Parse(Console.ReadLine());

            Client[] clients = new Client[10];

            for(int i = 0; i < rented; i++)
            {
                Console.WriteLine($"Rent #{i+1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
            }
        }
    }
}
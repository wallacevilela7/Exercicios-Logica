﻿using Exercicio033.Entities;
using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Client[] clients = new Client[10];

            Console.Write("Quantos quartos serão alugados? ");
            int rented = int.Parse(Console.ReadLine());

            for(int i = 0; i < rented; i++)
            {
                Console.WriteLine($"Aluguel #{i+1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                clients[room] = new Client(name, email);
                Console.WriteLine();
            }
            for(int i = 0; i < clients.Length; i++)
            {
                if (clients[i] != null)
                {
                    Console.WriteLine($"{i} {clients[i]}");
                }
            }
        }
    }
}
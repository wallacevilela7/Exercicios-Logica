/*
 * Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe
 * por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas cadas decimais.
 */

using System;
using System.Net.WebSockets;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do funcionário: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de horas trabalhadas: ");
            double hrs = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de cada hora: ");
            double valuePerHour = double.Parse(Console.ReadLine());

            double salary = valuePerHour * hrs;

            Console.Clear();
            Console.WriteLine($"Id : {id}");
            Console.WriteLine($"Salary:  R${salary}");
        }
    }
}
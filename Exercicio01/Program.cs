//Faça um exercicio para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa.

using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira dois numeros inteiros");
            Console.Write("Primeiro: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Segundo: ");
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;
            Console.WriteLine("Soma: " + soma);
        }
    }
}
/*
 * Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
   seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em 
   nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”
 */

using System;
using System.Globalization;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(n < 0 || n > 100)
            {
                Console.WriteLine("Fora de Intervalo");
            }
            else if(n <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(n > 25 && n <= 50)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if(n > 50 && n <= 75)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo [75,100]");
            }
        }
    }
}
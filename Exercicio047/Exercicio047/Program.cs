//Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, uma linha em branco e em seguida, os valores na sequência como foram lidos.

using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();

            string[] stringNumbersArray = Console.ReadLine().Split(' ');

            foreach (string stringNumber in stringNumbersArray)
            {
                int number = Convert.ToInt32(stringNumber);
                l1.Add(number);
            }

            l1.Sort();
            foreach(int number in l1)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            foreach (string stringNumber in stringNumbersArray)
            {
                Console.WriteLine(stringNumber);
            }
        }
    }
}
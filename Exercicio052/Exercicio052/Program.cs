using System;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = int.Parse(Console.ReadLine());
            int v2 = int.Parse(Console.ReadLine());

            int maior = AchaMaior(v1, v2);
            int menor = AchaMenor(v1, v2);

            int somaImpares = int.MinValue;

            for(int i = menor + 1; i < maior; i++)
            {
                if(i % 2 != 0)
                    somaImpares += i;
            }

            Console.WriteLine(somaImpares);

        }

        static int AchaMaior(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
        static int AchaMenor(int n1, int n2)
        {
            return n1 < n2 ? n1 : n2;
        }
    }
}
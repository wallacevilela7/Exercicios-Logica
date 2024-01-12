using System;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                if(i % 2 == 0 )
                    Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
            }

        }
    }
}
﻿using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Xml;

//Beecrowd - 1041 Coordenadas de um ponto

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string l1 = Console.ReadLine();
            string[] values = l1.Split(' ');
            double x = double.Parse(values[0]);
            double y = double.Parse(values[1]);

            if(x == 0 && y == 0)
                Console.WriteLine("Origem");
            else if (x > 0 && y > 0)
                Console.WriteLine("Q1");
            else if (x < 0 && y < 0)
                Console.WriteLine("Q3");
            else if (x > 0 && y < 0)
                Console.WriteLine("Q4");
            else if (x < 0 && y > 0)
                Console.WriteLine("Q2");
            else if (x != 0 && y == 0)
                Console.WriteLine("Eixo X");
            else if (x == 0 && y != 0)
                Console.WriteLine("Eixo Y");
        }
    }
}
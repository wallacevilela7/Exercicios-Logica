using System;
using System.ComponentModel.Design;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.MinValue; int y = int.MaxValue;

            while (x != 0 || y != 0)
            {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                Console.WriteLine(VerificaQuadrate(x,y));

            }

        }
        static string VerificaQuadrate(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                return null;
            }
            else if (x > 0 && y > 0)
            {
                return "Primeiro";
            }
            else if (x > 0 && y < 0)
            {
                return "Quarto";
            }
            else if (x < 0 && y < 0)
            {
                return "Terceiro";
            }
            else if (x < 0 && y > 0)
            {
                return "Segundo";

            }
            else
            {
                return "";
            }
        }
    }
}
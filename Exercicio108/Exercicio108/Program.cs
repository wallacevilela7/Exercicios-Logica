using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            int dia1, dia2, dia3;
            string[] input = new string[0];

            input = Console.ReadLine().Split(' ');
            dia1 = int.Parse(input[0]);
            dia2 = int.Parse(input[1]);
            dia3 = int.Parse(input[2]);

            string emoji = ChecaCondicao(dia1, dia2, dia3);
            Console.WriteLine(emoji);
        }

        static string ChecaCondicao(int d1, int d2, int d3)
        {
            if (d2 > d1)
            {
                if ((d2 <= d3))
                {
                    return ":)";
                }
            }


            return "";
        }
    }
}
using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            string[] input = new string[0];
            int rc, r1, r2;

            x = int.Parse(Console.ReadLine());

            int i = 0;
            while(i < x)
            {
                input = Console.ReadLine().Split(' ');
                r1 = int.Parse(input[0]);
                r2 = int.Parse(input[1]);

                rc = r1 + r2;

                Console.WriteLine(rc);
                i++;
            }
        }
    }
}

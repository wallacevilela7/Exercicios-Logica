using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopControl = 0;
            int aux = 7;

            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = aux; j <= 15; j--)
                {
                    loopControl++;
                    Console.WriteLine($"I={i} J={j}");
                    if(loopControl == 3) { loopControl = 0; aux += 2; break; }
                }
            }

        }
    }
}
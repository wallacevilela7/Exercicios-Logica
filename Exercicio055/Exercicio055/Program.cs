using System;
using System.Runtime.Intrinsics.X86;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopControl = 0;
            double aux = 1;

            for (double i = 0; i <= 2.0; i += 0.2)
            {
                for (double j = aux; j <= 20; j++)
                {
                    loopControl++;
                    if (IsAlmostEqual(i, 2.0))
                    {
                        Console.WriteLine($"I={i:F0} J={j:F0}");
                    }
                    else if (IsAlmostZero(i % 1))
                    {
                        Console.WriteLine($"I={i:F0} J={j:F0}");
                    }
                    else
                    {
                        Console.WriteLine($"I={i:F1} J={j:F1}");
                    }
                    if (loopControl == 3) { loopControl = 0; aux += 0.2; break; }
                }
            }
        }
        static bool IsAlmostZero(double value, double tolerance = 1e-10)
        {
            return Math.Abs(value) < tolerance;
        }
        static bool IsAlmostEqual(double a, double b, double tolerance = 1e-10)
        {
            return Math.Abs(a - b) < tolerance;
        }
    }
}

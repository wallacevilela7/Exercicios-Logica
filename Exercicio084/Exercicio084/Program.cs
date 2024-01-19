using System.Buffers;

long[] serieFibonacci = new long[61];

for(int i = 0; i < 61; i++)
{
    if (i == 0 || i == 1)
        serieFibonacci[i] = i;
    else
    {
        serieFibonacci[i] = (serieFibonacci[i - 1] + serieFibonacci[i - 2]);
    }
}

int x = int.Parse(Console.ReadLine());

for(int i = 0; i < x; i++)
{
    int index = int.Parse(Console.ReadLine());
    Console.WriteLine($"Fib({index}) = {serieFibonacci[index]}");
}


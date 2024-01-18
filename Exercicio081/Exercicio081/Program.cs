int x = int.Parse(Console.ReadLine());

int[] vect = new int[10];

for (int i = 0; i < 10; i++)
{
    vect[i] = x;
    x *= 2;
}

for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"N[{i}] = {vect[i]}");
}
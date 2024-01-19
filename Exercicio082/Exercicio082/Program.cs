double[] vect = new double[100];

for (int i = 0; i < 100; i++)
{
    vect[i] = double.Parse(Console.ReadLine());
}

for (int i = 0; i < 100; i++)
{
    if (vect[i] <= 10.0)
    {
        Console.WriteLine($"A[{i}] = {vect[i]:F1}");
    }
}
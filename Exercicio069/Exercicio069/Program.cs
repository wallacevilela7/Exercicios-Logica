using System.Collections.Generic;

int num = int.Parse(Console.ReadLine());

List<int> array = new List<int>();
int aux = 0;

if (num <= 0 || num >= 46)
{
    do
    {
        num = int.Parse(Console.ReadLine());
    } while (num <= 0 || num >= 46);
}

for (int i = 0; i <= num; i++)
{
    if (i == 0 || i == 1)
    {
        array.Add(i);
    }
    else if (i > 1)
    {
        aux = array[i - 1] + array[i - 2];
        array.Add(aux);
    }
}

foreach (int i in array)
{
    int last = array[array.Count - 1];
    if (i != last)
    {
        Console.Write($"{i} ");

    }
    else
    {
        Console.Write($"{i}...");
    }
}
Console.WriteLine();
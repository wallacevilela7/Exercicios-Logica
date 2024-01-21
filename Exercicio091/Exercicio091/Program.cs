using System.Collections.Generic;
using System.Linq;

char op;
const int size = 12;
double[,] mat = new double[size, size];
List<double> vect = new List<double>();
double output = 0.0;

op = char.Parse(Console.ReadLine());

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        mat[i,j] = double.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (j > i)
        {
            vect.Add(mat[i, j]);
        }
    }
}

if (op == 'S')
{
    output = vect.Sum();
    Console.WriteLine($"{output:F1}");
}
else if(op == 'M')
{
    output = vect.Average();
    Console.WriteLine($"{output:F1}");
}
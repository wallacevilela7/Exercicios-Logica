using System.Numerics;
using System.Runtime.Serialization;

char op;
int size = 12;
double[,] mat = new double[size,size];
List<double> vet = new List<double>();
double output = 0.0;

op = char.Parse(Console.ReadLine());

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        mat[i,j] = double.Parse(Console.ReadLine());
        if(i > j) vet.Add(mat[i,j]);
    }
}

output = vet.Sum();

if (op == 'S')
    Console.WriteLine($"{output:f1}");
else if (op == 'M') output = vet.Average(); Console.WriteLine($"{output:f1}");

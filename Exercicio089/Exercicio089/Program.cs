int line = 0;
char op;
const int size = 12;
double[,] mat = new double[size,size];
double[] vect = new double[size];
double output = 0.0;

line = int.Parse(Console.ReadLine());
op = char.Parse(Console.ReadLine());

for(int i = 0; i < size; i++)
{
    for(int j = 0; j < size; j++)
    {
        mat[i,j] = double.Parse(Console.ReadLine());
    }
}

for(int i = line; i <= line; i++)
{
    for(int  k = 0; k < size; k++)
    {
        vect[k] = mat[i,k];
    }
}

for(int i = 0; i < size; i++)
{
    output += vect[i];
}

if(op == 'S')
{
    Console.WriteLine($"{output:F1}");
}
else if(op == 'M')
{
    output /= size;
    Console.WriteLine($"{output:F1}");
}
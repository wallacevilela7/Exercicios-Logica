using System.Net.Http.Headers;
using System.Numerics;

int[] vet = new int[1000];
int x = int.Parse(Console.ReadLine());
int aux = x - 1;
int count = 0;
if(!(x >= 2 && x <= 50))
{
    do
    {
        x = int.Parse(Console.ReadLine());
    } while (!(x >= 2 && x <= 50));
}

for(int i = 0; i < 1000; i++)
{
    if(count <= aux)
    {
        vet[i] = count;
    }
    count++;
    if (count > aux) count = 0;
}

for(int i = 0; i < 1000; i++)
{
    Console.WriteLine($"N[{i}] = {vet[i]}");
}
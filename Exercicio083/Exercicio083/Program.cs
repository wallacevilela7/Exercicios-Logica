using System.Numerics;

int[] vet = new int[20];
int[] vet2 = new int[20];
int j = 0;

for (int i = 0; i < 20; i++)
{
    vet[i] = int.Parse(Console.ReadLine());
}

for (int i = 19; i >= 0; i--)
{
    vet2[j] = vet[i];
    j++;
}

for (int k = 0; k < 20; k++)
{
    Console.WriteLine($"N[{k}] = {vet2[k]}");
}




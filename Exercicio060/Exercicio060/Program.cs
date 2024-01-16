int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

int maior = Math.Max(x, y);
int menor = Math.Min(x, y);
int soma = 0;

for (int i = menor; i <= maior; i++)
{
    if(i % 13 != 0)
    {
        soma += i;
    }
}

Console.WriteLine($"{soma}");
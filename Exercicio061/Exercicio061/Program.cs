int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

int maior = Math.Max(x, y);
int menor = Math.Min(x, y);
int soma = 0;

for (int i = menor + 1; i < maior; i++)
{
    if (i % 5 == 3 || i % 5 == 2)
    {
        Console.WriteLine(i);
    }
}
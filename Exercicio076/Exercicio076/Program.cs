using System.Xml.Serialization;

int x = int.Parse(Console.ReadLine());
int soma = 0;
int count = x;

while (x != 0)
{
    for (int i = x; i <= count + 9; i++)
    {
        if (x % 2 == 0)
        {
            soma += x;
        }
        x++;
    }
    Console.WriteLine(soma);
    soma = 0;
    x = int.Parse(Console.ReadLine());
    count = x;
}
int num = int.Parse(Console.ReadLine());
int soma = 0;

for (int i = 0; i < num; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);

    for(int j = 1; j <= y * 2; j++)
    {
        if(x % 2 != 0)
        {
            soma += x;
        }
        x++;
    }
    Console.WriteLine(soma);
    soma = 0;
}
int x = int.Parse(Console.ReadLine());
int soma = 0;
int num;
int i = 0;
do
{
    num = int.Parse(Console.ReadLine());
    for (int j = 1; j < num; j++)
    {
        if (num % j == 0)
        {
            soma += j;
        }
    }

    if(soma == num)
    {
        Console.WriteLine($"{num} eh perfeito");
    }else
    {
        Console.WriteLine($"{num} nao eh perfeito");
    }

    soma = 0;
    i++;

}while (i < x);
        

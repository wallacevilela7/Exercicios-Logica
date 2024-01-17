int num = int.Parse(Console.ReadLine());
int soma = 0;
int aux = 0;

if(num <= 0 || num >= 46)
{
    do
    {
        num = int.Parse(Console.ReadLine());
    } while (num <= 0 || num >= 46);
}

for(int i = 0; i <= num; i++)
{
    //Como pegar os dois ultimos i e apresentar a soma deles ??????????????????????????
    if(i == 0 || i == 1)
    {
        Console.Write($"{i} ");
    }
    else if(i > 1)
    {
        aux = i - 1;
        soma = (soma + aux);
        Console.Write($"{soma} ");
    }
    
}
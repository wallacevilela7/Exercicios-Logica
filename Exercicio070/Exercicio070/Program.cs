int num = int.Parse(Console.ReadLine());
int fat = 1;

if(num < 0 || num > 13)
{
    do
    {
        num = int.Parse(Console.ReadLine());
    } while (num < 0 || num > 13);
}


for(int i = 1; i <= num; i++)
{
    fat += fat * (num - i);
}

Console.WriteLine(fat);

//fatorial de 5 

//5! = 5 * 4; * 3 * 2 * 1 = 120;


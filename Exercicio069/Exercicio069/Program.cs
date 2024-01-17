using System.Collections.Generic;

int num = int.Parse(Console.ReadLine());

List<int> array = new List<int>();
int aux = 0;

if (num <= 0 || num >= 46)
{
    do
    {
        num = int.Parse(Console.ReadLine());
    } while (num <= 0 || num >= 46);
}

for (int i = 0; i <= num; i++)
{
    if (i == 0 || i == 1)
    {
        array.Add(i);
    }
    else if (i > 1)
    {
        aux = array[i - 1] + array[i - 2];
        array.Add(aux);
    }
}

foreach (int i in array)
{
    int last = array[array.Count - 1];
    if (i != last)
    {
        Console.Write($"{i} ");

    }
    else
    {
        Console.Write(i);
    }
}
Console.WriteLine();


/*
 * 
 * no beecrowd só passou com python
 * 
 * N  = int(input())

V1 = [0]*N

for i in range (0,N):
    if i <= 1:
        V1[i] = i
    else:
        V1[i] = V1[i-1] + V1[i-2]

    if i==N-1:
        print('%d'%(V1[i]),end='')
    else:
        print('%d'%(V1[i]),end=' ')
    
print() #Quebra de linha 
 */
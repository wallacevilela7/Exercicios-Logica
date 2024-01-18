using System.Collections.Generic;
using System.Linq;

int age = int.Parse(Console.ReadLine());
List<int> ints = new List<int>();

while(age > 0)
{
    if(age != 0)
    {
        ints.Add(age);
    }
    age = int.Parse(Console.ReadLine());
}
double media = (double)ints.Average();

Console.WriteLine($"{media:F2}");
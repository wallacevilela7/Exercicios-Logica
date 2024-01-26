int a = 0;
int b = 0;
int resto = 0;
int quociente = 0;
string[] input = new string[0];

input = Console.ReadLine().Split(' ');
a = int.Parse(input[0]);
b = int.Parse((input[1]));

quociente = a / b;
resto = (a % b + b) % b;

if ((a < 0 && b > 0) || (a > 0 && b < 0))
{
    quociente -= -1;
}

Console.WriteLine($"{quociente} {resto}");
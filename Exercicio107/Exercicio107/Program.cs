int a = 0;
int b = 0;
int resto = 0;
int quociente = 0;
string[] input = new string[0];

input = Console.ReadLine().Split(' ');
a = int.Parse(input[0]);
b = int.Parse((input[1]));

resto = a % b;

if(resto < 0)
{
    resto += Math.Abs(b);
}

quociente = (a - resto) / b;


Console.WriteLine($"{quociente} {resto}");
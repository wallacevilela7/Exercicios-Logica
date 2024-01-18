double x = 0.0;
double y = 2.0;

for (double i = 3.0; i <= 39; i += 2)
{
    x += (i / y);
    y *= 2;
}
x = x + 1;
Console.WriteLine($"{x:F2}");
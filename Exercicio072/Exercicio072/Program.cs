double s = 0.0;
for(double i = 1.0; i <= 100; i++)
{
    s += (1 / i);
}
Console.WriteLine($"{s:F2}");
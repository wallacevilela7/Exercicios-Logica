int x = int.Parse(Console.ReadLine());

for (int i = 0; i < x; i++) {
    int num = int.Parse(Console.ReadLine());
    string output = ehPrimo(num);
    Console.WriteLine(output);
}

static string ehPrimo(int num)
{
    int divisores = 0;
    for (int j = 1; j < num; j++)
    {
        if (num % j == 0) divisores++;
    }

    return divisores > 1 ? $"{num} nao eh primo" : $"{num} eh primo";

}
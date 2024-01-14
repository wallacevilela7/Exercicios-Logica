int numTestes = int.Parse(Console.ReadLine());
int imparCount = 0;

for (int i = 0; i < numTestes; i++)
{
    string[] valores = Console.ReadLine().Split(' ');

    int x = int.Parse(valores[0]);
    int y = int.Parse(valores[1]);

    if (x > y)
    {
        for (int w = y + 1; w < x; w++)
        {
            if (w % 2 != 0)
            {
                imparCount += w;
            }
        }
    }

    if (y > x)
    {
        for (int w = x + 1; w < y; w++)
        {
            if (w % 2 != 0)
            {
                imparCount += w;
            }
        }
    }

    Console.WriteLine(imparCount);
    imparCount = 0;
}
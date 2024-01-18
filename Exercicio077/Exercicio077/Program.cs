int x = int.Parse(Console.ReadLine());

int pa, pb;
double txA, txB;
int anos = 0;

for (int i = 0; i < x; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    pa = int.Parse(input[0]);
    pb = int.Parse(input[1]);
    txA = double.Parse(input[2]);
    txB = double.Parse(input[3]);

    txA = txA / 100;
    txB = txB / 100;

    do
    {
        pa += (int)(pa * txA);
        pb += (int)(pb * txB);
        anos++;

    } while (pa <= pb);
    if (anos > 100)
    {
        Console.WriteLine("Mais de 1 seculo.");
    }
    else
    {
        Console.WriteLine($"{anos} anos.");
    }

    input = new string[0];
    anos = 0;
}
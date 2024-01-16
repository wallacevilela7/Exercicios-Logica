int linha = int.Parse(Console.ReadLine());

int x = 1, y = 2, z = 3;

for (int i = 0; i < linha; i++)
{
    Console.WriteLine($"{x} {y} {z} PUM");
    x += 4;
    y += 4;
    z += 4;
}
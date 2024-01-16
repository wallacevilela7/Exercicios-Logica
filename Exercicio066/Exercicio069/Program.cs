string[] input = Console.ReadLine().Split(' ');

int numsPorLinha = int.Parse(input[0]);
int voltasLoop = 1;
int fim = int.Parse(input[1]);

for (int i = 1; i <= fim; i++)
{
    if (voltasLoop != numsPorLinha)
    {
        Console.Write($"{i} ");
    }
    else
    {
        Console.Write($"{i}\n");
        voltasLoop = 0;
    }
    voltasLoop++;
}
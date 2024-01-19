int[] vetPar = new int[5];
int[] vetImpar = new int[5];

int x;
int countPar = 0;
int countImpar = 0;

for (int i = 0; i < 15; i++)
{
    x = int.Parse(Console.ReadLine());

    if (x % 2 == 0)
    {
        vetPar[countPar] = x;
        countPar++;
        if (countPar == 5)
        {
            countPar = 0;
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"par[{j}] = {vetPar[j]}");
            }
            Array.Clear(vetPar, 0, vetPar.Length); // Limpa o array
        }

    }
    else
    {
        vetImpar[countImpar] = x;
        countImpar++;
        if (countImpar == 5)
        {
            countImpar = 0;
            for (int w = 0; w < 5; w++)
            {
                Console.WriteLine($"impar[{w}] = {vetImpar[w]}");
            }
            Array.Clear(vetImpar, 0, vetImpar.Length); // Limpa o array
        }
    }
}

// Imprime os restantes
for (int i = 0; i < countImpar; i++)
{
    Console.WriteLine($"impar[{i}] = {vetImpar[i]}");
}

for (int i = 0; i < countPar; i++)
{
    Console.WriteLine($"par[{i}] = {vetPar[i]}");
}
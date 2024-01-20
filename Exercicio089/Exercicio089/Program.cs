try
{


int[,] mat = new int[12, 12];

int linha = 0;
linha = int.Parse(Console.ReadLine());
string operacao = "";
operacao = Console.ReadLine();
int[] vet = new int[12];
double saida = 0.0;

for (int i = 0; i < 12; i++)
{
    for (int j = 0; j < 12; j++)
    {
        mat[i, j] = int.Parse(Console.ReadLine());
    }
}


for (int i = linha; i < 12; i++)
{
    for (int j = 0; j < 12; j++)
    {
        vet[j] = mat[i, j];
    }
}

for (int i = 0; i < 12; i++)
{
    saida += vet[i];
}

if (operacao == "M" || operacao == "m")
{
    saida = saida / 12;
}


Console.WriteLine($"{saida:F1}");

}
catch(FormatException ex)
{
    Console.WriteLine(ex.Message);
}

string[] vet = Console.ReadLine().Split(' ');

int a;
int n;
int soma = 0;

a = int.Parse(vet[0]);
n = int.Parse(vet[1]);

int contv = 1;
while (n <= 0)
{
    contv++;
    n = int.Parse(vet[contv]);
}

for (int i = 0; i <= n - 1; i++)
{
    soma = soma + (a + i);

}
Console.WriteLine(soma);
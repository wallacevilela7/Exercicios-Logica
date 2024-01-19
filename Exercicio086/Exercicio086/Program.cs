decimal x = decimal.Parse(Console.ReadLine());

decimal[] vet = new decimal[100];

vet[0] = x;

for (int i = 1; i < 100; i++)
{
    x = x / 2;
    vet[i] = x;
}

for (int i = 0; i < 100; i++)
{
    Console.WriteLine($"N[{i}] = {vet[i]:f4}");
}

/*Passou mas foi em c 
 * #include <stdio.h>

int main() {
    double x;
    scanf("%lf", &x);

    double vet[100];

    vet[0] = x;

    for (int i = 1; i < 100; i++) {
        x = x / 2;
        vet[i] = x;
    }

    for (int i = 0; i < 100; i++) {
        printf("N[%d] = %.4lf\n", i, vet[i]);
    }

    return 0;
}
 */
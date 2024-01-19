int x = int.Parse(Console.ReadLine());

int[] vect = new int[x];
int menor = 0;
int menorIndex = 0;

for (int i = 0; i < x; i++)
{
    int item = int.Parse(Console.ReadLine());
    vect[i] = item;
}

menor = vect.Min();

for(int i = 0; i < x; i++)
{
    if (vect[i] == menor)
    {
        menorIndex = i;
    }
}

Console.WriteLine($"Menor valor: {menor}");
Console.WriteLine($"Posicao: {menorIndex}");



/*EM C++
 * #include <iostream>
#include <vector>

int main() {
    int x;
    std::cin >> x;

    std::vector<int> vect(x);
    int menor = 0;
    int menorIndex = 0;

    for (int i = 0; i < x; i++) {
        int item;
        std::cin >> item;
        vect[i] = item;
    }

    menor = vect[0];

    for(int i = 0; i < x; i++) {
        if (vect[i] < menor) {
            menor = vect[i];
            menorIndex = i;
        }
    }

    std::cout << "Menor valor: " << menor << std::endl;
    std::cout << "Posicao: " << menorIndex << std::endl;

    return 0;
}

 */

/*EM C 
 * #include <stdio.h>

int main() {
    int x;
    scanf("%d", &x);

    int vect[x];
    int menor = 0;
    int menorIndex = 0;

    for (int i = 0; i < x; i++) {
        int item;
        scanf("%d", &item);
        vect[i] = item;
    }

    menor = vect[0];

    for(int i = 0; i < x; i++) {
        if (vect[i] < menor) {
            menor = vect[i];
            menorIndex = i;
        }
    }

    printf("Menor valor: %d\n", menor);
    printf("Posicao: %d\n", menorIndex);

    return 0;
}
 */
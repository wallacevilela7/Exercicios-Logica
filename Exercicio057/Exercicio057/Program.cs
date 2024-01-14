using System.Collections.Generic;

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int soma = 0;
List<int> valuesSequence = new List<int>();

while (m != 0 && n != 0)
{
    if (m > n)
    {
        for (int i = n; i <= m; i++)
        {
            soma += i;
            valuesSequence.Add(i);
        }
        foreach (int i in valuesSequence)
        {
            Console.Write($"{i} ");
        }
        Console.Write($"Sum={soma}");
    }
    if (m < n)
    {
        for (int i = m; i <= n; i++)
        {
            soma += i;
        }
        foreach (int i in valuesSequence)
        {
            Console.Write($"{i} ");
        }
        Console.Write($"Sum={soma}");
    }

    valuesSequence = new List<int>();
    soma = 0;
    m = int.Parse(Console.ReadLine());
    n = int.Parse(Console.ReadLine());
}


//C++ é muito mais preciso mesmo

/*
 * #include <iostream>

int main() {
    int m, n;

    std::cin >> m;
    std::cin >> n;

    while (m > 0 && n > 0) {
        int soma = 0;

        if (m > n) {
            for (int i = n; i <= m; i++) {
                soma += i;
                std::cout << i << " ";
            }
        } else {
            for (int i = m; i <= n; i++) {
                soma += i;
                std::cout << i << " ";
            }
        }

        std::cout << "Sum=" << soma << std::endl;

        std::cin >> m;
        std::cin >> n;
    }

    return 0;
}

 */
int n = int.Parse(Console.ReadLine());
int[,] mat = new int[n, n];

while (n != 0)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mat[i, j] = 1;
        }
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j != n)
            {
                Console.Write($"   {mat[i, j]}");
            }
            else
            {
                Console.Write($"{mat[i, j]}");
            }
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    n = int.Parse(Console.ReadLine());
    mat = new int[n, n];
}
/*

#include <stdio.h>

int main()
{

    //Valores discretos, sem sinal;
    unsigned short int tamanho, coluna, linha, iniMatriz, fimMatriz, elemento;

    while (1)
    {

        scanf("%hd", &tamanho);
        //Declaração de matriz de tamanho variado;
        short m[tamanho][tamanho] ;

        if (tamanho == 0)
            return 0;

        iniMatriz = 0;
        fimMatriz = tamanho;
        elemento = 1;

        while (1)
        {
            //Preenche matrizes de tamanho menor cada vez que o laço reinicia;
            for (linha = iniMatriz; linha < fimMatriz; linha++)
                for (coluna = iniMatriz; coluna < fimMatriz; coluna++)
                    m[linha][coluna] = elemento;

            if (fimMatriz == 0)
                break;

            fimMatriz--;
            iniMatriz++;
            elemento++;

        }

        //Imprime a matriz;
        for (linha = 0; linha < tamanho; linha++)
        {
            for (coluna = 0; coluna < tamanho; coluna++)
            {
                if (coluna == 0)
                    printf("%3hd", m[linha][coluna]);
                else
                    printf(" %3hd", m[linha][coluna]);

            }

            printf("\n");
        }

        printf("\n");

    }
}*/

//////////////////MATRIZ QUADRADA 2
/*
 * #include <stdio.h>

int main ()
{

	unsigned short int tamanho, linha, coluna;

	while (1)
	{

		scanf("%hd", &tamanho);
		short matriz[tamanho][tamanho];

		if (tamanho == 0)
			return 0;

		for(linha = 0; linha < tamanho; linha++)
			for(coluna = 0; coluna < tamanho; coluna++)
			{
				if (linha == coluna)
					matriz[linha][coluna] = 1;
				if (linha < coluna)
					matriz[linha][coluna] = coluna - linha + 1;
				if (linha > coluna)
					matriz[linha][coluna] = linha - coluna + 1;
			}


		//Imprime a matriz;
		for (linha = 0; linha < tamanho; linha++)
		{
			for (coluna = 0; coluna < tamanho; coluna++)
			{
				if (coluna == 0)
					printf("%3hd", matriz[linha][coluna]);
				else
					printf(" %3hd", matriz[linha][coluna]);

			}

			printf("\n");
		}

		printf("\n");

	}
}
 */
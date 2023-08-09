/*
 * Escreva um programa que repita a leitura de ums senha até que ela seja válida. Para cada leitura de senha incorreta informada, escrever
 * a mensagem "Senha Inválida". Quando a senha for informada corretamente deve ser impressa a mengagem "Acesso Permitido" e o algotitmo
 * encerrado. Considere que a senha correta é o valor 2002.
 */

using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha");
            string password = Console.ReadLine();

            while (password != "2002")
            {
                Console.WriteLine("Senha Inválida!");
                password = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Acesso permitido");

        }
    }
}
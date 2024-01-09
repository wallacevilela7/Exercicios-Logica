using System;
using System.Collections.Immutable;

namespace Ex
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] valuesInput = Console.ReadLine().Split(' ');

            int v1 = int.Parse(valuesInput[0]);
            int v2 = int.Parse(valuesInput[1]);


            int duracao = (v2 - v1 + 24) % 24;

            //olha que ternário chique, resolvendo o problema se a entrada for 0 0
            duracao = (duracao == 0) ? 24 : duracao;
            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

        }
    }
}
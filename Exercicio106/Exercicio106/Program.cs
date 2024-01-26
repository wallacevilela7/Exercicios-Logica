using System;
using System.Collections.Generic;
using System.Linq;

int n = int.Parse(Console.ReadLine());
string[] input = new string[0];
string player1, player2;

for (int i = 0; i < n; i++)
{
    input = Console.ReadLine().Split(' ');
    player1 = input[0];
    player2 = input[1];
    Console.WriteLine($"Caso #{i + 1}: {WhoWins(player1, player2)}");
    Array.Clear(input, 0, input.Length);
}

static string WhoWins(string p1, string p2)
{
    Dictionary<string, string[]> winConditions = new Dictionary<string, string[]>
        {
            { "tesoura", new[] { "papel", "lagarto" } },
            { "papel", new[] { "pedra", "Spock" } },
            { "pedra", new[] { "lagarto", "tesoura" } },
            { "lagarto", new[] { "Spock", "papel" } },
            { "Spock", new[] { "tesoura", "pedra" } }
        };

    if (p1 == p2) return "De novo!";

    if (winConditions[p1].Contains(p2))
    {
        return "Bazinga!";
    }
    else
    {
        return "Raj trapaceou!";
    }
}
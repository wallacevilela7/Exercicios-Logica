using System;

class Program
{
    static void Main(string[] args)
    {
        int numTestes = int.Parse(Console.ReadLine());


        int ratos = 0;
        int sapos = 0;
        int coelhos = 0;
        string tipo = "";

        for (int i = 1; i <= numTestes; i++)
        {
            string[] dadosTeste = Console.ReadLine().Split(' ');

            tipo = (dadosTeste[1].ToUpper());

            switch (tipo)
            {
                case "R":
                    ratos += int.Parse(dadosTeste[0]);
                    break;
                case "C":
                    coelhos += int.Parse(dadosTeste[0]);
                    break;
                case "S":
                    sapos += int.Parse(dadosTeste[0]);
                    break;
                default: 
                    break;
            }
            Array.Clear(dadosTeste, 0, dadosTeste.Length);
        }

        int totalCobaias = ratos + sapos + coelhos;
        double percentualDeCoelhos = (coelhos * 100) / (double)totalCobaias;
        double percentualDeRatos = (ratos * 100) / (double)totalCobaias;
        double percentualDeSapos = (sapos * 100) / (double)totalCobaias;


        Console.WriteLine($"Total: {totalCobaias} cobaias");
        Console.WriteLine($"Total de coelhos: {coelhos}");
        Console.WriteLine($"Total de ratos: {ratos}");
        Console.WriteLine($"Total de sapos: {sapos}");
        Console.WriteLine($"Percentual de coelhos: {percentualDeCoelhos:F2} %");
        Console.WriteLine($"Percentual de ratos: {percentualDeRatos:F2} %");
        Console.WriteLine($"Percentual de sapos: {percentualDeSapos:F2} %");

    }
}
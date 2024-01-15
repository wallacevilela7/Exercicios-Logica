using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        int total = 0;
        int vitInter = 0;
        int vitGremio = 0;
        int empates = 0;

        int option = 0;
        do
        {
            string[] input = Console.ReadLine().Split(' ');
            int golsInter = int.Parse(input[0]);
            int golsGremio = int.Parse(input[1]);
            
            total++;
            if (golsInter > golsGremio) vitInter++;
            else if (golsGremio > golsInter) vitGremio++;
            else empates++;

            input = new string[0];
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            option = int.Parse(Console.ReadLine());

        } while(option != 2);


        string venceuMais = VenceuMais(vitGremio, vitInter);

        Console.WriteLine($"{total} grenais");
        Console.WriteLine($"Inter: {vitInter}");
        Console.WriteLine($"Gremio: {vitGremio}");
        Console.WriteLine($"Empates: {empates}");
        Console.WriteLine(venceuMais);
    }

    static string VenceuMais(int gremio, int inter)
    {
        if (gremio > inter) return "Gremio venceu mais";
        else if (gremio < inter) return "Inter venceu mais";
        else return "Empate";
    }
}
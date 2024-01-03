using System;
using System.Collections.Generic;

class Program
{
    static List<string> alunos = new List<string>();
    static List<double> notas = new List<double>();

    static void Main()
    {
        bool sair = false;

        do
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Adicionar nova nota");
            Console.WriteLine("2. Exibir todas as notas");
            Console.WriteLine("3. Calcular média das notas");
            Console.WriteLine("4. Encontrar nota mais alta");
            Console.WriteLine("5. Sair");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    AdicionarNota();
                    break;
                case "2":
                    ExibirNotas();
                    break;
                case "3":
                    CalcularMedia();
                    break;
                case "4":
                    EncontrarNotaMaisAlta();
                    break;
                case "5":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (!sair);
    }

    static void AdicionarNota()
    {
        Console.Write("Nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Nota: ");
        if (double.TryParse(Console.ReadLine(), out double nota))
        {
            alunos.Add(nome);
            notas.Add(nota);
            Console.WriteLine("Nota adicionada com sucesso!");
        }
        else
        {
            Console.WriteLine("Valor inválido para nota. Tente novamente.");
        }
    }

    static void ExibirNotas()
    {
        Console.WriteLine("\nLista de notas:");

        for (int i = 0; i < alunos.Count; i++)
        {
            Console.WriteLine($"{alunos[i]}: {notas[i]}");
        }
    }

    static void CalcularMedia()
    {
        if (notas.Count > 0)
        {
            double media = notas.Sum() / notas.Count;
            Console.WriteLine($"\nMédia das notas: {media:F2}");
        }
        else
        {
            Console.WriteLine("\nNão há notas para calcular a média.");
        }
    }

    static void EncontrarNotaMaisAlta()
    {
        if (notas.Count > 0)
        {
            double notaMaisAlta = notas.Max();
            int indexNotaMaisAlta = notas.IndexOf(notaMaisAlta);
            string alunoNotaMaisAlta = alunos[indexNotaMaisAlta];

            Console.WriteLine($"\nNota mais alta: {notaMaisAlta} (Aluno: {alunoNotaMaisAlta})");
        }
        else
        {
            Console.WriteLine("Maria cursi");
            Console.WriteLine("\nNão há notas para encontrar a mais alta.");
        }
    }
}

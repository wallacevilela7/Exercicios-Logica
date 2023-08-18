/*
 Fazer um programa para ler o nome de uma aluno e as três notas que ele obteve nos três trimestres do ano (primeiro semestre vale 30 e o segundo e o terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. Dizer também se o aluno está aprovadi ou reprovado e, em caso negativo, quantos pontos faltam para o aluno obter o mínomo para ser aprovado que é 60 pontos. Voce deve criar a classe aluno para resolver este problema.
 */

using Exercicio029.Entities;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nota 1: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            double n3 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Aluno aluno = new Aluno(nome, n1, n2, n3);

            Console.WriteLine($"Media : {aluno.CalculaMedia()}");
            Console.WriteLine(aluno.VerificaAprovacao());
        }
    }
}
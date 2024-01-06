using Exercicio044;
using System;
using System.Globalization;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do funcionario:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario f = new Funcionario(nome, imposto, salario);

            Console.WriteLine(f);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double pct = double.Parse(Console.ReadLine());

            f.AumentarSalario(pct);

            Console.WriteLine($"Dados Atualizados: {f}");
        }
    }
}
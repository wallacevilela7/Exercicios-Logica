/*
    Fazer um programa para ler os dados de um funcionário (Nome, Salário bruto e imposto). Em seguida, mostrar os dados
do funcionário. Em seguida aumentar o salário do funcionário com base em uma porcentagem dada (somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário.
 */


using Exercicio028.Entities;
using System.Globalization;
namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Salário bruto: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Impostos: ");
            double tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario func = new Funcionario(name, salary, tax);

            Console.WriteLine($"Funcionário: {func.Name}, R${func.NetSalary().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            func.RaiseSalary(percentage);

            Console.WriteLine();
            Console.Write($"Dados Atualizados: {func.Name}, R${func.NetSalary().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
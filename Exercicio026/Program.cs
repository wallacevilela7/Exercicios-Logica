/*
 * Fazer um exercicio para ler nome e salário de dois funcionarios. Depois mostrar o salário médio dos funcionarios.
 */

using Exercicio026.Entities;
using System.Globalization;
namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados Funcionario 1");
            Console.Write("Nome: ");
            string n1 = Console.ReadLine();
            Console.Write("Salario R$: ");
            double s1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados Funcionario 2");
            Console.Write("Nome: ");
            string n2 = Console.ReadLine();
            Console.Write("Salario R$: ");
            double s2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Employee emp1 = new Employee(n1, s1);
            Employee emp2 = new Employee(n2, s2);


            Console.WriteLine($"Salário médio: R${CalcAvgSalary(emp1,emp2).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static double CalcAvgSalary(Employee x, Employee y)
        {
            return (x.Salary + y.Salary) / 2;
        }
    }
}
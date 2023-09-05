using Exercicio036.Entities;
using System;
using System.Globalization;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            Console.Write($"Digite o numero de funcionarios: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Funcionario #{i + 1}");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Id do Funcionario para aumentar o salário: ");
            int idFuncion = int.Parse(Console.ReadLine());

            Funcionario? funcion = list.Find(x => x.Id == idFuncion);
            if (funcion == null)
            {
                Console.WriteLine("O funcionario para o ID informado não existe");

            }
            else
            {
                Console.Write("Valor percentual do aumento do salário: ");
                double pct = double.Parse(Console.ReadLine());
                funcion.AumentaSalario(pct);
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada dos funcionarios: ");
            foreach (Funcionario funcionario in list)
            {
                Console.WriteLine(funcionario);
            }

        }
    }
}
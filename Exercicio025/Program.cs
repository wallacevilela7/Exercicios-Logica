/*
 *Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
 */

using Exercicio025.Entities;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da Pessoa 1");
            Console.Write("Nome: ");
            string n1 = Console.ReadLine();

            Console.Write("Idade: ");
            int age1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Pessoa 2");
            Console.Write("Nome: ");
            string n2 = Console.ReadLine();

            Console.Write("Idade: ");
            int age2 = int.Parse(Console.ReadLine());

            Person p1 = new Person(n1, age1);
            Person p2 = new Person(n2, age2);

            Console.WriteLine(FindOlder(p1, p2));
        }

        static string FindOlder(Person p1, Person p2)
        {
            if (p1.Age > p2.Age)
            {
                return $"Pessoa mais velha: {p1.Name}.";
            }
            else if (p1.Age == p2.Age)
            {
                return $"{p1.Name} e {p2.Name} tem idades iguais.";
            }
            else
            {
                return $"Pessoa mais velha: {p2.Name}.";
            }
        }
    }
}
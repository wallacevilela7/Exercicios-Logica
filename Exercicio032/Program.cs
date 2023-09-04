using Exercicio032.Entities;
using System.Globalization;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados da conta:");
            Console.WriteLine();
            Console.Write("Numero da conta: ");
            int id = int.Parse(Console.ReadLine()); 
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Deseja realizar um depósito inicial? (S/N)");
            char option = char.Parse(Console.ReadLine());
            double valorInicial = 0.00;

            Conta conta;

            if (option == 'S' || option == 's')
            {
                Console.Write("Digite o valor do depósito: R$");
                valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(id, nome);
                conta.Deposito(valorInicial);
            }
            else
            {
                conta = new Conta(id, nome);
            }

            Console.WriteLine($"Dados atualizados da conta: {conta}");

            Console.Write("Valor para deposito: ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(qtd);
            Console.WriteLine($"Dados atualizados da conta: {conta}");


            Console.Write("Valor para saque: ");
            qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bool saque = conta.Saque(qtd);

            Console.WriteLine(VerificaSaque(saque));

            Console.WriteLine($"Dados atualizados da conta: {conta}");
        }
        static string VerificaSaque(bool saque)
        {
            return saque ? "Saque realizado com sucesso!" : "Saldo insuficiente";
        }
    }
}
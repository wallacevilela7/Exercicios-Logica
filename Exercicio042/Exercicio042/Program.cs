using Exercicio042.Entities;
using System;
using System.Net.Http.Headers;
using System.Transactions;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com os dados do produto: ");
            
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em Estoque: ");
            int quantidadeEstoque = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidadeEstoque);
            p.CalcularValorTotalEstoque();

            Console.Clear();
            Console.WriteLine(p);


            Console.WriteLine("Quantos produtos deseja adicionar? ");
            int qtd = int.Parse(Console.ReadLine());

            Console.Clear();
            p.AdicionarProdutos(qtd);
            Console.WriteLine(p);

            Console.WriteLine("Quantos produtos deseja remover? ");
            qtd = int.Parse(Console.ReadLine());

            Console.Clear();
            p.RemoverProdutos(qtd);
            Console.WriteLine(p);
        }
    }
}
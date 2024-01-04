
namespace Exercicio042.Entities
{
    internal class Produto
    {
        public string? Nome { get; set; }
        public double? Preco { get; set; }
        public int? QuantidadeEstoque { get; set; }
        public double? ValorTotalEstoque { get; set; }

        public Produto(string? nome, double? preco, int? quantidadeEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public double CalcularValorTotalEstoque()
        {
            ValorTotalEstoque = Preco * QuantidadeEstoque;
            return (double)ValorTotalEstoque;
        }
        public void AdicionarProdutos(int qtd)
        {
            QuantidadeEstoque += qtd;
            CalcularValorTotalEstoque();
        }

        public void RemoverProdutos(int qtd)
        {
            QuantidadeEstoque -= qtd;
            CalcularValorTotalEstoque();
        }

        public override string ToString()
        {
            return $"Produto: {Nome}\nPreço R${Preco:F2}\nQuantidade em estoque:{QuantidadeEstoque}\nValor Total em estoque: {ValorTotalEstoque:F2}";
        }

    }
}

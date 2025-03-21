using System;
using System.Collections.Generic;
using System.Linq;

namespace GerenciamentoEstoque
{
    public class Estoque
    {
        private List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public Produto BuscarProdutoPorCodigo(int codigo)
        {
            var produto = produtos.FirstOrDefault(p => p.Codigo == codigo);
            if (produto == null)
            {
                throw new Exception("Produto não encontrado.");
            }
            return produto;
        }

        public void AtualizarEstoque(int codigo, int quantidade)
        {
            try
            {
                var produto = BuscarProdutoPorCodigo(codigo);
                if (produto.QuantidadeEmEstoque + quantidade < 0)
                {
                    throw new Exception("Quantidade insuficiente em estoque.");
                }
                produto = produto with { QuantidadeEmEstoque = produto.QuantidadeEmEstoque + quantidade };
                produtos[produtos.FindIndex(p => p.Codigo == codigo)] = produto;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar estoque: {ex.Message}");
            }
        }

        public IEnumerable<Produto> ProdutosAbaixoDoLimite(int limite)
        {
            return produtos.Where(p => p.QuantidadeEmEstoque < limite);
        }

        public IEnumerable<Produto> ProdutosEntreValores(double minimo, double maximo)
        {
            return produtos.Where(p => p.PrecoUnitario >= minimo && p.PrecoUnitario <= maximo);
        }

        public double ValorTotalEstoque()
        {
            try
            {
                return produtos.Sum(p => p.QuantidadeEmEstoque * p.PrecoUnitario);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao calcular valor total do estoque: {ex.Message}");
                return 0;
            }
        }

        public Dictionary<Produto, double> ValorTotalPorProduto()
        {
            try
            {
                return produtos.ToDictionary(p => p, p => p.QuantidadeEmEstoque * p.PrecoUnitario);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao calcular valor total por produto: {ex.Message}");
                return new Dictionary<Produto, double>();
            }
        }
    }
}
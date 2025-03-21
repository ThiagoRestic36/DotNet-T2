using System;
using System.Collections.Generic;
using System.Linq;

namespace GerenciamentoEstoque
{
    public class Relatorios
    {
        public static void GerarRelatorioProdutosAbaixoLimite(Estoque estoque, int limite)
        {
            try
            {
                var produtos = estoque.ProdutosAbaixoDoLimite(limite);
                foreach (var produto in produtos)
                {
                    Console.WriteLine($"Produto abaixo do limite: {produto.Nome}, Quantidade: {produto.QuantidadeEmEstoque}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gerar relatório: {ex.Message}");
            }
        }

        public static void GerarRelatorioProdutosEntreValores(Estoque estoque, double minimo, double maximo)
        {
            try
            {
                var produtos = estoque.ProdutosEntreValores(minimo, maximo);
                foreach (var produto in produtos)
                {
                    Console.WriteLine($"Produto entre valores: {produto.Nome}, Preço: {produto.PrecoUnitario}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gerar relatório: {ex.Message}");
            }
        }

        public static void GerarRelatorioValorTotalEstoque(Estoque estoque)
        {
            try
            {
                var valorTotalEstoque = estoque.ValorTotalEstoque();
                Console.WriteLine($"Valor total do estoque: {valorTotalEstoque}");

                var valorPorProduto = estoque.ValorTotalPorProduto();
                foreach (var (produto, valorTotal) in valorPorProduto)
                {
                    Console.WriteLine($"Produto: {produto.Nome}, Valor Total: {valorTotal}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gerar relatório: {ex.Message}");
            }
        }
    }
}
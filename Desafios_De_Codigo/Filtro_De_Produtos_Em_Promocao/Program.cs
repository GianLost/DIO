using System;
using System.Collections.Generic;
using System.Linq;

class ECommerceAPI
{
    // Classe Produto para armazenar as informações de cada produto
    class Produto
    {
        public string Nome { get; }
        public double Preco { get; }
        public int QuantidadeEmEstoque { get; }

        // Construtor da classe Produto
        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }
    }

    static void Main()
    {
        // Lê a quantidade de produtos
        Console.Write("Digite a quantidade de produtos: ");
        int n = int.Parse(Console.ReadLine()!); // Evita CS8604

        // Lê a linha com todos os produtos
        Console.Write("Digite os produtos (nome, preco, quantidade): ");
        string linha = Console.ReadLine()!; // Evita CS8600

        // TODO: Crie a lista para armazenar os produtos
        List<Produto> produtos = new();

        // Divide a linha por vírgula para obter os dados de cada produto
        string[] partes = linha.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Processa os dados de produtos
        for (int i = 0; i < n * 3; i += 3)
        {
            string nome = partes[i].Trim();
            double preco = double.Parse(partes[i + 1].Trim());
            int quantidadeEmEstoque = int.Parse(partes[i + 2].Trim());

            // TODO: Adicione o produto na lista
            produtos.Add(new Produto(nome, preco, quantidadeEmEstoque));
        }

        // TODO: Crie a lista para armazenar os produtos com mais de 50 unidades em estoque
        List<Produto> produtosEmPromocao = FiltraProdutoEmPromocao(produtos);

        string nomes = string.Join(", ", produtosEmPromocao.Select(p => p.Nome));

        // Exibe os nomes dos produtos com mais de 50 unidades em estoque
        Console.WriteLine(nomes);
    }

    // TODO: Filtre os produtos com mais de 50 unidades em estoque
    static List<Produto> FiltraProdutoEmPromocao(List<Produto> produtos)
    {
        List<Produto> resultado = new();

        foreach (var produto in produtos)
        {
            if (produto.QuantidadeEmEstoque > 50)
                resultado.Add(produto);
        }

        return resultado;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public class Compra
{
    public Cliente Cliente { get; set; }

    public List<Produto> Produtos { get; set; }

    public Compra(Cliente cliente){
        Cliente = cliente;
        Produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto){
        Produtos.Add(produto);
    }

    public decimal CalcularTotal(){
        return Produtos.Sum(p => p.Preco);
    }

    public override string ToString(){
        string produtosStr = string.Join(" , ", Produtos.Select(produto=> produto.Nome));
        return $"Compra de {Cliente.Nome}, Produtos: [{produtosStr}], Total: {CalcularTotal():C}";
    }

}
using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    // The Main method is the entry point of the application
    public static void Main()
    {
        Cliente cliente1 = new Cliente(1,"Marcos");
        Cliente cliente2 = new Cliente(2,"João");

        Produto produto1 = new Produto(1,"Notebook",1200.00M);
        Produto produto2 = new Produto(2,"Tablet",120.00M);
        Produto produto3 = new Produto(3,"Celular",800.00M);
        Produto produto4 = new Produto(4,"Ipad",10.00M);

        Compra compra1 = new Compra(cliente1);
        compra1.AdicionarProduto(produto2);
        compra1.AdicionarProduto(produto1);

        Compra compra2 = new Compra(cliente2);
        compra2.AdicionarProduto(produto4);
        compra2.AdicionarProduto(produto3);

        Console.WriteLine(compra1);
        Console.WriteLine(compra2);
    }
}
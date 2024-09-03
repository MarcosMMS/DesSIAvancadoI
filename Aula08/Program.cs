using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    // The Main method is the entry point of the application
    public static void Main()
    {
        // Lista de Numeros
        List<int> numeros = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        List<int> numerosPares = numeros.Where(n => n % 2 == 0).ToList();

        // Numeros Pares
        Console.WriteLine("Números Pares: ");
        numerosPares.ForEach(n => Console.WriteLine(n));

        // Frutas
        List<string> frutas = new List<string> {"Maça", "Banana", "Manga", "Abacaxi", "Melancia", "Morango"};

        List<string> frutasOrdenadas = frutas.OrderBy(f => f).ToList();

        List<string> frutasComM = frutasOrdenadas.Where(f => f.StartsWith("M")).ToList();

        Console.WriteLine("Frutas com M: ");
        frutasComM.ForEach(f => Console.WriteLine(f));

        List<Pessoa> pessoas = new List<Pessoa>{
            new Pessoa("Marcos", 21),
            new Pessoa("Miguel", 30),
            new Pessoa("Rafael", 25),
            new Pessoa("Luis", 25),
            new Pessoa("Igor", 21),
        };

        List<Pessoa> pessoasFiltradas = pessoas.Where(p => p.Idade > 25).OrderBy(p => p.Nome).ToList();

        Console.WriteLine("Pessoas com idade maior que 25: ");
        pessoasFiltradas.ForEach(p => Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}"));
    }
}

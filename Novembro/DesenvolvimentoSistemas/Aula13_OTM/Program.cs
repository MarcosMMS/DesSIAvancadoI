using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Aula13_OTM {

    public class Program {
        static void Main(string[] args) {
            using (var context = new AppDbContext()) {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var categoria = new Categoria { Nome = "Eletrônicos" };
                var produto1 = new Produto { Nome = "TV", Categoria = categoria };
                var produto2 = new Produto { Nome = "Rádio", Categoria = categoria };

                context.Categorias.Add(categoria);
                context.Produtos.AddRange(produto1, produto2);
                context.SaveChanges();

                // Consulta os Dados 
                var categorias = context.Categorias.Include(c => c.Produtos).FirstOrDefault();
                if (categorias != null) {
                    Console.WriteLine($"Categoria: {categorias.Nome}");
                    foreach (var produto in categorias.Produtos) {
                        Console.WriteLine($"Produto: {produto.Nome}");
                    }
                } else {
                    Console.WriteLine("Nenhuma categoria encontrada.");
                }
            }
        }
    }
}

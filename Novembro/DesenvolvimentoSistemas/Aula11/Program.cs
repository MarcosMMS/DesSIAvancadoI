using System.Linq;
using Aula11;

public class Program{

    public static void Main(){
        using (var db = new AppDbContext()){
            db.Database.EnsyreCreated();

            Cliente cliente1 = new Cliente("Marcos", 21);
            db.Cliente.Add(cliente1);
            db.SaveChanges();

            Livro livro1 = new Livro("C# para Ininciantes", 45.00M);
            Livro livro2 = new Livro("Python", 60.00M);
            db.livro.AddRange(livro1, livro2);
            db.SaveChanges();

            Venda venda1 = new Venda(cliente1);
            venda1.AdicionarLivro(livro1);
            venda1.AdicionarLivro(livro2);
            db.Venda.Add(venda1);

            Console.WriteLine(venda1);
        }
    }
}
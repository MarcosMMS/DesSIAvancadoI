using System.Linq;

namespace Aula12{
    public class Program{
        public static void Main(string[] args){
            using(var context = new AppDbContext()){
                //Deleta
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                
                //Bota
                context.Pessoas.Add(new Aluno {Nome = "João", Matricula = "A001"});
                context.Pessoas.Add(new Professor {Nome = "Rafael", Disciplina = "IoT"});
                context.SaveChanges();

                //Ve
                var pessoas = context.Pessoas.ToList();
                foreach(var pessoa in pessoas){
                    Console.WriteLine($"Id: {pessoa.Id}, Nome: {pessoa.Nome}");
                }
                
            }
        }
    }
}
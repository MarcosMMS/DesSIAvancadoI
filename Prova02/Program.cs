using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Prova02{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var aluno1 = new Aluno { Nome = "Gustavo Gonçalves" };
                var aluno2 = new Aluno { Nome = "Marcos Moreira" };
                

                var disciplina1 = new Disciplina { NomeDisciplina = "Redes" };
                var disciplina2 = new Disciplina { NomeDisciplina = "Analise" };
                

                aluno1.Disciplinas.Add(disciplina1);
                aluno2.Disciplinas.Add(disciplina2);

                disciplina1.Alunos.Add(aluno1);
                disciplina2.Alunos.Add(aluno2);
                
                context.SaveChanges();

                // Consultando
                var alunos = context.Alunos.Include(a => a.Disciplinas).ToList();
                foreach (var aluno in alunos)
                {
                    Console.WriteLine($"Aluno: {aluno.Nome}");
                    foreach (var disciplina in aluno.Disciplinas)
                    {
                        Console.WriteLine($"Disciplina: {disciplina.NomeDisciplina}");
                    }
                }

                var disciplinas = context.Disciplinas.Include(a => a.Alunos).ToList();
                foreach (var disciplina in disciplinas)
                {
                    Console.WriteLine($"Disciplinas: {disciplina.NomeDisciplina}");
                    foreach (var aluno in disciplina.Alunos)
                    {
                        Console.WriteLine($"Aluno: {aluno.Nome}");
                    }
                }
            }
        }
    }
}

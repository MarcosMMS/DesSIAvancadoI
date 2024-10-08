using Microsoft.EntityFrameworkCore;

namespace Aula12{
    public class Aluno : Pessoa{
        public string Matricula { get; set; } = string.Empty;
    }
}
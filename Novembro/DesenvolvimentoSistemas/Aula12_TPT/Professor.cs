using Microsoft.EntityFrameworkCore;

namespace Aula12{
    public class Professor : Pessoa{
        public string Disciplina { get; set; } = string.Empty;
    }
}
public class Disciplina {
    public int Id { get; set; }
    public string NomeDisciplina { get; set; }
    public int CodigoDisciplina { get; set; }
    public List<Aluno> Alunos { get; set; } = new List<Aluno>();
}
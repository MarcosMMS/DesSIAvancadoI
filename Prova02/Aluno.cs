public class Aluno {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public int Idade { get; set; }
    public IList<Disciplina> Disciplinas { get; set; }
}
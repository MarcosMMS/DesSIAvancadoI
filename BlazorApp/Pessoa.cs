using System.ComponentModel.DataAnnotations;
public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public int Idade { get; set; }
    public string Email { get; set; }
}

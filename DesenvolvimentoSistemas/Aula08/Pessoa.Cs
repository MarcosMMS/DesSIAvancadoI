public class Pessoa{
    private string? nome;
    private int idade;

    public Pessoa(string nome, int idade){
        Nome = nome;
        Idade = idade;
    }

    public string Nome{
        get { return nome; }
        set { nome = value; }
    }

    public int Idade{
        get { return idade; }
        set { idade =  value; }
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}";
    }
}
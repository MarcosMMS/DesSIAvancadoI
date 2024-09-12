class Pessoa{
    private string nome = "";


    public string Nome{
        get {return nome;}
        set {nome = value;}
    }

    public Pessoa(string nome){
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}";
    }

}
public struct PessoaStruct{
    private string nomeStruct = "";

    public string NomeStruct{
        get {return nomeStruct;}
        set {nomeStruct = value;}
    }

    public PessoaStruct(string nomeStruct){
        NomeStruct = nomeStruct;
    }

    public override string ToString()
    {
        return $"NomeStruct: {NomeStruct}";
    }
}
class Program{
    public static void Main(string [] args){
        Pessoa objPessoa = new Pessoa("Rafael");
        Console.WriteLine("Antes do metodo (Classe):" + objPessoa.ToString());
        AlteraNomeClasse(objPessoa);
        Console.WriteLine("Depois do metodo (Classe):"+ objPessoa.ToString());

        PessoaStruct pessoaStruct = new PessoaStruct("Silva");
        Console.WriteLine("Antes do metodo(struct): " + pessoaStruct.ToString());
        AlteraNomeStruct(pessoaStruct);
        Console.WriteLine("Depois do metodo Struct: " + pessoaStruct.ToString());
    }

    public static void AlteraNomeClasse(Pessoa objAux){
        objAux.Nome = "Marcos";
    }

    public static void AlteraNomeStruct(PessoaStruct objAux){
        objAux.NomeStruct = "Moreira";
    }
}
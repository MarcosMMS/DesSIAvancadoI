class Program{
    public static void Main(string [] args){
        Pessoa objPessoa = new Pessoa("Rafael");
        Console.WriteLine("Antes do metodo (Classe):" + objPessoa.ToString());
        AlteraNomeClasse(objPessoa);
        Console.WriteLine("Depois do metodo (Classe):"+ objPessoa.ToString());
    }

    public static void AlteraNomeClasse(Pessoa objAux){
        objAux.Nome = "Daniely";
    }
}
using System;
public class Pessoa{

    private string nome = string.Empty;

    private int nota;

    public Pessoa(string nome, int nota){

        Nome = nome;
        Nota = nota;

    }

    public string Nome{
        get {return nome;}
        set {nome = value;}
    }

    public int Nota{
        get {return nota;}
        set {nota = value;}
    }

    public override string ToString(){
        return 
    }

}
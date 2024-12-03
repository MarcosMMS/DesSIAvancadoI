namespace Aula11.Models{

    public class Cliente
    {
        public int Id{ get; set; }

        public string Nome{ get; set; }

        public int Idade{ get; set; }

        public Cliente(string nome, int idade){
            Nome = nome;
            Idade = idade;
        }

        public override string ToString(){
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }

}

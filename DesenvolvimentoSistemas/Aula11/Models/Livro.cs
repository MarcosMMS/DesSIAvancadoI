namespace Aula11.Models
{
    public class Livro{
        public int id {get; set;}

        public string Nome{ get; set; }

        public decimal Preco{ get; set; }

        public Livro(string nome, decimal preco){
            Nome = nome;
            Preco = preco;
        }

        public override string ToString(){
            return $"Nome: {Nome}, Preco: {Preco:C}";
        }
    }
}
namespace Aula11.Models
{
    public class Venda{
        public int id { get; set; }
        public Cliente Cliente { get; set; }
        public List<Livro> Livros { get; set; }

        public Venda(){
            Cliente = new Cliente("",0);
            Livros = new List<Livro>();
        }

        public Venda(Cliente cliente;){
            Cliente = cliente;
            Livros = new List<Livro>();
        }

        public void AdicionarLivro(Livro livro){
            Livros.Add(livro);
        }

        public override string ToString(){
            string livrosStr = string.Join(" , ", Livros.Select(livro=> livro.Nome));
            return $"Compra de {Cliente.Nome}, Produtos: [{livrosStr}], Total: {CalcularTotal():C}";
        }
    }
}
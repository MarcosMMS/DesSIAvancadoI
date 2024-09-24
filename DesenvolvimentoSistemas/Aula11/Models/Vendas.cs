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
        
        public decimal CalcularTotal(){
        return Livros.Sum(l => l.Preco);
        }

        public void ListarLivrosMaisCaros(decimal precoMinimo){
            var livrosCaros = Livros.Where(l => l.Preco > precoMinimo).OrderBy(l => l.Nome).ToList();
            if(livrosCaros.Count > 0){
                Console.WriteLine($"Livros com preco maior que {precoMinimo:C}");
                livrosCaros.foreach(l => Console.WriteLine(l));
            }else{
                Console.WriteLine($"Nenhum livro com o preco maior que {precoMinimo:C}")
            }
        }

        public void LivroEmOrdem(){
            var livrosOrdenados = Livros.OrderBy(l => l.Nome).ToList();
            livrosOrdenados.ForEach(l => Console.WriteLine(l));
        }

        public override string ToString(){
            string livrosStr = string.Join(" , ", Livros.Select(l=> l.Nome));
            return $"Venda para {Cliente.Nome}, Produtos: [{livrosStr}], Total: {CalcularTotal():C}";
        }
    }
}
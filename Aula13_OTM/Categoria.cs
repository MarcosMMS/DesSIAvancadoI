namespace Aula13_OTM {

    public class Categoria{
        public int CategoriaId { get; set; }
        public string Nome { get; set; } = string.Empty;

        public List<Produto> Produtos { get; set; } = new List<Produto>();

    }

    // Relacionamente de N:N

}
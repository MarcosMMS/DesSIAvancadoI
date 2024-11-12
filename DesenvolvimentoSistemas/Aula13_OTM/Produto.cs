namespace Aula13_OTM {
    public class Produto {
        public int ProdutoId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } = null;
    }
}


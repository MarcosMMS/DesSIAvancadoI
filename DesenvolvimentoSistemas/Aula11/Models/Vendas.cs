namespace Aula11.Models
{
    public class Venda{
        public int id { get; set; }
        public Cliente cliente { get; set; }
        public Livro livro { get; set; }
    }
}
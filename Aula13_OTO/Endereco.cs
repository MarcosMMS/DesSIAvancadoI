namespace Aula13_OTO {

    public class Endereco {
        public int EnderecoId { get; set; }
        public string Rua { get; set; } = string.Empty;
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; } = null;
    }
}
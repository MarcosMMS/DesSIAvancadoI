public class Main {
    public static void main(String[] args) {

        Produto produto1 = new Produto("Teclado", 100.00);
        Produto produto2 = new Produto("Mouse", 50.00);
        Produto produto3 = new Produto("Monitor", 500.00);

        Caixa caixaPrincipal = new Caixa();

        caixaPrincipal.adicionarProduto(produto1);
        caixaPrincipal.adicionarProduto(produto2);
        caixaPrincipal.adicionarProduto(produto3);

        System.out.println("Preço total sem desconto: " + caixaPrincipal.getPreco());

        System.out.println("Preço total com desconto: " + caixaPrincipal.aplicarDescontoProgressivo());
    }
}

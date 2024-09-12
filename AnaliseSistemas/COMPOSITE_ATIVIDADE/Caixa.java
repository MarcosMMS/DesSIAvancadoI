import java.util.ArrayList;
import java.util.List;

public class Caixa implements CaixaProdutos {
    private List<CaixaProdutos> itens;
    private double desconto = 0.05; 

    public Caixa() {
        this.itens = new ArrayList<>();
    }

    public void adicionarProduto(CaixaProdutos item) {
        itens.add(item);
        aplicarDescontoProgressivo();
    }

    public void removerProduto(CaixaProdutos item) {
        itens.remove(item);
    }

    @Override
    public double getPreco() {
        double total = 0;
        for (CaixaProdutos item : itens) {
            total += item.getPreco();
        }
        return total;
    }

    public double aplicarDescontoProgressivo() {
        double total = 0;
        int numProdutos = itens.size();
        double descontoTotal = 1 - (desconto * numProdutos); 

        for (CaixaProdutos item : itens) {
            total += item.getPreco();
        }

        return total * descontoTotal;
    }
}

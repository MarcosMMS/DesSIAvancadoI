public class Program{

        /*
        - 0 Action<T1, T2>: Representa um método que aceita 16 parâmetros e não retorna valor (void)

        - Func<T, TResult>: Representa um método que aceita até 16 parâmetros e retorna um valor tipo TResult
        */

    public static void MostrarMensagem(string mensagem){
        Console.WriteLine("Mensagem: " + mensagem);
    }

    public static int Somar(int a, int b){
        return a + b;
    }

    public static void Main(string [] args){
        Action<string> action = MostrarMensagem;
        action("Olá mundo");

        Func<int, int, int> operacao = Somar;
        Console.WriteLine("Soma: "+ operacao(5,3));

        Action<int, int> exibirOperacoes = (x, y) => {
            Console.WriteLine("Soma: "+ (x + y));
            Console.WriteLine("Multiplicação: " + (x * y));
        };

        exibirOperacoes(10,6);

        Func<int, int> calcularQuadrado = (x) => x*x;

        Func<int, int, int> executarOperacao = (x, y) => {
            return calcularQuadrado(x) + calcularQuadrado(y);

        };
        Console.WriteLine("Quadrado de 5 é: " + calcularQuadrado(5));
        Console.WriteLine("Resultado da operação: " + executarOperacao(2,2));



    }




}
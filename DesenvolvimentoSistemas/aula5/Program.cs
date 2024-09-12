using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numInt = 45;
        double numDouble = numInt;
        Console.WriteLine("Conversão implícita de int para double");
        Console.WriteLine($"Int: {numInt}, Double: {numDouble}");

        double valorDouble = 7.45;
        int valorConvertInt = Convert.ToInt32(valorDouble);
        string textValor = "123";
        int textValorConvertidoInt = Convert.ToInt32(textValor);

        Console.WriteLine("Conversão de double para int");
        Console.WriteLine($"Double: {valorDouble}, Int convertido: {valorConvertInt}, String convertida: {textValorConvertidoInt}");

        string textDecimal = "12.75";
        double decimalString = double.Parse(textDecimal);
        Console.WriteLine($"String: {textDecimal}, Double: {decimalString}");
        string teste = decimalString.ToString();

        char caractere = 'A';
        int codigoAscii = (int) caractere;
        Console.WriteLine($"Char: {caractere}, Ascii{codigoAscii}");
    }
}

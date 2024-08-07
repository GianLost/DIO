using System;

// Entrada
// A entrada é composta por três strings, representando os parâmetros:

// P: O valor inicial do investimento (principal).
// i: A taxa de juros anual (expressa como um decimal). Por exemplo, 5% deve ser representado como 0.05.
// n: O número de anos que o dinheiro será investido.
// Esses valores serão fornecidos na seguinte ordem: P, i, n.

// Saída
// A função deverá retornar o montante final após o período de investimento, considerando a capitalização dos juros (juros compostos). O resultado deve ser um número representando o valor total após a aplicação dos juros compostos sobre o investimento inicial ao longo do tempo especificado.

public class Program
{
    public static void Main(string[] args)
    {
        // Solicita ao usuário para inserir os valores
        double P = Convert.ToDouble(Console.ReadLine()); // Lê o valor principal P

        double i = Convert.ToDouble(Console.ReadLine()); // Lê a taxa de juros i

        int n = Convert.ToInt32(Console.ReadLine()); // Lê o número de períodos n

        // Calcula o montante final utilizando a função CalcularJurosSimples
        double montanteFinal = CalcularJurosSimples(P, i, n);

        // Exibe o resultado
        Console.WriteLine(montanteFinal); // Mostra o montante final calculado
    }

    public static double CalcularJurosSimples(double P, double i, int n)
    {
        // TODO: Calcule e retorne o montante final com juros simples
        double A = P + (P * i * n);
        
        return A;
    }
}
namespace Validacao_De_Nota.Models;
public class Avaliacao
{
    private double nota1;
    private double nota2;
    
    // Método de chamada para iniciar avaliação
    public void IniciarAvaliacao()
    {
        // Solicita e armazena a primeira nota
        nota1 = ObterNotaValida("Nota 1:");

        // Solicita e armazena a segunda nota
        nota2 = ObterNotaValida("Nota 2:");

        // Utiliza o método "CalculaMedia" para retornar a média das notas
        CalculaMedia();
    }

    private static double ObterNotaValida(string mensagem)
    {
        do
        {
            // Exibe a mensagem para o usuário de qual nota informar
            Console.WriteLine(mensagem);

            // Tenta converter a entrada do usuário para um número double
            // Verifica se a nota está no intervalo válido (entre 0 e 10)
            if (!double.TryParse(Console.ReadLine(), out double nota) || nota < 0 || nota > 10)
                Console.WriteLine("nota invalida"); // Se a nota não for válida, exibe uma mensagem de erro
            else
                return nota; // Se a nota for válida, retorna o valor da nota
        } while (true);
    }

    private void CalculaMedia()
    {
        // Calcula a média das duas notas
        double media = (nota1 + nota2) / 2;

        // Exibe a média calculada na tela
        Console.WriteLine($"media = {media}");
    }
}
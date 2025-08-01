using System;

class CarroMonitoramento
{
    // TODO: Calcule a idade do carro
    public static int CalcularIdade(int anoFabricacao, int anoAtual) => anoAtual - anoFabricacao;

    // TODO: Verifique se o carro tem até 10 anos
    public static bool TemAte10Anos(int anoFabricacao, int anoAtual) => CalcularIdade(anoFabricacao, anoAtual) <= 10;

    // TODO: Crie o método estático que verifica se o carro está apto
    public static string VerificaAptidao(string modelo, int anoFabricacao, int anoAtual)
    {
        if (TemAte10Anos(anoFabricacao, anoAtual))
            return $"{modelo}: Apto";
        else
            return $"{modelo}: Nao apto";
    }

    static void Main()
    {
        // Lendo os dados de entrada
        Console.WriteLine("Digite o modelo do carro:");
        string? modelo = Console.ReadLine();

        Console.WriteLine("Digite o ano de fabricação do carro:");
        int anoFabricacao = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o ano atual:");
        int anoAtual = int.Parse(Console.ReadLine());

        // Chamada do método para verificar se o carro está apto
        string? resultado = VerificaAptidao(modelo, anoFabricacao, anoAtual);

        // Exibindo o resultado
        Console.WriteLine(resultado);
    }
}
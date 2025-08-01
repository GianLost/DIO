using System;

class Bicicleta
{
    static void Main()
    {
        // Leitura do modelo
        Console.WriteLine("Digite o modelo da bicicleta:");
        string? modelo = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(modelo))
        {
            Console.WriteLine("Modelo inválido.");
            return;
        }

        // Leitura do nível de bateria
        Console.WriteLine("Digite o nível de bateria (0 a 100):");
        string? nivelStr = Console.ReadLine();

        if (!int.TryParse(nivelStr, out int nivelBateria))
        {
            Console.WriteLine("Nível de bateria inválido.");
            return;
        }

        // Criação do objeto BicicletaInterna
        BicicletaInterna bicicleta = new(modelo, nivelBateria);

        // Exibição da mensagem
        Console.WriteLine(bicicleta.ObterMensagem());
    }
}

// Classe interna para representar a bicicleta
class BicicletaInterna(string modelo, int nivelBateria)
{
    private readonly string modelo = modelo;
    private readonly int nivelBateria = nivelBateria;

    public double CalcularDistancia() => nivelBateria * 0.5;

    public string ObterMensagem() => $"{modelo}: Distancia estimada = {CalcularDistancia():F1} km";
}
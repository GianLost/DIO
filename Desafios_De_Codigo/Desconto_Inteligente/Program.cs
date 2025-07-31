// Lê o valor original do produto
Console.WriteLine("Digite o valor original do produto:");
double valorOriginal = Convert.ToDouble(Console.ReadLine());

// Lê a porcentagem de desconto
Console.WriteLine("Digite a porcentagem de desconto:");
double porcentagemDesconto = Convert.ToDouble(Console.ReadLine());

// TODO: Verifique se o desconto está dentro de um intervalo válido
if (porcentagemDesconto < 0 || porcentagemDesconto > 100)
    Console.WriteLine("desconto invalido.");

// TODO: Calcule o valor final do produto
double valorFinal = valorOriginal * (1 - porcentagemDesconto / 100);

// Exibe o valor com duas casas decimais
Console.WriteLine($"{valorFinal:F2}");
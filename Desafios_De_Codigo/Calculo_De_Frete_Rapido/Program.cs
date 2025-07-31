Console.WriteLine("Digite o peso em quilos:");
double peso = Convert.ToDouble(Console.ReadLine());

// TODO: Leia o valor do frete por quilo
Console.WriteLine("Digite o valor do frete por quilo:");
double frete = Convert.ToDouble(Console.ReadLine());

// TODO: Calcule o valor total do frete
double valorTotalFrete = peso * frete;

// TODO: Exiba o valor formatado com duas casas decimais
Console.WriteLine($"{valorTotalFrete:F2}");
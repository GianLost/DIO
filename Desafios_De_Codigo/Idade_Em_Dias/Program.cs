// DESAFIO
// Você terá o desafio de ler um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

// OBS.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. 

// ENTRADA
// O arquivo de entrada contém um valor inteiro.

// SAÍDA
// Imprima a saída conforme exemplo fornecido.

Console.WriteLine("Vamos saber quantos anos, meses e dias de vida você tem...");
Console.WriteLine();
Console.WriteLine("Informe sua idade em dias:");
int dias = int.Parse(Console.ReadLine());

int anos = dias / 365;
dias %= 365;
int meses = dias / 30;
dias %= 30;

Console.WriteLine("Você possui:");
Console.WriteLine($"{anos} ano(s)");
Console.WriteLine($"{meses} mes(es)");
Console.WriteLine($"{dias} dia(s)");
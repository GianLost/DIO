// DESAFIO
// Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

// ENTRADA
// O arquivo de entrada contém um valor inteiro N.

// SAÍDA
// Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.

int timeInSeconds = int.Parse(Console.ReadLine());

int hours = timeInSeconds / 3600;
timeInSeconds %= 3600;
int minutes = timeInSeconds / 60;
int seconds = timeInSeconds % 60;

Console.WriteLine($"{hours}:{minutes}:{seconds}");

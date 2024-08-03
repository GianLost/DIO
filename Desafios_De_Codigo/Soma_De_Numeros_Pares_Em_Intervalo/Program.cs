// DESCRIÇÃO :
// Para este desafio, vamos aplicar outros conceitos fundamentais de programação, agora, criaremos um programa que calcule a soma dos números pares em um intervalo específico. Dessa forma, desenvolva uma solução clara, simples e organizada, você pode criar variáveis com nomes representativos, como limiteInferior, limiteSuperior e somaPares. Utilize uma estrutura de controle de fluxo, como o `for` para percorrer todos os números no intervalo definido pelos `limiteInferior e o limiteSuperior`. Dentro desse loop, crie uma estrutura condicional `if ` para verificar se cada número é par e se o resto da divisão por 2 é igual a zero (i % 2 == 0). Se a condição for verdadeira, o número é somado à variável somaPares.

// ENTRADA :
// Será as informações de limiteInferior e limiteSuperior, sendo eles dois números inteiros(int).

// SAÍDA :
// A saída deverá informar uma String com o resultado final: $"A soma dos números pares de {limiteInferior} a {limiteSuperior} e: {somaPares}".
Console.WriteLine("Digite o 1º número");
int limiteInferior = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o 2º número");
int limiteSuperior = int.Parse(Console.ReadLine());

// Variável para acumular a soma dos números pares
int somaPares = 0;

// TODO: Crie um Loop para percorrer os números no intervalo
// Lembre-se: O limiteSuperior deve ser menor ou igual a i;

for (int i = limiteInferior; i <= limiteSuperior; i++)
{
    // TODO: Implemente o if para verificar se o número é par:
    bool numeroPar = i % 2 == 0;
    
    // TODO: Crie o acumulador para a soma dos números pares:
    if (numeroPar)
    {
        somaPares += i;
    }
}

// Exibe o resultado
Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");
// DESAFIO :
// Pink e Cérebro dividem um apartamento e estão juntos 24h por dia desde o começo da pandemia. Para passar o temp, Pink cria problemas matemáticos para Cérebro resolver, o último deles foi uma lista de números com a seguinte pergunta: quantos números da lista são múltiplos de 2, 3, 4 e 5?

// Apesar de parecer simples, porém, quando a lista contém muitos números, Cérebro se confunde e acaba errando alguns cálculos.

// Ajude Cérebro a resolver o desadio de Pink.

// ENTRADA :
// A primeira linha da entrada consiste em um inteiro N (1 ≤ N ≤1000), representando a quantidade de números na lista de Pink.

// A segunda linha contém N inteiros Li (1 ≤ Li ≤ 100), representando os números da lista de Pink.

// SAÍDA :
// Imprima a quantidade de números múltiplos de 2, 3, 4 e 5 presentes na lista. Observe a formatação da saída nos exemplos, pois ela deve ser seguida rigorosamente.

Console.WriteLine("Informe um tamanho para sua lista de números");
int suavariavel = int.Parse(Console.ReadLine());

Console.WriteLine("Informe sua lista de números separados por espaço. EX: (2 5 4 20 10)");
string[] n = Console.ReadLine().Split(null);

int multiplo2 = 0;
int multiplo3 = 0;
int multiplo4 = 0;
int multiplo5 = 0;

for (int iContador = 0; iContador < suavariavel; iContador++)
{
    if (int.Parse(n[iContador]) % 2 == 0)
        multiplo2++;
    if (int.Parse(n[iContador]) % 3 == 0)
        multiplo3++;
    if (int.Parse(n[iContador]) % 4 == 0)
        multiplo4++;
    if (int.Parse(n[iContador]) % 5 == 0)
        multiplo5++;
}

Console.WriteLine("------------------------------");

Console.WriteLine($"{multiplo2} Multiplo(s) de 2");
Console.WriteLine($"{multiplo3} Multiplo(s) de 3");
Console.WriteLine($"{multiplo4} Multiplo(s) de 4");
Console.WriteLine($"{multiplo5} Multiplo(s) de 5");
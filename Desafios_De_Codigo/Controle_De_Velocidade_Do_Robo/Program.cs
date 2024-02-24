using Controle_De_Velocidade_Do_Robo.Models;

// DESAFIO : 
// Você foi contratado para criar um software que simule o controle de velocidade de um robô. Esse robô possui uma velocidade máxima e uma velocidade mínima. Sua tarefa é desenvolver um programa  utilizando o conceito de Orientação a Objetos para calcular a velocidade final do robô após uma sequência de comandos.Crie uma classe chamada "Robo" que possua as seguintes propriedades e métodos:

// velocidadeAtual: inteiro que representa a velocidade atual do robô (inicialmente 0);
// velocidadeMaxima: inteiro que representa a velocidade máxima do robô;
// velocidadeMinima: inteiro que representa a velocidade mínima do robô;
// acelerar(): um método que aumenta a velocidade atual em 1 unidade, desde que não ultrapasse a velocidade máxima;
// desacelerar(): um método que diminui a velocidade atual em 1 unidade, desde que não fique abaixo da velocidade mínima.

// ENTRADA :
// A entrada consiste em duas linhas: A primeira linha contém dois inteiros Vmin e Vmax (1 ≤ Vmin < Vmax ≤ 100), representando a velocidade mínima e máxima do robô, respectivamente.
// A segunda linha contém uma sequência de comandos (com no máximo 100 caracteres), onde: 'A' representa uma aceleração e 'D' representa uma desaceleração. Desta maneira, a entrada seria da seguinte maneira:

// Vmin Vmax: ambos valores int.
// comandos: string.

// SAÍDA
// A saída deve apresentar apenas a velocidade final (int)  do robô, considerando as regras descritas nos métodos de acelerar e desacelerar.

Console.WriteLine("Informe a Vmin e Vmáx do robô EX:(1 12)");
string[] velocidades = Console.ReadLine().Split(); // Recebendo a velocidade mínima e máxima do robô na mesma linha;

int vmin = int.Parse(velocidades[0]); // atribuindo a velocidade mínima com base no array de velocidades;
int vmax = int.Parse(velocidades[1]); // atribuindo a velocidade máxima com base no array de velocidades;

// Validação que verifica se vmin é menor que um, se vmax é maior que cem e se vmin não é maior ou igual a vmax
if (vmin < 1 || vmax > 100 || vmin >= vmax)
{
    Console.WriteLine("Entrada inválida para velocidades.");
    return;
}

Console.WriteLine("Utilize até 100 caractéres para (A) acelerar ou (D) desacelerar o robô");
string comandos = Console.ReadLine(); // Recebendo a linha de comandos para acelerar ou desacelerar o robô

// validando se a string possui mais de cem caractéres
if (comandos.Length > 100)
{
    Console.WriteLine($"Entrada inválida para sequência de comandos.");
    return;
}

Robo robo = new(vmin, vmax); // Instância de robô passando os valores de construção exigidos

// Laço que passa por cada caractér da string de comandos realizando as ações de acelerar e desacelerar do robô
foreach (char comando in comandos)
{
    char upperComando = char.ToUpper(comando);
    if (upperComando == 'A')
    {
        robo.Acelerar();
    }
    else if (upperComando == 'D')
    {
        robo.Desacelerar();
    }
}

Console.WriteLine(robo.VelocidadeAtual); // Exibição no console do valor da velociade atual do robô

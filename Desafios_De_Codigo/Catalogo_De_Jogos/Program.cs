
// DESCRIÇÃO :
// Neste desafio, o objetivo é criar um catálogo de jogos que permita ao usuário adicionar uma quantidade específica de jogos. Inicie solicitando a quantidade desejada e, em seguida, peça o nome de cada jogo individualmente, armazenando-os em um array chamado nomesJogos. Utilize um loop `for` para facilitar a adição dos jogos. Após a conclusão, exiba um resumo em uma única linha, indicando a quantidade total de jogos adicionados e a lista de nomes no catálogo.

// ENTRADA :
// O programa inicia solicitando ao usuário que insira a quantidade de jogos que deseja adicionar ao catálogo. Em seguida, para cada jogo, o usuário é solicitado a inserir o nome do jogo.

// SAÍDA :
// Ao final da adição dos jogos, o programa exibe um resumo que inclui a quantidade total de jogos adicionados e uma lista com os nomes dos jogos separados por vírgulas. Este resumo fornece uma visão geral dos jogos que foram incluídos no catálogo.


// Pergunta ao usuário quantos jogos deseja adicionar:
Console.WriteLine($"Quantos jogos gotaria de adicionar ao catálogo ?");
int quantidadeJogos = int.Parse(Console.ReadLine());

// TODO: Inicializa os arrays com base na quantidade informada pelo usuário:
string[] nomesJogos = new string[quantidadeJogos];

// TODO: Crei um Loop para adicionar jogos conforme a quantidade especificada:
for (int i = 0; i < quantidadeJogos; i++)
{
    //TODO: Chame a função AdicionarJogo para obter o nome do jogo e armazená-lo no array:
    Console.WriteLine($"Informe o nome do jogo {i + 1}:");
    AdicionarJogo(i, nomesJogos);
}

// Exibe o resumo da adição de jogos
ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);

static void AdicionarJogo(int indice, string[] nomes)
{
    // Entrada do nome do jogo
    nomes[indice] = Console.ReadLine();
}

static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
{
    Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {string.Join(", ", nomes)} ao catalogo.");
}

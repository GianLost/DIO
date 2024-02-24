using Criando_Um_Jogador_De_Futebol.Models;

// DESAFIO
// Você deve criar um programa que crie um objeto jogador com nome, nacionalidade, idade e posição. O jogador deve ser criado a partir de uma classe "Jogador" com o método "novo" e os atributos mencionados.

// ENTRADA
// O programa deve ler as informações do jogador nessa ordem: 

// nome: string
// nacionalidade: string
// idade: inteiro
// posição: strig

// SAÍDA
// O programa deve imprimir as informações do jogador criado, uma por linha, com a mensagem "Jogador criado!" no início. As informações devem ser exibidas na seguinte ordem: nome, nacionalidade, idade e posição (com a mensagem "Posição:" na frente). Veja a estrutura abaixo:

// Jogador criado!
// [nome]
// [nacionalidade]
// [idade]
// Posição: [posição]

Console.WriteLine("Vamos criar o seu jogador !");

// Obtendo via console o nome do jogador
Console.WriteLine("Informe o nome do jogador: ");
string nome = Console.ReadLine();

// Obtendo via console a nacionalidade do jogador
Console.WriteLine("Informe a nacionalidade do jogador: ");
string nacionalidade = Console.ReadLine();

// Obtendo via console a idade do jogador
Console.WriteLine("Informe a idade do jogador: ");
int idade = Convert.ToInt32(Console.ReadLine());

// Obtendo via console a posição do jogador
Console.WriteLine("Informe a posição do jogador: ");
string posicao = Console.ReadLine();

// Instância da classe jogador passando os atributos de construção
Jogador jogador = new
(
    nome: nome, 
    nacionalidade: nacionalidade, 
    idade: idade, 
    posicao: posicao
);

// Adicionando um novo jogador
jogador.Novo(jogador);

// Exibindo as insformações do jogador
jogador.ListarJogador();


using Primeiro_Desafio_POO.Models;

// DESAFIO
// Você acabou de aprender POO e foi desafiado a criar o seu primeiro projeto. Neste código, você deve criar uma classe chamada Pessoa com dois atributos: nome e idade. Em seguida, deve implementar dois métodos para obter esses atributos: getNome() e getIdade(). Por fim, deve criar um objeto do tipo Pessoa e exibir na tela o nome e a idade usando os métodos criados.

// REQUISITOS:

// Utilizar classes e métodos para implementar o programa;
// Implementar a classe Pessoa com os atributos nome e idade, e o método get para cada atributo;
// O programa deve solicitar que o usuário insira o nome e a idade da pessoa;
// O programa deve exibir o nome e a idade da pessoa inserida pelo usuário.

// ENTRADA
// A entrada deverá receber as informações do objeto Pessoa, conforme exemplo abaixo:
// nome (string)
// idade (int)

// SAÍDA
// O código deverá retornar uma mensagem (string) informando o nome e idade da pessoa, de acordo com o que foi recebido como entrada. Veja como exemplo a entrada recebida abaixo:
// João
// 26

// De acordo com esses valores de entrada, a saída ficará desta maneira:
// Nome: João, Idade: 26

Pessoa pessoa = new();

pessoa.Nome = pessoa.GetNome();
pessoa.Idade = pessoa.GetIdade();

Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
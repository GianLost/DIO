﻿using A_Batalha_Dos_RPGistas_Heranca_E_Subclasse.Models;

// DESAFIO :
// Em jogos de RPG, os personagens frequentemente possuem subclasses que representam especializações em determinadas áreas de combate, como por exemplo, "mago", "guerreiro", "ladino", etc. Neste desafio, você deve criar duas classes, "Personagem" e "Subclasse", que ilustrem o conceito de herança em POO.

// Crie a classe "Personagem" que possua o atributo "nome" e "mana".

// Crie a classe "Subclasse" que herda de "Personagem" e acrescenta o atributo "dano_base" e o método "calcular_dano", que recebe como argumento a quantidade de mana que será usada no ataque e retorna o dano causado pelo ataque, que é calculado como o valor de "dano_base" multiplicado pela quantidade de mana usada.

// ENTRADA :
// A entrada será dada pela chamada da classe "Subclasse" e seus métodos, para obter os valores dos atributos de cada personagem e a quantidade de mana usada no ataque.Os valores a serem recebidos serão:

// nome: nome do personagem
// mana: quantidade de mana do personagem
// dano base: referente ao dano base da subclasse
// Importante: a entrada deverá ocorrer de acordo com a ordem das informações fornecidas acima.

// SAÍDA :
// A saída deverá ser a impressão da mensagem "Nome do personagem atacou e causou X de dano!", onde "Nome do personagem" é o nome do personagem fornecido na entrada e "X" é o valor de dano calculado pela subclasse a partir da quantidade de mana usada no ataque. Conforme exemplos abaixo.

Console.WriteLine("Nome do Personagem: ");
string nome = Console.ReadLine();

Console.WriteLine("Quantidade de mana do personagem: ");
int mana = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Dano base do ataque: ");
int danoBase = Convert.ToInt32(Console.ReadLine());

Subclasse personagem = new 
(
    nome: nome, 
    mana: mana, 
    danoBase: danoBase
);

personagem.CalcularDano();
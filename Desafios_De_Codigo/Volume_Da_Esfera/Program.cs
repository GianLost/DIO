// DESAFIO :
// Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.

// DICA : Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas linguagens (dentre elas o C++), assumem que o resultado da divisão entre dois inteiros é outro inteiro.

// ENTRADA :
// O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio da esfera.

// SAÍDA :
// A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes e um espaço depois da igualdade. O valor deverá ser apresentado com 3 casas após o ponto.

double pi, raio, volume;

pi = 3.14159;

Console.WriteLine("Informe o raio da esfera");
raio = double.Parse(Console.ReadLine());

//TODO: Complete os espaços em branco com uma possível solução para o desafio 
volume = 4.0 / 3 * pi * Math.Pow(raio, 3);

Console.WriteLine($"VOLUME = {volume:0.000}");
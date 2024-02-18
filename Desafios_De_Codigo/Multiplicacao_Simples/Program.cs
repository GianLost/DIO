// DESAFIO :
// Você receberá dois valores inteiros. Faça a leitura e em seguida calcule o produto entre estes dois valores. Atribua esta operação à variável PROD, mostrando esta de acordo com a mensagem de saída esperada (exemplo abaixo).   

// ENTRADA :
// A entrada contém 2 valores inteiros.

// SAÍDA :
// Exiba a variável PROD conforme exemplo abaixo, tendo obrigatoriamente um espaço em branco antes e depois da igualdade.

int a, b, resultado;

Console.WriteLine("Digite o 1º número: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o 2º número: ");
b = Convert.ToInt32(Console.ReadLine());

resultado = a * b;

Console.WriteLine($"PROD = {resultado}"); //implemente o código que representa a multiplicação.
Console.ReadLine();
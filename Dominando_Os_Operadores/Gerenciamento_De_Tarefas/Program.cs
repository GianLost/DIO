//  DESCRIÇÃO :
// Agora, focaremos em outro conceito fundamental de programação para desenvolver um algoritmo que possua como objetivo a simulação de um Sistema de Gerenciamento de Tarefas. Dessa forma, crie variáveis como, titulo, descricao e dataVencimento para guardar as informações das tarefas, após isso, implemente uma estrutura condicional 'if/else' para verificar se a descrição da tarefa excede 50 caracteres. Caso a descrição exceda 50 carateres, trataremos essa condição exibindo uma mensagem adequada. Lembrando que as estruturas condicionais são fundamentais para o controle de fluxo dos programas pois realizam verificações precisas com base em condições específicas predefinidas, neste caso, é o limite de 50 caracteres.

// ENTRADA :
// A entrada será as Strings com o titulo da tarefa, a descrição e a data de vencimento.

// SAÍDA :
// Será exibido a tarefa que foi adicionada com o título, descrição e data de vencimento. Mas caso a descrição tenha mais de 50 caracteres deverá ser informado: 'O Valor da descrica excede a quantidade de caracteres permitido'.

string Titulo;
string Descricao;
string DataDeVencimento;

// Obtém o titulo e a descricao a partir da entrada do console
Console.WriteLine("Informe um titulo para a sua tarefa :");
Titulo = Console.ReadLine();

Console.WriteLine("Informe uma descrição para a sua tarefa :");
Descricao = Console.ReadLine();

// TODO: Crie uma estrutura condicional 'if/else' para verificar se a descrição da tarefa excede 50 caracteres.
if (!(Descricao.Length > 50))
{
    // Caso a descricao esteja dentro do limite é solicitado a entrada pelo console:
    Console.WriteLine("Informe uma data de vencimento para a sua tarefa :");
    DataDeVencimento = Console.ReadLine();
    // TODO: Imprima a descricao e a data de vencimento como nos exemplos da tabela:
    Console.WriteLine($"{Descricao} ate {DataDeVencimento}");
}
else
{
    Console.WriteLine("Descricao ultrapassa limite de caracteres.");
}
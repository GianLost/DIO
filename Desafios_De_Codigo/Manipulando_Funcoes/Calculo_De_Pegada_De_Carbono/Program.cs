// DESCRIÇÃO :
// Vamos desenvolver uma ferramenta para calcular a pegada de carbono de uma pessoa, dessa forma, crie variáveis como nome, quilometrosPorDia, horasDeEletronicos, refeicoesComCarne para armazenar as respectivas entradas do usuário. Para o cálculo da pegada, crie uma função CalcularPegadaDeCarbono que opera através da utilização de fatores de emissão específicos para cada atividade que contribui para a pegada de carbono, sendo eles:

// quilometrosPorDia: fator de 0.2, é a média estimada das emissões de carbono associadas a veículos motorizados ao longo de um ano.

// horasDeEletronicos, fator de 0.1, é a pegada de carbono relacionada ao consumo elétrico desses dispositivos.

// refeicoesComCarne, fator de 0.5, é utilizado para representar as emissões associadas à produção de carne.

// A pegada de carbono do usuário é calculada a partir de três fatores: transporte (quilômetros diários × 365 × 0.2), eletrônicos (horas diárias × 0.1) e consumo de carne (refeições com carne por dia × 0.5). A soma desses valores fornece a pegada de carbono total, abrangendo diversas fontes de emissões.

// ENTRADA :
// Como entrada será recebido o nome(string), quilometrosPorDia(double), horasDeEletronicos(int) e refeicoesComCarne(int).

// SAÍDA :
// Exiba a pegada de carbono calculada com base nas informações fornecidas pelo usuário.


// Solicita o nome do usuário, quilômetros percorridos por dia, 
// Horas de uso de eletrônicos por dia e o número de refeições com carne:
Console.WriteLine("Digite o seu Nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Quantos Km por dia: ");
double quilometrosPorDia = double.Parse(Console.ReadLine());

Console.WriteLine("Horas de Eletônicos: ");
int horasDeEletronicos = int.Parse(Console.ReadLine());

Console.WriteLine("Quantas refeições com carne: ");
int refeicoesComCarne = int.Parse(Console.ReadLine());

// Chama o método para calcular a pegada de carbono
double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);

// TODO: Exiba o resultado para o usuário:
Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

// Aguarda a entrada do usuário antes de encerrar o programa:
Console.ReadLine();

// TODO: Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:

static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
{
    double pegadaDeCarbonoTransporte = quilometrosPorDia * 365 * 0.2;
    double pegadaDeCarbonoEletronicos = horasDeEletronicos * 0.1;
    double pegadaDeCarbonoCarne = refeicoesComCarne * 0.5;
    
    double pegadaDeCarbonoTotal = pegadaDeCarbonoTransporte + pegadaDeCarbonoEletronicos + pegadaDeCarbonoCarne;

    return pegadaDeCarbonoTotal;
}
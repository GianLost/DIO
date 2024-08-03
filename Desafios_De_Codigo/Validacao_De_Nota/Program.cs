// using Validacao_De_Nota.Models;

// Avaliacao avaliacao = new();
// avaliacao.IniciarAvaliacao();

double[] notas = Array.Empty<double>();

do
{
    for(int i = 0; i <= 2; i++)
    {
        Console.WriteLine("Informe uma nota:");
        double nota  = Convert.ToDouble(Console.ReadLine());
        if (nota >= 0 && nota <= 10)
        {
            notas.SetValue(nota, i);
        }
        else
        {
            Console.WriteLine("Nota inválida !");
        }
    }

}while(true);
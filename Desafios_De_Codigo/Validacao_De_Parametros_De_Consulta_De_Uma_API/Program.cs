using System;
using System.Text.RegularExpressions;

public class ValidaParametrosAPI
{
    public static void Main(string[] args)
    {
        // Solicita a entrada da URL
        Console.WriteLine("Digite a URL com parametros de consulta (exemplo: ?param1=valor1&param2=valor2):");
        string url = Console.ReadLine();

        // Chama o método para validar a URL
        string resultado = ValidarParametros(url);

        // Exibe o resultado
        Console.WriteLine(resultado);
    }

    // Método para validar os parametros da URL
    public static string ValidarParametros(string url)
    {
        // Verifica se a URL começa com '?'
        if (string.IsNullOrEmpty(url) || !url.StartsWith("?"))
            return "Parametros invalidos";

        // Remove o '?' da URL para analisar os parametros
        url = url.Substring(1);

        // Se a string após o '?' estiver vazia, também é inválida
        if (string.IsNullOrWhiteSpace(url))
            return "Parametros invalidos";

        // Divide a URL pelos '&' para obter cada parametro
        string[] parametros = url.Split('&');

        // TODO: Verifique cada parametro individualmente:
        foreach (var parametro in parametros)
        {
            // TODO: Verifique se há exatamente um '='
            string[] chaveValor = parametro.Split('=');

            if (chaveValor.Length != 2)
                return "Parametros invalidos";

            string chave = chaveValor[0];
            string valor = chaveValor[1];

            // TODO: Valide o nome do parametro (alfanumerico)
            if (!Regex.IsMatch(chave, @"^[a-zA-Z0-9]+$"))
                return "Parametros invalidos";

            // Permite caracteres especiais como @ e . para casos como email
            if (!System.Text.RegularExpressions.Regex.IsMatch(chaveValor[1], @"^[a-zA-Z0-9@.]+$") &&
              !System.Text.RegularExpressions.Regex.IsMatch(chaveValor[1], @"^\d+$"))
                return "Parametros invalidos";

            // Valor deve conter apenas letras, números, @ e .
            if (!Regex.IsMatch(valor, @"^[a-zA-Z0-9@.]+$"))
                return "Parametros invalidos";
        }

        // Se passar em todas as validacoes, os parametros são validos
        return "Parametros validos";
    }
}
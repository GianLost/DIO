namespace Criando_Um_Jogador_De_Futebol.Models;
public class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }
    readonly List<Jogador> ListaDeJogadores = new();

    public Jogador(string nome, string nacionalidade, int idade, string posicao)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
        Idade = idade;
        Posicao = posicao;
    }

    public void Novo(Jogador jogador)
    {
        ListaDeJogadores.Add(jogador);
    }

    public void ListarJogador()
    {
        foreach(Jogador jogador in ListaDeJogadores)
        {
            Console.WriteLine("Jogador criado!");
            Console.WriteLine(jogador.Nome);
            Console.WriteLine(jogador.Nacionalidade);
            Console.WriteLine(jogador.Idade);
            Console.WriteLine($"Posição: {jogador.Posicao}");
        }
    }
}
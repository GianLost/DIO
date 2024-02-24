namespace Criando_Seu_Personagem.Models;
public class Personagem
{
    public string Nome { get; set; }
    public string Raca { get; set; }
    public string Classe { get; set; }
    public int Nivel { get; set; }
    public int Vida { get; set; }
    public int Mana { get; set; }

    public Personagem(string nome, string raca, string classe, int mana)
    {
        Nome = nome;
        Raca = raca;
        Classe = classe;
        Nivel  = 1;
        Vida = 10;
        Mana = mana;
    }

    public void ExibirStatus()
    {
        Console.WriteLine("Status:");
        Console.WriteLine("Nome:" + Nome);
        Console.WriteLine("Raça:" + Raca);
        Console.WriteLine("Classe:" + Classe);
        Console.WriteLine("Nível:" + Nivel);
        Console.WriteLine("Vida:" + Vida);
    }
}
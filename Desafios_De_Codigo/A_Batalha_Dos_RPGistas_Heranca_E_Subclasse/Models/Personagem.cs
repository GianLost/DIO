namespace A_Batalha_Dos_RPGistas_Heranca_E_Subclasse.Models;
public abstract class Personagem
{
    public string Nome { get; set; }
    public int Mana { get; set; }

    public Personagem(string nome, int mana)
    {
        Nome = nome;
        Mana = mana;
    }
}

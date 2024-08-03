namespace A_Batalha_Dos_RPGistas_Heranca_E_Subclasse.Models;
public class Subclasse : Personagem
{
    public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
    {
        DanoBase = danoBase;
    }

    public int DanoBase { get; set; }

    public void CalcularDano()
    {
        Console.WriteLine(Nome + " atacou e causou " + DanoBase * Mana + " de dano!");
    }
}

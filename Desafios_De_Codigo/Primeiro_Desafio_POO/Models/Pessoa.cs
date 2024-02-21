namespace Primeiro_Desafio_POO.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome;

        public int Idade;

        public string GetNome()
        {
            Console.WriteLine("Informe o seu nome :");
            Nome = Console.ReadLine();
            return Nome;
        }

        public int GetIdade()
        {
            Console.WriteLine("Informe a sua idade :");
            Idade = Convert.ToInt32(Console.ReadLine());
            return Idade;
        }
    }
}
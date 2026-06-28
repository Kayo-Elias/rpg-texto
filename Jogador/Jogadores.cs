namespace Players;

public class Jogadores : JogadorBase
{
    public List<Jogadores> listaJogador = new List<Jogadores>();

    public Jogadores(string nome) => Nome = nome;

    public Jogadores(string nome,string classe,int level)
    {
        Nome = nome;
        Classe = classe;
        Level = level;
    }

    public void IniciarJogadores()
    {
        listaJogador.Add(new Jogadores("Kayo", "Mago", 10));
        listaJogador.Add(new Jogadores("Elias", "Guerreiro", 10));
        listaJogador.Add(new Jogadores("Oliveira", "Arqueiro", 10));
        listaJogador.Add(new Jogadores("Silva", "Assasino", 10));
    }

    public void ListarJogadores()
    {
        foreach (var j in listaJogador)
        {
            Console.WriteLine($"Nome: {j.Nome} Classe: {j.Classe} Level {j.Level}");
        }
    }

    public bool AdicionarJogador(string nome)
    {
        {
            if (listaJogador.Any(j => j.Nome == nome))
            {
                Console.WriteLine("Esse jogador já existe!");

                return false;
            }
            else
            {
                listaJogador.Add(new Jogadores(nome));

                return true;
            }
        }
    }
}

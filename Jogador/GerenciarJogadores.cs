namespace Players;

public class Jogadores : JogadorBase
{
    public List<Jogadores> listaJogador = new List<Jogadores>();

    public Jogadores() { }

    public Jogadores(string nome) => Nome = nome;

    public Jogadores(int id, string nome, string classe, int level)
    {
        Id = id;
        Nome = nome;
        Classe = classe;
        Level = level;
    }

    public void IniciarJogadores()
    {
        listaJogador.Add(new Jogadores(1, "Kayo", "Mago", 10));
        listaJogador.Add(new Jogadores(2, "Elias", "Guerreiro", 10));
        listaJogador.Add(new Jogadores(3, "Oliveira", "Arqueiro", 10));
        listaJogador.Add(new Jogadores(4, "Silva", "Assasino", 10));
    }

    public void ListarJogadores()
    {
        foreach (var j in listaJogador)
        {
            Console.WriteLine($"Nome: {j.Nome} | Classe: {j.Classe} | Level {j.Level}");
        }
    }

    public void SelecionarJogador()
    {
        Console.WriteLine("Deseja selecionar um jogador?");
        Console.ReadLine();
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

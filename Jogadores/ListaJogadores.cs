namespace Jogadores;

public class ListaJogador : Jogador
{
    public List<Jogador> jogadores { get; set; } = new List<Jogador>();

    public void MenuLista()
    {
        if (jogadores.Count == 0)
        {
            ListarJogadores();
        }

        Console.WriteLine("Escolha seu personagem ativo:");
        
        foreach (Jogador perso in jogadores)
        {
           Console.WriteLine(perso);
        }
    }

    public void ListarJogadores()
    {
        jogadores.Add(new Jogador(1, "Kayo", 30, "Mago"));
        jogadores.Add(new Jogador(2, "Lukiwuo", 30, "Mago"));
        jogadores.Add(new Jogador(3, "Kaizen", 30, "Mago"));
    }

    public void VerificarNomeDuplicado(string nome)
    {
        foreach (Jogador verificarNome in jogadores)
        {
            if (verificarNome.NomeJogador == nome)
            {
                Console.WriteLine("Já existe um jogador com esse nome");
            }
            else
            {
                Console.WriteLine("Nome disponivel :");
            }
        }
    }
}
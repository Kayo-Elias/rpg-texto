using System.Data.Common;
using System.Collections.Generic;

namespace Jogadores;

public class Jogador
{
    private int IdJogador { get; set; }
    public string NomeJogador { get; set; }
    public int NivelJogador { get; set; }
    public string ClasseJogador { get; set; }

    public Jogador() { }

    public Jogador(int id, string nome, int nivel, string classe)
    {
        IdJogador = id;
        NomeJogador = nome;
        NivelJogador = nivel;
        ClasseJogador = classe;
    }

    public override string ToString()
    {
        return $"Id: {IdJogador} Nome: {NomeJogador}, Nível: {NivelJogador}, Classe: {ClasseJogador}";
    }
}

public class Nick : Jogador
{
    public List<Jogador> jogador { get; set; }

    public Nick(int id, string nome, int nivel, string classe) : base(id, nome, nivel, classe)
    {
        jogador = new List<Jogador>();

        jogador.Add(new Jogador(1, "Kayo", 30, "Mago"));
    }
}

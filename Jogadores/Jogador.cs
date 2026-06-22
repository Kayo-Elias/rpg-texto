namespace Jogadores;

public class Jogador
{
    public int IdJogador { get; set; }
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

    public override string ToString() => $"Id: {IdJogador} Nome: {NomeJogador}, Nível: {NivelJogador}, Classe: {ClasseJogador}";
}
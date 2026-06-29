namespace Players;

public abstract class JogadorBase
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Classe { get; set; }
    public int Level { get; set; }
}
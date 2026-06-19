public class Aranha
{
    private int Id { get; set; }
    public string NomeMonstro { get; set; }
    public string RacaMonstro { get; set; }
    public double VidaMonstro { get; set; }
    public double AtaqueMonstro { get; set; }
    public double DefesaMonstro { get; set; }

    private Aranha(string nome, double vida, double ataque, double defesa, string raca)
    {
        RacaMonstro = raca;
        NomeMonstro = nome;
        VidaMonstro = vida;
        AtaqueMonstro = ataque;
        DefesaMonstro = defesa;
    }

    private Aranha()
    {
        Id = 1;
        NomeMonstro = "Aranha";
        RacaMonstro = "Aracnideo";
        VidaMonstro = 30;
        AtaqueMonstro = 10;
        DefesaMonstro = 15;
    }
}
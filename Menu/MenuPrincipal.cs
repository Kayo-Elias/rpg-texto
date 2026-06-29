using Classes;
using Players;

namespace Menu;

public class MenuPrincipal
{
    public void SelecionarOuCriarJogador()
    {
        Console.WriteLine("===================");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("===================");

        Console.WriteLine("1 - Escolher um jogador existente");
        Console.WriteLine("2 - Criar novo jogador");
        var escolha = short.Parse(Console.ReadLine());
    }

    public Personagem EscolherClasse(short escolhaClasse)
    {
        switch (escolhaClasse)
        {
            case 1:
                return new Mago();

            case 2:
                return new Guerreiro();

            case 3:
                return new Arqueiro();

            case 4:
                return new Assasino();

            default:
                throw new ArgumentException("Classe invalida");
        }
    }
}
using Classes;
using Jogadores;

namespace MenuClass;

public class Menu : Jogador
{
    public short EscolhaClasses { get; set; }
  
    public void ExibirMenu()
    {
        Console.Clear();

        Console.WriteLine("MINI RPG");
        Console.WriteLine("============================");
        Console.WriteLine($"Escolha sua classe, {NomeJogador}");
        Console.WriteLine("============================");

        Console.WriteLine("CLASSES");
        Console.WriteLine("1- Mago");
        Console.WriteLine("2- Guerreiro");
        Console.WriteLine("3- Arqueiro");
        Console.WriteLine();

        EscolhaClasses = short.Parse(Console.ReadLine());

        switch (EscolhaClasses)
        {
            case 1: new Mago().mago(); break;
            case 2: new Guerreiro().guerreiro(); break;
            case 3: new Arqueiro().arqueiro(); break;
            default: Console.WriteLine("Opção inválida."); break;
        }
    }
}
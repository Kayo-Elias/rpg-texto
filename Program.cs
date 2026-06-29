using Classes;
using Menu;
using Players;


Jogadores jogadores = new Jogadores();
MenuPrincipal menu = new MenuPrincipal();

menu.SelecionarOuCriarJogador();
jogadores.IniciarJogadores();
jogadores.ListarJogadores();
jogadores.SelecionarJogador();
jogadores.AdicionarJogador();

Console.WriteLine("CHRONOS RPG");

Console.WriteLine($"Escolha sua classe");

Console.WriteLine("1 - Mago");
Console.WriteLine("2 - Guerreiro");
Console.WriteLine("3 - Arqueiro");
Console.WriteLine("4 - Assasino");
short escolha = short.Parse(Console.ReadLine());

Personagem personagem = menu.EscolherClasse(escolha);
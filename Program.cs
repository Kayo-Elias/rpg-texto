using Classes;
using Menu;
using Players;


Jogadores jogadores = new Jogadores();
MenuPrincipal menu = new MenuPrincipal();

Console.WriteLine("Jogadores ativos:");
jogadores.IniciarJogadores();
jogadores.ListarJogadores();
jogadores.SelecionarJogador();


Console.WriteLine("Digite seu nick:");
string nome = Console.ReadLine();

jogadores.AdicionarJogador(nome);

Console.WriteLine("Chronos rpg");

Console.WriteLine($"Escolha sua classe, {jogadores.Nome}");

Console.WriteLine("1 - Mago");
Console.WriteLine("2 - Guerreiro");
Console.WriteLine("3 - Arqueiro");
Console.WriteLine("4 - Assasino");
short escolha = short.Parse(Console.ReadLine());

Personagem personagem = menu.EscolherClasse(escolha);
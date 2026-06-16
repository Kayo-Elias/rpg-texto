Menu menu = new();
menu.Exibir();

public class Menu
{
    Monstros monstros = new();
    ClassesPersonagem classes = new();

        public void Exibir()
        {
            Console.WriteLine("Digite o seu nick :");
            classes.NomePersonagem = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("MINI RPG");
            Console.WriteLine("============================");
            Console.WriteLine($"Escolha sua classe, {classes.NomePersonagem}");
            Console.WriteLine("============================");

            Console.WriteLine("CLASSES");
            Console.WriteLine("1- Mago");
            Console.WriteLine("2- Guerreiro");
            Console.WriteLine("3- Arqueiro");
            Console.WriteLine();
            classes.EscolhaClasses = short.Parse(Console.ReadLine());

            switch (classes.EscolhaClasses)
            {
                case 1: classes.mago(); break;
                case 2: classes.guerreiro(); break;
                case 3: classes.arqueiro(); break;
            }
        }
    }

public class ClassesPersonagem
{
    public string NomePersonagem { get; set; } = string.Empty;
    public int AtaquePersonagem { get; set; }
    public int VidaPersonagem { get; set; }
    public int DefesaPersonagem { get; set; }
    public int ManaPersonagem { get; set; }
    public short EscolhaClasses { get; set; }
    public string EscolhaConfirmacao { get; set; } = string.Empty;

    public void mago()
    {
        Console.WriteLine("Você escolheu o mago!");
        Console.WriteLine("============================");
        Console.WriteLine("Atributos do mago:");
        Console.WriteLine("Ataque: 12");
        Console.WriteLine("Vida: 80");
        Console.WriteLine("Defesa: 30");
        Console.WriteLine("Mana: 100");
        Console.WriteLine("============================");
        Console.WriteLine("Tem certeza da sua classe?");
        Console.WriteLine("Digite: sim ou nao");
        EscolhaConfirmacao = Console.ReadLine().ToLower();

        if (EscolhaConfirmacao == "sim")
        {
            Console.WriteLine("Você confirmou sua escolha!");
        }

        if (EscolhaConfirmacao == "nao")
        {
            Console.WriteLine("Você cancelou a escolha.");
        }
        Console.WriteLine("Resposta inválida.");
    }

    public void guerreiro()
    {
        Console.WriteLine("Você escolheu o guerreiro!");
    }

    public void arqueiro()
    {
        Console.WriteLine("Você escolheu o arqueiro!");
    }
}

public class Monstros
{
    public string NomeMonstro { get; set; } 
    public double VidaMonstro { get; set; }
    public double AtaqueMonstro { get; set; }
    public double DefesaMonstro { get; set; }

    public Monstros() { }

    public Monstros(string nome, double vida, double ataque, double defesa)
    {
        NomeMonstro = nome;
        VidaMonstro = vida;
        AtaqueMonstro = ataque;
        DefesaMonstro = defesa;
    }

    public class Aranha : Monstros
    {
        public Aranha()
        {
            NomeMonstro = "Aranha";
            VidaMonstro = 30;
            AtaqueMonstro = 10;
            DefesaMonstro = 15;
        }
    }
}


using Classes;

namespace Menu;

public class MenuPrincipal
{
    public Personagem EscolherClasse (short escolha)
    {
        switch(escolha)
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
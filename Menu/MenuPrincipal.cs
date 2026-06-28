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

            default:
                throw new ArgumentException("Classe invalida");
        }
    }
}
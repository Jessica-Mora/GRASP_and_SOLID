using System.Linq;
using Full_GRASP_And_SOLID.Library;

public interface IPrinter
{
    void PrintTicket(Recipe recipe);
}

/*se define una interface con un metodo PrintTicket, el cual imprimira segun la clase que se le asigne*/
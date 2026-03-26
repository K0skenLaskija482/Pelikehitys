
namespace PK_tehtävä5
{
    public class Käynnistä: IRobottiKäsky
    {
        public void Suorita(Robotti robotti)
        {
            robotti.OnKäynnissä = true;
        }
    }
}

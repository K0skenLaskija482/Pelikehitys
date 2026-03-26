
namespace PK_tehtävä5
{
    public class Sammuta: IRobottiKäsky
    {
        public void Suorita(Robotti robotti)
        {
            robotti.OnKäynnissä = false;
        }
    }
}

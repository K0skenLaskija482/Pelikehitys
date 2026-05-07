
namespace Pk_tehtävä4
{
    public class Tavara
    {

        public Tavara()
        {
        }

        public override string ToString()
        {
            return "Tavara";
        }
    }

    public class Jousi : Tavara
    {
        public Jousi() : base()
        {

        }

        public override string ToString()
        {
            return "Jousi";
        }
    }
    public class Kirves : Tavara
    {
        public Kirves() : base()
        {

        }
        public override string ToString()
        {
            return "Kirves";
        }
    }
    public class Miekka : Tavara
    {
        public Miekka() : base()
        {

        }

        public override string ToString()
        {
            return "Miekka";
        }
    }
}

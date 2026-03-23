
namespace Pk_tehtävä4
{
    public class Tavara
    {
        public float Tilavuus { get; set; }
        public float Paino { get; set; }

        public Tavara(float tilavuus, float paino)
        {
            Tilavuus = tilavuus;
            Paino = paino;
        }

        public override string ToString()
        {
            return "Tavara";
        }
    }

    public class Nuoli : Tavara
    {
        public Nuoli() : base(0.05f, 0.1f)
        {

        }

        public override string ToString()
        {
            return "Nuoli";
        }
    }

    public class Jousi : Tavara
    {
        public Jousi() : base(1f, 4f)
        {

        }

        public override string ToString()
        {
            return "Jousi";
        }
    }

    public class Koysi : Tavara
    {
        public Koysi() : base(1f, 1.5f)
        {

        }

        public override string ToString()
        {
            return "Köysi";
        }
    }

    public class Vesi : Tavara
    {
        public Vesi() : base(2f, 2f)
        {

        }

        public override string ToString()
        {
            return "Vesi";
        }
    }

    public class Ruoka : Tavara
    {
        public Ruoka() : base(1f, 0.5f)
        {

        }

        public override string ToString()
        {
            return "Ruoka";
        }
    }
    public class Miekka : Tavara
    {
        public Miekka() : base(5f, 3f)
        {

        }

        public override string ToString()
        {
            return "Miekka";
        }
    }
}

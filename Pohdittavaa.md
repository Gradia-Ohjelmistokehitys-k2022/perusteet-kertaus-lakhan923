```c#
namespace Elaintarha
{
    public abstract class Elain
    {
        private string laji;

        protected Elain()
        {
        }

        public string Laji { get => laji; protected set => laji = value; }

        abstract public void Aantele();
    }

    public class Kissa : Elain
    {
        public Kissa()
        {
            Laji = "Kissa";
        }
        override public void Aantele()
        {
            Console.WriteLine("Kurrnau, mo-moouuu!");
        }
    }

    public class Koira : Elain
    {
        public Koira()
        {
            Laji = "Koira";
        }
        override public void Aantele()
        {
            Console.WriteLine("Hau hau!");
        }
    }
    
    public class Hevonen : Elain
    {
        public Hevonen()
        {
            Laji = "Hevonen";
        }
        override public void Aantele()
        {
            Console.WriteLine("Iihahahaha, prrh!");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Elain[] elaimet = new Elain[3];
            elaimet[0] = new Kissa();
            elaimet[1] = new Koira();
            elaimet[2] = new Hevonen();

            foreach(Elain e in elaimet)
                e.Aantele();
        }
    }
}```

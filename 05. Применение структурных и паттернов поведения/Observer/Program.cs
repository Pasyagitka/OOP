namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Flat f = new Flat("Квартира1");
            Observer o = new Observer("Observer", f);
            Observer o1 = new Observer("Observer1", f);
            f.Sell();
        }
    }
}
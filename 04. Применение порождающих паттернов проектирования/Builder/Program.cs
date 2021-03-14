using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        { 
            Master master = new Master();
            
            FlatBuilder builder = new ExpensiveFlatBuilder();

            Flat expensiveFlat = master.Build(builder);
            Console.WriteLine(expensiveFlat.ToString());
            
            builder = new CheapFLatBuilder();
            Flat cheapFlat = master.Build(builder);
            Console.WriteLine(cheapFlat.ToString());
        }
    }
}
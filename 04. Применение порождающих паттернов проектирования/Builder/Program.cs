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
            
            Flat cheapFlat = master.Build(new CheapFLatBuilder());
            Console.WriteLine(cheapFlat.ToString());
        }
    }
}
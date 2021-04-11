using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {  
            Flat flat = new Flat();
            flat.Price = 11;
            PriceHistory priceHistory = new PriceHistory();
            priceHistory.History.Push(flat.SaveState());
            flat.Price = 17;
            priceHistory.History.Push(flat.SaveState());
            flat.Price = 19;
            Console.WriteLine(flat.Price + " - Текущая цена квартиры");
            flat.RestoreState(priceHistory.History.Pop());
            flat.RestoreState(priceHistory.History.Pop());
        }
    }
}
using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {  
            Flat flat = new Flat();
            flat.Price = 11;
            PriceHistory price = new PriceHistory();
            price.History.Push(flat.SaveState());
            flat.Price = 17;
            price.History.Push(flat.SaveState());
            flat.Price = 19;
            Console.WriteLine(flat.Price + " - Текущая цена квартиры");
            flat.RestoreState(price.History.Pop());
            flat.RestoreState(price.History.Pop());
        }
    }
}
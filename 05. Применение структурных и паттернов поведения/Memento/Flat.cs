using System;
using System.Collections.Generic;

namespace Memento
{
    public class Flat
    {
        private int price;

        public int Price { get => price; set => price = value; }
        
        public FlatMemento SaveState()
        {
            Console.WriteLine("Сохранение. Цена: " + Price);
            return new FlatMemento(Price);
        }
        
        public void RestoreState(FlatMemento memento)
        {
            this.Price=memento.Price;
            Console.WriteLine("Восстановление. Цена: " + Price);
        }
    }

    public class FlatMemento
    {
        public int Price { get; private set; }
        public FlatMemento(int price)
        {
            this.Price = price;
        }
    } 

    class PriceHistory
    {
        public Stack<FlatMemento> History { get; private set; }
        public PriceHistory()
        {
            History = new Stack<FlatMemento>();
        }
    }
}
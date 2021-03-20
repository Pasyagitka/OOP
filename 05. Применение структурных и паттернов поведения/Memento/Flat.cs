using System;
using System.Collections.Generic;

namespace Memento
{
    public class Flat
    {
        private string name;
        private int price;
        

        public int Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }
        
        // сохранение состояния
        public FlatMemento SaveState()
        {
            Console.WriteLine("Сохранение квартиры. Цена: " + Price);
            return new FlatMemento(Price);
        }
 
        // восстановление состояния
        public void RestoreState(FlatMemento memento)
        {
            this.Price=memento.Price;
            Console.WriteLine("Восстановление квартиры. Цена: " + Price);
        }
    }

    public class FlatMemento    // Memento
    {
        public int Price { get; private set; }
 
        public FlatMemento(int price)
        {
            this.Price = price;
        }
    } 

    class PriceHistory// Caretaker
    {
        public Stack<FlatMemento> History { get; private set; }
        public PriceHistory()
        {
            History = new Stack<FlatMemento>();
        }
    }
}
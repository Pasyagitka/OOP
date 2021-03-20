using System;

namespace Observer
{
    public class Observer
    {
        public string Title { get; set; }
           
        public Observer(string title, Flat retailer) 
        {
            if(string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title));
            }
            if(retailer == null)
            {
                throw new ArgumentNullException(nameof(retailer));
            }
            Title = title;
            retailer.OnSell += SellFlat;
        }
      
        private void SellFlat(object sender, EventArgs e)  // Обработчик события сохранения наблюдаемого объекта.
        {
            string format = "dd.MM.yyyy hh:mm:ss";
            Console.WriteLine($"[{DateTime.Now.ToString(format)}] Наблюдатель '{this}': Квартира '{sender}' продана");
        }
      
        public override string ToString()
        {
            return Title;
        }
    }

    public class Flat
    {
        public string Name { get; set; }
        public event EventHandler OnSell;    //Событие, генерируемое при сохранении сущности.
        
        public Flat(string name)  
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            Name = name;
        }
    
        public void Sell()  
        {
            Console.WriteLine("Sold");
            OnSell?.Invoke(this, EventArgs.Empty);
        }
      
        public override string ToString() 
        {
            return Name;
        }
    }
}
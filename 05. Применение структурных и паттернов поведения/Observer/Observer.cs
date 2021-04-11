using System;

namespace Observer
{
    public class Observer
    {
        public string Title { get; set; }
           
        public Observer(string title, Flat flat) 
        {
            if(string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title));
            }
            if(flat == null)
            {
                throw new ArgumentNullException(nameof(flat));
            }
            Title = title;
            flat.OnSell += SellFlat;
        }
      
        private void SellFlat(object sender, EventArgs e) 
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
        public event EventHandler OnSell;  
        
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
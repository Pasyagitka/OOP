using System;

namespace Observer
{
    public class Observer
    {
        public string Title { get; set; }
        
        // Создать экземпляр наблюдателя.
        public Observer(string title, Retailer retailer)
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
            retailer.OnSell += SaveSubject;
        }
        // Обработчик события сохранения наблюдаемого объекта.
        private void SaveSubject(object sender, EventArgs e)
        {
            string format = "dd.MM.yyyy hh:mm:ss";
            Console.WriteLine($"[{DateTime.Now.ToString(format)}] Наблюдатель '{this}': Выполнено сохранение наблюдаемого объекта '{sender}'");
        }
        // Приведение объекта к строке.
        public override string ToString()
        {
            return Title;
        }
    }

    public class Retailer
    {
        /// Название наблюдаемого.
        public string Name { get; set; }
        
        /// Событие, генерируемое при сохранении сущности.
        public event EventHandler OnSell;
        
        /// Создать экземпляр наблюдаемого класса.
        public Retailer(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            Name = name;
        }
        /// Сохранить наблюдаемый класс.
        public void Sell()
        {
            Console.WriteLine("Sold");
            // Такая форма записи используется для того, чтобы избежать исключения NullReferenceException, если нет ни одного подписчика у события.
            OnSell?.Invoke(this, EventArgs.Empty);
        }
        /// Приведение объекта к строке.
        public override string ToString()
        {
            return Name;
        }
    }
}
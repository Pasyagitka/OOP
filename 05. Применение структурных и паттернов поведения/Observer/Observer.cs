using System;

namespace Observer
{
    public class Observer
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Создать экземпляр наблюдателя.
        /// </summary>
        /// <param name="title">Название наблюдателя.</param>
        /// <param name="subject">Наблюдаемый объект.</param>
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

        /// <summary>
        /// Обработчик события сохранения наблюдаемого объекта.
        /// </summary>
        /// <param name="sender">Наблюдаемый объект.</param>
        /// <param name="e">Аргументы события.</param>
        private void SaveSubject(object sender, EventArgs e)
        {
            string format = "dd.MM.yyyy hh:mm:ss";
            Console.WriteLine($"[{DateTime.Now.ToString(format)}] Наблюдатель '{this}': Выполнено сохранение наблюдаемого объекта '{sender}'");
        }

        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Title;
        }
    }
    
    
    public class Retailer
    {
        /// <summary>
        /// Название наблюдаемого.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Событие, генерируемое при сохранении сущности.
        /// </summary>
        public event EventHandler OnSell;

        /// <summary>
        /// Создать экземпляр наблюдаемого класса.
        /// </summary>
        /// <param name="name">Имя наблюдаемого.</param>
        public Retailer(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary>
        /// Сохранить наблюдаемый класс.
        /// </summary>
        public void Sell()
        {
            Console.WriteLine("Sold");
            // Такая форма записи используется для того, чтобы избежать исключения NullReferenceException,
            // если нет ни одного подписчика у события.
            OnSell?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
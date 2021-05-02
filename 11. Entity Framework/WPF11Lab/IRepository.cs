using System.Collections.Generic;

namespace WPF11Lab
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);

        IEnumerable<T> OrderById();
        IEnumerable<T> OrderByString();
        IEnumerable<T> SearchBy(string criteria);
    }
}
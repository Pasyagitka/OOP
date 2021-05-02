using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WPF11Lab
{
    public class ClientRepository : IRepository<Client>
    {
        private readonly ClientContext _db;
        public ClientRepository(ClientContext context)
        {
            this._db = context;
        }
        public IEnumerable<Client> GetAll()
        {
            return _db.Clients;
        }
        public Client Get(int id)
        {
            return _db.Clients.Find(id);
        }
        public void Create(Client client)
        {
            _db.Clients.Add(client);
        }
        public void Update(Client client)
        {
            _db.Entry(client).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            var client = _db.Clients.Find(id);
            if (client != null)
            {
                _db.Clients.Remove(client);
            }
        }
        public IEnumerable<Client> OrderById()
        {
            return GetAll().OrderBy(x => x.Id);
        }
        public IEnumerable<Client> OrderByString()
        {
            return GetAll().OrderBy(x => x.Surname);
        }
        public IEnumerable<Client> SearchBy(string criteria)
        {
            return GetAll().Where(x => x.Surname.Contains(criteria) || x.ContactNumber.ToString().Contains(criteria));
        }
    }
}
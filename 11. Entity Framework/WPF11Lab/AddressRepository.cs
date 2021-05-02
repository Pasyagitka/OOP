using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WPF11Lab
{
    //todo linq
    public class AddressRepository : IRepository<Address>
    {
        private readonly ClientContext _db;

        public AddressRepository(ClientContext context)
        {
            this._db = context;
        }
        public IEnumerable<Address> GetAll()
        {
            return _db.Addresses;
        }
        public Address Get(int id)
        {
            return _db.Addresses.Find(id);
        }
        public void Create(Address address)
        {
            _db.Addresses.Add(address);
        }
        public void Update(Address address)
        {
            _db.Entry(address).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Address address = _db.Addresses.Find(id);
            if (address != null)
            {
                _db.Addresses.Remove(address);
            }
        }
        public IEnumerable<Address> OrderById()
        {
            return GetAll().OrderByDescending(x => x.Id);
        }
        public IEnumerable<Address> OrderByString()
        {
            return GetAll().OrderBy(x => x.Street);
        }

        public IEnumerable<Address> SearchBy(string criteria)
        {
            return GetAll().Where(x => x.City.Contains(criteria) || x.Street.ToString().Contains(criteria));
        }
    }
}
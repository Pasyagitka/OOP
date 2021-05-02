using System;

namespace WPF11Lab
{
    public class UnitOfWork : IDisposable
    {
        private readonly ClientContext _db = new ClientContext();
        private ClientRepository clientRepository;
        private AddressRepository addressRepository;
        private bool disposed;
        public ClientRepository Clients => clientRepository ?? (clientRepository = new ClientRepository(_db));
        public AddressRepository Address => addressRepository ?? (addressRepository = new AddressRepository(_db));

        public void Save() { _db.SaveChanges(); }
        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed) return;
            if (disposing)
            {
                _db.Dispose();
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
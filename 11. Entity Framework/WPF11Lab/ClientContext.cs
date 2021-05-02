using System.Collections.Generic;
using System.Data.Entity;

namespace WPF11Lab
{
    public class ClientContext : DbContext
    {
        public ClientContext() : base("OOP11") { }
        public DbSet<Client> Clients { get; set; } 
        public DbSet<Address> Addresses { get; set; }
    }
}
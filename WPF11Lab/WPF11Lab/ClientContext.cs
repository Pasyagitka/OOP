using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF11Lab
{
    class ClientContext : DBContext
    {
        public ClientContext() : base("connectASUS") { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientsAddress> Addresses { get; set; }
    }
}

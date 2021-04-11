using System;
using System.Security.Permissions;

namespace Shop.Roles
{
    [Serializable]
    public class Client : Role
    {
        public Client(string login, string password) : base(login, password) { }
    }
}
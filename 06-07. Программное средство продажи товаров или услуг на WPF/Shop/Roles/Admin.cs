using System;

namespace Shop.Roles
{
    [Serializable]
    public class Admin : Role
    {
        protected Admin(string login, string password) : base(login, password)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Roles
{
    [DataContract]
    [KnownType(typeof(Admin))]
    [KnownType(typeof(Client))]
    public class Role
    {
        [DataMember(Name = "login")]
        protected string login;
        [DataMember(Name = "password")]
        protected string password;

        protected Role(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        //protected bool IsActive { get; set; } //TODO

        public bool VerifyRole(string login, string password)
        {
            return this.login.Equals(login) && this.password.Equals(password);
        }
    }
}

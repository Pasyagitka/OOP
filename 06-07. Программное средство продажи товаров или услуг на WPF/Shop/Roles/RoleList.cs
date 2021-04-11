using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using Shop.Product;
using System.Runtime.Serialization.Json;

namespace Shop.Roles
{
    public class RoleList
    {
        //TODO url
        private readonly string filepath = "..\\..\\Files\\roles.json";
        private readonly DataContractJsonSerializer jsonFormatter;
        private static RoleList instance;
        private List<Role> roles;
        
        private RoleList() 
        {
            roles = new List<Role>();
            jsonFormatter = new DataContractJsonSerializer(typeof(List<Role>));
        }

        public static RoleList GetInstance()
        {
            if (instance != null)
            {
                return instance;
            }
            else
            {
                instance = new RoleList();
                instance.Deserialize();
                return instance;
            }
        }

        public void Add(Role user)
        {
            this.roles.Add(user);
        }

        public void Serialize()
        {
            using var file = new FileStream(filepath, FileMode.OpenOrCreate);
            jsonFormatter.WriteObject(file, roles);
        }

        private void Deserialize()
        {
            var fileInfo = new FileInfo(filepath);
            if (!fileInfo.Exists) {return;}
            if (fileInfo.Length == 0) {return;}

            using var file = new FileStream(filepath, FileMode.OpenOrCreate);
            if (jsonFormatter.ReadObject(file) is not List<Role> deserializedRoles) {return;}
            foreach (var role in deserializedRoles)
            {
                roles.Add(role);
            }
        }

        public bool VerifyUsers(string login, string password)
        {
            return roles.Any(r => r.VerifyRole(login, password));
        }
    }
}
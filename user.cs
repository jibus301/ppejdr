using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe
{

    public class User
    {
        public int Id;
        public string Username;
        public string Firstname;
        public string Lastname;
        public bool Admin;
        public DateTime CreatedAt;
        public DateTime UpdatedAt;


        public User(int id, string username, string firstname, string lastname, bool admin, DateTime ca, DateTime ua)
        {
            Id = id;
            Username = username;
            Firstname = firstname;
            Lastname = lastname;
            Admin = admin;
            CreatedAt = ca;
            UpdatedAt = ua;

        }
    }
}

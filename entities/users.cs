using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe
{

    public class Users
    {
        public int Id;
        public string Username;
        public string Firstname;
        public string Lastname;
        public bool Admin;


        public Users(int id, string username, string firstname, string lastname, bool admin)
        {
            Id = id;
            Username = username;
            Firstname = firstname;
            Lastname = lastname;
            Admin = admin;
        }
    }
}

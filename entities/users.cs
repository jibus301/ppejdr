using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe
{

    public class Users
    {
        private int id;
        private string username;
        private string firstname;
        private string lastname;
        private bool admin;

        public static List<Users> allUsers = new List<Users>();

        public static Users userSelected;

        public Users() { }

        public Users(int Id, string Username, string Firstname, string Lastname, bool Admin)
        {
             id = Id;
             username = Username ;
             firstname = Firstname ;
             lastname = Lastname ;
             admin = Admin ;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public bool Admin
        {
            get
            {
                return admin;
            }
            set
            {
                admin = value;
            }
        }

        //public List<string> headers = new List<string> { "id", "username", "Firstname", "Lastname", "Admin" };

        public static async void getAllUsers()
        {
            object[] response = await api.getAsync("/users");

            foreach (object obj in response)
            {
                Users user = JsonConvert.DeserializeObject<Users>(obj.ToString());
                allUsers.Add(user);
            }



            
        }

        public static async void getUser(int id)
        {


            object[] response = await api.getAsync("/users/"+id);
            foreach (object obj in response)
            {
                var res = JsonConvert.DeserializeObject<Users>(obj.ToString());

                allUsers.Add(res);

            }

            


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Text.Json;

namespace formjdrppe
{
    class UserLogin
    {
        public string username;
        public string password;

        public UserLogin(string n, string p)
        {
            username = n;
            password = p;
        }
    }

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

    class api
    {
        public static HttpClient client = new HttpClient();

        public static string ipApi = "http://127.0.0.1:8080/";

        public static Uri uri = new Uri(ipApi);



        public static async Task<bool> LoginAsync(UserLogin user)
        {
            try
            {
                client.BaseAddress = uri;
                HttpResponseMessage response = await client.PostAsJsonAsync("user/login", user);
                response.EnsureSuccessStatusCode();
                //await response.Content.ReadAsAsync<HttpResponseMessage>();

                
                //var res = response.Content;
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    Token token = JsonSerializer.Deserialize<Token>(result);
                    global.token = token.token;
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        public static async Task<HttpResponseMessage> LogoutAsync()
        {
            try
            {
                
                HttpResponseMessage response = await client.PostAsJsonAsync("user/logout", new { });
                response.EnsureSuccessStatusCode();

                return response;
                
            }
            catch (Exception err)
            {


                MessageBox.Show(err.ToString());
                throw;
            }

        }

        public static async Task<User> GetUserAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            HttpResponseMessage response = await client.GetAsync("user/me");
            response.EnsureSuccessStatusCode();
            var resUser = await response.Content.ReadAsStringAsync();
            User test = JsonSerializer.Deserialize<User>(resUser);


            // return URI of the created resource.
            return test;
        }



        static async Task<Uri> CreateAsync(string route, object content)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                route, content);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        

        

    }
}

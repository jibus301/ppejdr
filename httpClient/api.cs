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

    

    class api
    {
        public static HttpClient client = null;

        public static string ipAppiDefaut = "http://127.0.0.1:8080/";
        public static string ipApi = ipAppiDefaut;


        public static void Adressage_API()
        {
            Uri uri = new Uri(ipApi);
            client.BaseAddress = uri;

            
        }

        public static async Task<bool> LoginAsync(UserLogin user)
        {
            try
            {
                if (client!=null)
                {
                    client.CancelPendingRequests();
                    client = new HttpClient();
                }
                else
                {
                    client = new HttpClient();
                }

                
                Adressage_API();
                HttpResponseMessage response = await client.PostAsJsonAsync("auth/login", user);
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
            catch (Exception e)
            {
                
                throw;
            }

        }

        public static async Task<HttpResponseMessage> LogoutAsync()
        {
            try
            {
                if (client == null) return null;

                HttpResponseMessage response = await client.PostAsJsonAsync("auth/logout", new { });
                response.EnsureSuccessStatusCode();

                client.CancelPendingRequests();
                client = null;

                return response;
                
            }
            catch (Exception err)
            {


                MessageBox.Show(err.ToString());
                return null;
                //throw;
                
            }

        }

        public static async Task<Users> GetUserAsync()
        {
            Users user = null;
            HttpResponseMessage response = await client.GetAsync("users/me");
            response.EnsureSuccessStatusCode();

           

            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<Users>();
            }
            return user;


        }



        static async Task<Uri> CreateAsync(string route, object obj)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(route, obj);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        public static async Task<object[]> getAsync(string route)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(route);
                response.EnsureSuccessStatusCode();
                object[] res = await response.Content.ReadAsAsync<object[]>();
                return res;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                throw;
            }
            
        }

        

        

    }
}

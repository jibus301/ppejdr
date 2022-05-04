using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formjdrppe
{
    public partial class ListeJoueur : Form
    {
        public static List<Users> allUsers = new List<Users>();

        private CurrencyManager currencyManager = null;
        public ListeJoueur()
        {
            InitializeComponent();
        }

        private async void ListeJoueur_Load(object sender, EventArgs e)
        {

            object[] response = await api.getAllAsync("/users");

            foreach (object obj in response)
            {
                Users user = JsonConvert.DeserializeObject<Users>(obj.ToString());
                allUsers.Add(user);

            }

            //object response = await api.getOneAsync("/users/1");


            //Users user = JsonConvert.DeserializeObject<Users>(response.ToString());
            //allUsers.Add(user);
            dataGridUser.DataSource = allUsers;
            dataGridUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridUser.AllowUserToOrderColumns = true;
            dataGridUser.AllowUserToResizeColumns = true;
        }

        private void dataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

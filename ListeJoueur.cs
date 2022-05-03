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

            // TODO: cette ligne de code charge les données dans la table 'projet_prosqlDataSet8.JOUEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            // this.jOUEURTableAdapter.Fill(this.projet_prosqlDataSet8.JOUEUR);
            object[] response = await api.getAsync("/users");

            foreach (object obj in response)
            {
                Users user = JsonConvert.DeserializeObject<Users>(obj.ToString());
                allUsers.Add(user);
                
            }
            // Initialize the DataGridView.

            //currencyManager = (CurrencyManager)dataGridUser.BindingContext[allUsers];
            dataGridUser.DataSource = allUsers;
            dataGridUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //dataGridUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridUser.AllowUserToOrderColumns = true;
            dataGridUser.AllowUserToResizeColumns = true;
            
           

            //usersBindingSource.DataSource = allUsers[0].Username;



        }

        private void dataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

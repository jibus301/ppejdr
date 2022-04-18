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
    public partial class connexion : Form
    {
        public connexion()
        {
            InitializeComponent();
        }

        private void connexion_Load(object sender, EventArgs e)
        {

        }


        private async void IsValidUser(string userName, string password)
        {
            // api Login 
            
            

        }

        private async void Login(string username, string password)
        {
            
           
            UserLogin user = new UserLogin(username, password);
            bool isValidUser = await api.LoginAsync(user);

            if (isValidUser == true)
            {

                await api.GetUserAsync();
                //global.ConnectedUser = new User();
                global.ACCES_PROGRAMME = true;
                this.Close();


                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxPseudo.Text;
            string password = textBoxPass.Text;
            Login(username , password);
        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            string username = textBoxPseudo.Text;
            string password = textBoxPass.Text;
            if (e.KeyCode == Keys.Enter) Login(username, password);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            creationJoueur nouveauJoueur = new creationJoueur();
            nouveauJoueur.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login("admin", "P@ssword1");
        }
    }
}

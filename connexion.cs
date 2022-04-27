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
            
           
            UserLogin userlogin = new UserLogin(username, password);
            bool isValidUser = await api.LoginAsync(userlogin);

            if (isValidUser == true)
            {

                global.ConnectedUser = await api.GetUserAsync();

                if (global.ConnectedUser.Admin == true)
                {
                    global.isAdmin = true;
                }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Login("User", "P@ssword1");
        }
    }
}

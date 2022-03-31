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


        private bool IsvalidUser(string userName, string password)
        {
            basejdrDataContext db = new basejdrDataContext();
            var q = from p in db.JOUEUR
                    where p.pseudo == userName
                    && p.pass == password
                    select p;
            if (q.Any())
            {
                foreach (JOUEUR joueur in q)
                {
                    global.isAdmin = joueur.admin;
                    global.idJoueurConnecte = joueur.id_joueur;
                }
                    
                return true;
            }
            else
            {
                return false;
            }
        }

        void validation(string pseudo = null , string pass = null)
        {
            if (pseudo == null && pass == null)
            {
                pseudo = textBoxPseudo.Text;
                pass = textBoxPass.Text;
            }
            

            if (IsvalidUser(pseudo, pass))
            {
                global.connexion(pseudo, pass, true);
                //textBox1.Text = global.apiList();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            validation();
        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) validation();
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
            validation("admin","1");
        }
    }
}

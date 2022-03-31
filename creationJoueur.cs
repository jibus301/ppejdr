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
    public partial class creationJoueur : Form
    {
        public creationJoueur()
        {
            InitializeComponent();
        }

        private void creationJoueur_Load(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {

            basejdrDataContext db = new basejdrDataContext();
            JOUEUR p = new JOUEUR
            {


                nom = textBoxNom.Text,

                prenom = textBoxPrenom.Text,

                pseudo = textBoxPseudo.Text,

                pass = textBoxPass1.Text,


            };

            db.JOUEUR.InsertOnSubmit(p);
            if (textBoxPass1.Text == textBoxPass2.Text)
            {
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                    // Make some adjustments.
                    // ...
                    // Try again.
                    db.SubmitChanges();
                }
                
                this.Close();
            }
            else
            {
                labelErr.Text = "Les mots de passes sont différents";
            }
            

            
        }
    }
}

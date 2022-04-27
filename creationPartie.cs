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
    public partial class creationPartie : Form
    {

        public creationPartie()
        {
            InitializeComponent();
        }

        private void creationPartie_Load(object sender, EventArgs e)
        {
            using (var cnx = new basejdrDataContext())
            {
                var requeteLinq = from table in cnx.JOUEUR select table;
                //listeJoueur.Items.Clear();
                foreach (JOUEUR j in requeteLinq)
                {
                    listeJoueur.Items.Add(j.pseudo);
                }
                listeJoueur.CheckOnClick = true;





            }


        }


        private void remplirEquipe()
        {

            foreach (string n in listeJoueur.CheckedItems)
            {
                if (!equipe_joueur.ContainsKey(n))
                {
                    joueur_non_base choisi = new joueur_non_base();
                    equipe_joueur.Add(n, choisi);

                    

                }
            }

            string cle_a_sup = "";
            int counter = 0;
            foreach (string c in equipe_joueur.Keys)
            {
                bool present = false;

                foreach (string n in listeJoueur.CheckedItems)
                {
                    if (c == n) present = true;
                }
                if (present == false)
                {
                    cle_a_sup = c;
                  
                    break;
                }
                counter += 1;
            }
            if (cle_a_sup != "")
            {
                equipe_joueur.Remove(cle_a_sup);
              //  recherche_Combobox("comboBoxJ" + counter + 1).Items.Clear();

                
            }
            var pseudo_joueur = equipe_joueur.Keys;



            for (int id = 0; id < 6; id++)
            {


                recherche_Combobox_index((id + 1)).Items.Clear();
                //recherche_Combobox("comboBoxJ" + (id + 1)).DataSource = null;
                
            }
            dict_perso.Clear();
            int i = 1;
            foreach (string p in pseudo_joueur)
            {
                J(i).Text = p;
                using (var cnx = new basejdrDataContext())
                {
                    var requeteLinq = from table in cnx.ViewPersoPseudo
                                      where table.pseudo == p
                                      select table;

                    System.Windows.Forms.ComboBox listCb = recherche_Combobox_index( i);
                    if (listCb != null && requeteLinq != null)
                    {
                        foreach (ViewPersoPseudo perso in requeteLinq)
                        {
                            
                            listCb.Items.Add(perso.nom);
                            dict_perso.Add(perso.nom, perso.id_perso);
                        }


                        if (listCb.Items.Count > 0) listCb.SelectedIndex = 0;
                    }

                    

                    i++;
                    
                }
            }
            

        }

        private void persoChoisi()
        {
            listBoxPerso.Items.Clear();
            for (int i = 1; i <= 6; i++)
            {
                if (recherche_Combobox_index(i).SelectedIndex != -1)
                {

                    listBoxPerso.Items.Add(recherche_Combobox_index(i).SelectedItem);
                }
            }
        }
        
        public static Dictionary<string,joueur_non_base> equipe_joueur = new Dictionary<string, joueur_non_base>();
        public static Dictionary<string, int> dict_perso = new Dictionary<string, int>();

        private void listeJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirEquipe();
        }

        private System.Windows.Forms.ComboBox recherche_Combobox_index(int index )
        {

            return recherche_Combobox("comboBoxJ" + index);

        }


        private System.Windows.Forms.ComboBox recherche_Combobox(string nom) 
        {
           
            foreach(Control c in this.Controls)
            {
                if (c.GetType() == typeof(System.Windows.Forms.ComboBox))
                {
                    if (c.Name == nom)
                    {
                        return (ComboBox)c;
                    }
                }
                
            }
            return null;
            
        }

        private System.Windows.Forms.Label pseudoJoueur(string nom)
        {
            
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(System.Windows.Forms.Label))
                {
                    if (c.Name == nom)
                    {
                        return (Label)c;
                    }
                }
            }
            return null;

        }
        private System.Windows.Forms.Label J(int index)
        {

            return pseudoJoueur("J" + index);

        }

        //BOUTON CREATION / VALIDATION
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxValidationPerso.Checked && textBoxNom.Text != "") {
                basejdrDataContext db = new basejdrDataContext();
                PARTIE pers = new PARTIE
                {
                    nom = textBoxNom.Text,
                    date_start = DateTime.Now,
                };

                db.PARTIE.InsertOnSubmit(pers);

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
                int partie_id = pers.id_partie;


                for (int i = 1; i <= 6; i++)
                {
                    if (recherche_Combobox_index(i).SelectedIndex != -1)
                    {
                        int id_p = dict_perso[recherche_Combobox_index(i).Text];

                        PERSO_PARTIE pers_part = new PERSO_PARTIE
                        {
                            id_perso = id_p,
                            id_partie = partie_id,
                        };

                        db.PERSO_PARTIE.InsertOnSubmit(pers_part);

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
                    }

                }






                this.Close();
            }
            else
            {
                MessageBox.Show("Veuiller cocher la validation de l'équipe");
            }

            
        }
















        private void comboBoxJ1_SelectedIndexChanged(object sender, EventArgs e)
        {
            persoChoisi();
        }
        private void comboBoxJ2_SelectedIndexChanged(object sender, EventArgs e)
        {
            persoChoisi();
        }

        private void comboBoxJ3_SelectedIndexChanged(object sender, EventArgs e)
        {
            persoChoisi();
        }

        private void comboBoxJ4_SelectedIndexChanged(object sender, EventArgs e)
        {
            persoChoisi();
        }

        private void comboBoxJ5_SelectedIndexChanged(object sender, EventArgs e)
        {
            persoChoisi();
        }

        private void comboBoxJ6_SelectedIndexChanged(object sender, EventArgs e)
        {
            persoChoisi();
        }
    }
    
}

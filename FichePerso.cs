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
    public partial class FichePerso : Form
    {
        int id_p;
        public FichePerso(int id_pers)
        {

            id_p = id_pers;
            InitializeComponent();
        }

        private void FichePerso_Load(object sender, EventArgs e)
        {
            using (var cnx = new basejdrDataContext())
            {
                var requeteLinq = from table in cnx.View_personnage
                                  where table.id_perso == id_p
                                  select table;

                foreach (View_personnage perso in requeteLinq)
                {
                    labelNomPerso.Text = perso.nom;
                    labelRace.Text = perso.Expr1;
                    labelClasse.Text = perso.Expr2;
                    statForce.Text = perso.force.ToString();
                    statAgi.Text = perso.agilite.ToString();
                    statIntel.Text = perso.intelligence.ToString();
                    statSocial.Text = perso.social.ToString();
                    statIni.Text = perso.initiative.ToString();
                    statPv.Text = perso.pv.ToString();
                    statDef.Text = perso.def.ToString();
                    statCac.Text = perso.dgt_cc.ToString();
                    statAd.Text = perso.dgt_ad.ToString();
                    labelJoueur.Text = perso.pseudo.ToString();
                    if (perso.img != null || perso.img != "")
                    {
                        pictureBox.Image = Image.FromFile(perso.img);
                    }
                    


                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

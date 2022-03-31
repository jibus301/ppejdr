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
    public partial class creationCompetence : Form
    {
        public creationCompetence()
        {
            InitializeComponent();
        }

        private void creationCompetence_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projet_prosqlDataSet11.PERSONNAGE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.pERSONNAGETableAdapter.Fill(this.projet_prosqlDataSet11.PERSONNAGE);
            // TODO: cette ligne de code charge les données dans la table 'projet_prosqlDataSet10.COMPETENCE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cOMPETENCETableAdapter.Fill(this.projet_prosqlDataSet10.COMPETENCE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            basejdrDataContext db = new basejdrDataContext();
            COMPETENCE comp = new COMPETENCE
            {
                nom = textBoxNom.Text,

                stat_liee = comboBox1.SelectedItem.ToString(),

                valeur = textBoxBonus.Text


            };

            db.COMPETENCE.InsertOnSubmit(comp);
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

            labelValidation.Text = "La compétence " + comp.nom + " a bien été ajoutée.";
            textBoxNom.Text = "";
            textBoxBonus.Text = "";
        }
    }
}

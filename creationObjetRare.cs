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
    public partial class creationObjetRare : Form
    {
        public creationObjetRare()
        {
            InitializeComponent();
        }

        private void creationObjetRare_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projet_prosqlDataSet12.PERSONNAGE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.pERSONNAGETableAdapter.Fill(this.projet_prosqlDataSet12.PERSONNAGE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            basejdrDataContext db = new basejdrDataContext();
            OBJET_RARE obj = new OBJET_RARE
            {


                nom = textBoxNom.Text,

                id_perso = Convert.ToInt32(comboBoxPerso.SelectedValue),

                description = textBoxDescrip.Text,

                stats = textBoxSats.Text,

                
            };

            db.OBJET_RARE.InsertOnSubmit(obj);
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
    }
}

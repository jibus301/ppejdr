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
    public partial class creationObjets : Form
    {
        public creationObjets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            basejdrDataContext db = new basejdrDataContext();
            OBJET obj = new OBJET
            {
                nom = textBoxNom.Text,

                valeur = Convert.ToInt32(textBoxValue.Text),

                stat_liee = textBoxStat.Text


            };

            db.OBJET.InsertOnSubmit(obj);
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

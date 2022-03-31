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
    public partial class creationRace : Form
    {
        public creationRace()
        {
            InitializeComponent();
        }

        private void creationRace_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            basejdrDataContext db = new basejdrDataContext();
            RACE race = new RACE
            {
                nom = textBoxNom.Text,

                pv = Convert.ToInt32(textBoxPv.Text),

                force = Convert.ToInt32(textBoxFo.Text),

                intelligence = Convert.ToInt32(textBoxInt.Text),

                agilite = Convert.ToInt32(textBoxAgi.Text),

                initiative = Convert.ToInt32(textBoxIni.Text)


            };

            db.RACE.InsertOnSubmit(race);
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

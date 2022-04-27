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
    public partial class ListePartie : Form
    {
        public ListePartie()
        {
            InitializeComponent();
        }

        private void ListePartie_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projet_prosqlDataSet9.PARTIE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            // this.pARTIETableAdapter.Fill(this.projet_prosqlDataSet9.PARTIE);

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {   
            
            //int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //ecranPartie partie = new ecranPartie(id);
            //partie.ShowDialog();
            
        }
    }
}

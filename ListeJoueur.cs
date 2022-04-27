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
    public partial class ListeJoueur : Form
    {
        public ListeJoueur()
        {
            InitializeComponent();
        }

        private void ListeJoueur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projet_prosqlDataSet8.JOUEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            // this.jOUEURTableAdapter.Fill(this.projet_prosqlDataSet8.JOUEUR);

        }
    }
}

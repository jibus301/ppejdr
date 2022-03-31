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
    public partial class ListePerso : Form
    {
        public ListePerso()
        {
            InitializeComponent();
        }

        private void ListePerso_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projet_prosqlDataSet18.View_personnage'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.view_personnageTableAdapter6.Fill(this.projet_prosqlDataSet18.View_personnage);


        }



        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            FichePerso ficheperso = new FichePerso(id);

            ficheperso.ShowDialog();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

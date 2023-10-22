using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Affichage_memoire : Form
    {
        public Affichage_memoire()
        {
            InitializeComponent();
        }

        private void Affichage_memoire_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet1.Memoire_frais'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.memoire_fraisTableAdapter1.Fill(this.notes_de_fraisDataSet1.Memoire_frais);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Memoire_frais'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.memoire_fraisTableAdapter.Fill(this.notes_de_fraisDataSet.Memoire_frais);

            
        }
    }
}

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
    public partial class Menu : Form
    {

        public static Menu menu;



        public Menu()
        {
            
            InitializeComponent();
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
           
        }

        private void memoireDeFraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mf =new Form1();
            mf.MdiParent = this;
            mf.Show();
        }

        private void rapportDactivitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rapport_d_activité rc = new Rapport_d_activité();
            rc.MdiParent = this;
            rc.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void notesDeFrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Memoire_de_frais mf = new Memoire_de_frais();
            mf.MdiParent = this;
            mf.Show();
            
        }

        private void importFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import_Data id = new Import_Data();
            id.MdiParent = this;
            id.Show();
        }

        private void deconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void importPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import_Pdf pdf = new Import_Pdf();
            pdf.MdiParent = this;
            pdf.Show();
        }

        private void statutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAJStatus mAJStatus = new MAJStatus();
            mAJStatus.MdiParent = this;
            mAJStatus.Show();
        }

        private void departementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAJDepartement mAJDepartement = new MAJDepartement();
            mAJDepartement.MdiParent = this;
            mAJDepartement.Show();
        }

        private void employerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAJEmployer mAJEmployer = new MAJEmployer();
            mAJEmployer.MdiParent = this;
            mAJEmployer.Show();
        }

        private void filtrerRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Memoire_de_frais mf = new Memoire_de_frais();
            mf.MdiParent = this;
            mf.Show();
            
        }

        private void orerDeMissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Générer_Activité OM = new Générer_Activité();
            //OM.MdiParent = this;
            //OM.Show();

        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chercher_order fr = new chercher_order();
            //fr.MdiParent = this;
            //fr.Show();

        }

        private void générerOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  generer_order Gr = new generer_order();
            //Gr.MdiParent = this;
            //Gr.Show();
        }

        private void affichagememoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Affichage_memoire am=new Affichage_memoire();
            //am.MdiParent = this;
            //am.Show();
        }
    }
}

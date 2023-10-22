using ClosedXML.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Composition.Primitives;

namespace WindowsFormsApp2
{
    public partial class MajNotes_Frais : Form
    {
        public MajNotes_Frais()
        {
            InitializeComponent();
        }

        private void memoire_fraisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           
            this.tableAdapterManager.UpdateAll(this.notes_de_fraisDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Employers'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employersTableAdapter.Fill(this.notes_de_fraisDataSet.Employers);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.DataTable1'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.dataTable1TableAdapter.Fill(this.notes_de_fraisDataSet.DataTable1);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Employers'. Vous pouvez la déplacer ou la supprimer selon les besoins.
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RaportOrderMission rap = new RaportOrderMission();
            rap.startReport(Convert.ToInt32( comboBox1.Text),Convert.ToInt32(textBox1.Text),matricule_EmployerComboBox1.SelectedValue.ToString());
            rap.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(DataGridView dataGridView)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           RaportOrderMission rap=new RaportOrderMission();
            rap.startDESc(description_ObjetComboBox.Text,Convert.ToInt32(comboBox1.Text));
            rap.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Notes_Frais nf = new Notes_Frais();
            nf.restartNoteFrais(Convert.ToInt32(id_intervenantComboBox.Text));
            nf.ShowDialog();


                      


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Orders_Mission om=new Orders_Mission();
            om.restart_mission(Convert.ToInt32(id_intervenantComboBox.Text));
            om.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void description_ObjetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void id_intervenantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void matricule_EmployerComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

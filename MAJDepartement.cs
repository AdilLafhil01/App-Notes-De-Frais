using DocumentFormat.OpenXml.Office.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MAJDepartement : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-EBLKF75\SQLEXPRESS;Initial Catalog=notes de frais;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        BindingSource bs = new BindingSource();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        SqlCommand cmd;
        public MAJDepartement()
        {
            InitializeComponent();
        }

        private void departementsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.departementsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.notes_de_fraisDataSet);

        }

        private void MAJDepartement_Load(object sender, EventArgs e)
        {
            charger_grid();
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Departements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.departementsTableAdapter.Fill(this.notes_de_fraisDataSet.Departements);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Departements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           // this.departementsTableAdapter.Fill(this.notes_de_fraisDataSet.Departements);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Departements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.departementsTableAdapter.Fill(this.notes_de_fraisDataSet.Departements);

        }

        private void departementsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void departementsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
           // this.Validate();
            //this.departementsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.notes_de_fraisDataSet);

        }

        private void departementsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            //this.Validate();
            //this.departementsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.notes_de_fraisDataSet);

        }

        private void localisationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void departementsBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            //this.Validate();
            //this.departementsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.notes_de_fraisDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();



                string req1 = "insert into Departements values('" + nom_DepartementTextBox.Text + "','" + localisationTextBox.Text + "')";

                SqlCommand cmd = new SqlCommand(req1, cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("bient ajouter");






                cnx.Close();
                charger_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string req3 = "update Departements set Nom_Departement='" + nom_DepartementTextBox.Text + "',localisation='" + localisationTextBox.Text + "'where id_departement='" + id_DepartementComboBox.Text + "'";
                cnx.Open();
                cmd = new SqlCommand(req3, cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("bient modifier");


                cnx.Close();
                charger_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*string req3 = "delete from Departements where id_departement='" + id_DepartementComboBox.Text + "'" ;
            cnx.Open();
            cmd = new SqlCommand(req3, cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("bient supprimer");
            

            cnx.Close();
            charger_grid();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            nom_DepartementTextBox.Text = "";
            localisationTextBox.Text = "";

        }
        private void charger_grid()
        {
            departementsDataGridView.Refresh();
            cnx.Open();
            string req1 = "select*from Departements";


            cmd = new SqlCommand(req1, cnx);
            //cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(req1, cnx);
            //ds.Clear();
            ds = new DataSet();
            da.Fill(ds, "Departements");
            foreach (DataRow rd in ds.Tables[0].Rows)
            {
                departementsDataGridView.DataSource = ds.Tables[0];
            }
            cnx.Close();

        }
    }
}

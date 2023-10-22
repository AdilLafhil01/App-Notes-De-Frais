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
    public partial class MAJEmployer : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-EBLKF75\SQLEXPRESS;Initial Catalog=notes de frais;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        BindingSource bs = new BindingSource();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        SqlCommand cmd;

        public MAJEmployer()
        {
            InitializeComponent();
        }

        private void employersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.employersBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.notes_de_fraisDataSet);

        }

        private void MAJEmployer_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Memoire_frais'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.memoire_fraisTableAdapter.Fill(this.notes_de_fraisDataSet.Memoire_frais);
            bindingsourse();
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Employers'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employersTableAdapter.Fill(this.notes_de_fraisDataSet.Employers);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.status'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.statusTableAdapter.Fill(this.notes_de_fraisDataSet.status);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Departements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            // this.departementsTableAdapter.Fill(this.notes_de_fraisDataSet.Departements);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.status'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.statusTableAdapter.Fill(this.notes_de_fraisDataSet.status);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Departements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.departementsTableAdapter.Fill(this.notes_de_fraisDataSet.Departements);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Employers'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.employersTableAdapter.Fill(this.notes_de_fraisDataSet.Employers);

        }

        private void employersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void id_departementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Validate();
            //this.employersBindingSource.EndEdit();
            //this.id_DepartementComboBox.EndUpdate();

        }

        private void departementsBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

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



                string req1 = "insert into Employers values('" + matricule_EmployerTextBox.Text + "','" + nom_EmployerTextBox.Text + "','" + prenom_EmployerTextBox.Text + "','" + adressTextBox.Text + "','" + telTextBox.Text + "','" + id_departementComboBox.Text + "','" + id_statutComboBox.Text + "','" + date_affectationDateTimePicker.Value + "')";

                SqlCommand cmd = new SqlCommand(req1, cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("bient ajouter");



                cnx.Close();
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
                string req3 = "update Employers set nom_employer='" + nom_EmployerTextBox.Text + "',prenom_employer='" + prenom_EmployerTextBox.Text + "' ,adress= '" + adressTextBox.Text + "',tel='" + telTextBox.Text + "',id_departement='" + id_departementComboBox.Text + "',id_statut='" + id_statutComboBox.Text + "',date_affectation='" + date_affectationDateTimePicker.Value + "' where matricule_Employer='" + matricule_EmployerTextBox.Text + "'";
                cnx.Open();
                cmd = new SqlCommand(req3, cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("bient modifier");

                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string req3 = "delete from Employers where matricule_Employer='" + matricule_EmployerTextBox.Text + "' ";
                cnx.Open();
                cmd = new SqlCommand(req3, cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("bient supprimer");

                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            matricule_EmployerTextBox.Text = "";
            nom_EmployerTextBox.Text = "";
            prenom_EmployerTextBox.Text = "";
            adressTextBox.Text = "";
            telTextBox.Text = "";
            id_departementComboBox.Text = "";
            id_statutComboBox.Text = "";
            date_affectationDateTimePicker.Text = "";
        }
        public void bindingsourse()
        {
            cnx.Open();
            string req2 = "select * from Employers ";
            cmd = new SqlCommand(req2, cnx);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            bs.DataSource = dt;




            //dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            dr.Close();
            cnx.Close();


        }
        public void navigation()
        {
            matricule_EmployerTextBox.Text = ((DataRowView)bs.Current)[0].ToString();
            nom_EmployerTextBox.Text = ((DataRowView)bs.Current)[1].ToString();
            prenom_EmployerTextBox.Text = ((DataRowView)bs.Current)[2].ToString();
            adressTextBox.Text = ((DataRowView)bs.Current)[3].ToString();
            telTextBox.Text = ((DataRowView)bs.Current)[4].ToString();
            id_departementComboBox.Text = ((DataRowView)bs.Current)[5].ToString();
            id_statutComboBox.Text = ((DataRowView)bs.Current)[6].ToString();
            date_affectationDateTimePicker.Text = ((DataRowView)bs.Current)[7].ToString();
           


        }

        private void button9_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
            navigation();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bs.MovePrevious(); navigation();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bs.MoveNext(); navigation();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bs.MoveLast(); navigation();
        }
    }
}

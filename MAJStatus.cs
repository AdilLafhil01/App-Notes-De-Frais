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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class MAJStatus : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-EBLKF75\SQLEXPRESS;Initial Catalog=notes de frais;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        BindingSource bs = new BindingSource();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        SqlCommand cmd;
        public MAJStatus()
        {
            InitializeComponent();
        }

        private void statusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.notes_de_fraisDataSet);

        }

        private void MAJStatus_Load(object sender, EventArgs e)
        {
            charger_grid();
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.status'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.statusTableAdapter.Fill(this.notes_de_fraisDataSet.status);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.status'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.statusTableAdapter.Fill(this.notes_de_fraisDataSet.status);

        }

        private void statusBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            //this.Validate();
            //this.statusBindingSource.EndEdit();
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



                string req1 = "insert into status values('" + descriptionTextBox.Text + "')";

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
                string req3 = "update status set Description='" + descriptionTextBox.Text + "'where id_statut='" + id_statutComboBox.Text + "'";
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
            try
            {
                string req3 = "delete from status where id_statut='" + id_statutComboBox.Text + "' ";
                cnx.Open();
                cmd = new SqlCommand(req3, cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("bient supprimer");


                cnx.Close();
                charger_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            id_statutComboBox.Text = "";
            descriptionTextBox.Text = "";
        }
        private void charger_grid()
        {
            statusDataGridView.Refresh();
            cnx.Open();
            string req1 = "select*from status";


            cmd = new SqlCommand(req1, cnx);
            //cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(req1, cnx);
            //ds.Clear();
            ds = new DataSet();
            da.Fill(ds, "status");
            foreach (DataRow rd in ds.Tables[0].Rows)
            {
                statusDataGridView.DataSource = ds.Tables[0];
            }
            cnx.Close();

        }
    }
}

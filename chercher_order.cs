using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class chercher_order : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-EBLKF75\SQLEXPRESS;Initial Catalog=notes de frais;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        BindingSource bs = new BindingSource();
        //DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public chercher_order()
        {
            InitializeComponent();
        }

        private void filtrer_rapport_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Departements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.departementsTableAdapter.Fill(this.notes_de_fraisDataSet.Departements);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.status'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.statusTableAdapter.Fill(this.notes_de_fraisDataSet.status);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Employers'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employersTableAdapter.Fill(this.notes_de_fraisDataSet.Employers);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Memoire_frais'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.memoire_fraisTableAdapter.Fill(this.notes_de_fraisDataSet.Memoire_frais);
            //string htmlContent = System.IO.File.ReadAllText("output.html");
            //webBrowser1.DocumentText = htmlContent;

            // ...
            //cnx.Open();

            //string query = "select e.Nom_Employer,e.Prenom_Employer,e.adress,s.Description,d.Nom_departement,o.Description_objet from  Employers e,status s,Departements d,objets o,Memoire_frais m where e.id_departement=d.id_Departement and e.id_statut=s.id_statut and o.id_objet=o.id_objet and id_intervenant=1";
            //SqlCommand command = new SqlCommand(query, cnx);
            //using (SqlDataReader reader = command.ExecuteReader())
            //{
            //    if (reader.Read())
            //    {
            //        string nomEmploye = reader["Nom_Employer"].ToString();
            //        string prenomEmploye = reader["Prenom_Employer"].ToString();
            //        string adresse = reader["adress"].ToString();
            //        string statusDescription = reader["Description"].ToString();
            //        string nomDepartement = reader["Nom_departement"].ToString();
            //        string objectDescription = reader["Description"].ToString();

            //        // Charger le rapport Crystal Reports
            //        ReportDocument report = new ReportDocument();
            //        report.Load("order.rpt"); // Chemin vers votre rapport .rpt

            //        // Associer les données aux champs du rapport
            //        report.SetParameterValue("Nom_Employer", nomEmploye);
            //        report.SetParameterValue("Prenom_Employer", prenomEmploye);
            //        report.SetParameterValue("Adress", adresse);
            //        report.SetParameterValue("Description", statusDescription);
            //        report.SetParameterValue("Nom_departement", nomDepartement);
            //        report.SetParameterValue("Description_objet", objectDescription);

            //        // Afficher le rapport
            //        CrystalReportViewer crystalReportViewer = new CrystalReportViewer();
            //        crystalReportViewer.ReportSource = report;
            //        crystalReportViewer.Show();
            //    }

            //    reader.Close();
            //}
            //cnx.Close();



            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void memoire_fraisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memoire_fraisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.notes_de_fraisDataSet);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employersTableAdapter.FillBy(this.notes_de_fraisDataSet.Employers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            string req = "SELECT * FROM Memoire_frais WHERE Date BETWEEN @date_depart AND @date_arriver ";
            cnx.Open();
            {
                SqlCommand cmd = new SqlCommand(req, cnx);
                cmd.Parameters.AddWithValue("@date_depart", Convert.ToDateTime(date_departDateTimePicker.Text));
                cmd.Parameters.AddWithValue("@date_arriver", Convert.ToDateTime(date_arriverDateTimePicker.Text));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds.Clear();
                da.Fill(ds, "Memoire_frais");
                foreach(DataRow d in ds.Tables["Memoire_frais"].Rows)
                {
                    dataGridView1.DataSource = ds.Tables["Memoire_frais"];
                }
               
                

;
            }
            cnx.Close();
        }
    }
}

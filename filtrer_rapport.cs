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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class filtrer_rapport : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-EBLKF75\SQLEXPRESS;Initial Catalog=notes de frais;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        BindingSource bs = new BindingSource();
        //DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public filtrer_rapport()
        {
            InitializeComponent();
        }

        private void filtrer_rapport_Load(object sender, EventArgs e)
        {


            // ...
            cnx.Open();

            string query = "select e.Nom_Employer,e.Prenom_Employer,e.adress,s.Description,d.Nom_departement,o.Description_objet from  Employers e,status s,Departements d,objets o,Memoire_frais m where e.id_departement=d.id_Departement and e.id_statut=s.id_statut and o.id_objet=o.id_objet and id_intervenant=1";
            SqlCommand command = new SqlCommand(query, cnx);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    string nomEmploye = reader["Nom_Employer"].ToString();
                    string prenomEmploye = reader["Prenom_Employer"].ToString();
                    string adresse = reader["adress"].ToString();
                    string statusDescription = reader["Description"].ToString();
                    string nomDepartement = reader["Nom_departement"].ToString();
                    string objectDescription = reader["Description"].ToString();

                    // Charger le rapport Crystal Reports
                    ReportDocument report = new ReportDocument();
                    report.Load("order.rpt"); // Chemin vers votre rapport .rpt

                    // Associer les données aux champs du rapport
                    report.SetParameterValue("Nom_Employer", nomEmploye);
                    report.SetParameterValue("Prenom_Employer", prenomEmploye);
                    report.SetParameterValue("Adress", adresse);
                    report.SetParameterValue("Description", statusDescription);
                    report.SetParameterValue("Nom_departement", nomDepartement);
                    report.SetParameterValue("Description_objet", objectDescription);

                    // Afficher le rapport
                    CrystalReportViewer crystalReportViewer = new CrystalReportViewer();
                    crystalReportViewer.ReportSource = report;
                    crystalReportViewer.Show();
                }

                reader.Close();
            }
            cnx.Close();



        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}

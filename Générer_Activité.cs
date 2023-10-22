
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.notes_de_fraisDataSetTableAdapters;

namespace WindowsFormsApp2
{
    public partial class Générer_Activité : Form
    {
        //SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-EBLKF75\SQLEXPRESS;Initial Catalog=notes de frais;Integrated Security=True");
        //SqlDataAdapter da = new SqlDataAdapter();
        //SqlDataReader dr;
        //DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        
       

        SqlCommand cmd;
        public Générer_Activité()
        {

            InitializeComponent();
        }
       

        private void ordreMission_Load(object sender, EventArgs e)
        {
            //notes_de_fraisDataSet ns = new notes_de_fraisDataSet();

            //string req = "select*from Memoire_Frais";
            //cnx.Open();
            //SqlCommand cmd = new SqlCommand(req, cnx);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(ns, ns.Tables["Memoire_Frais"].TableName);
            //try
            //{
            //    ReportDataSource ds = new ReportDataSource("Memoire_Frais", ns.Tables["Memoire_Frais"]);
            //    reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            //    this.reportViewer1.LocalReport.DataSources.Clear();

            //    this.reportViewer1.LocalReport.DataSources.Add(ds);
            //    this.reportViewer1.LocalReport.Refresh();

            //}
            //catch (Exception ex) { 

            //MessageBox.Show(ex.Message); 
            //}
            //cnx.Close();

            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Order_mission'. Vous pouvez la déplacer ou la supprimer selon les besoins.

            //    Dim para1 As New ReportParameter("dateDparGarde", datedeparGard.Date)
            //Dim para2 As New ReportParameter("DateFinGarde", dateFinGard.Date)
            //Dim para3 As New ReportParameter("idGarde", idGard)
            //Me.ReportViewer1.LocalReport.SetParameters(para1)
            //Me.ReportViewer1.LocalReport.SetParameters(para2)
            //Me.ReportViewer1.LocalReport.SetParameters(para3)
            //this.order_missionTableAdapter.Fill(this.notes_de_fraisDataSet.Order_mission);
            //this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("orderMission", order_missionBindingSource));
            //this.reportViewer1.RefreshReport();
            
        //    this.reportViewer1.RefreshReport();
        }

        private void btn_Importer_Click(object sender, EventArgs e)
        {






            //notes_de_fraisDataSet.Order_missionDataTable dt = new notes_de_fraisDataSet.Order_missionDataTable();
            ////this.order_missionTableAdapter.Fill(this.notes_de_fraisDataSet.Order_mission);

            //// Créer un BindingSource
            //BindingSource bindingSource = new BindingSource();
            //bindingSource.DataSource = this.notes_de_fraisDataSet.Order_mission;

            // Lier le rapport au contrôle ReportViewer
            //reportViewer1.LocalReport.ReportPath = "@C:\\Users\\lenovo\\OneDrive\\Bureau\\application de gestion des notes de frais\\Report1.rdlc";
            //reportViewer1.LocalReport.DataSources.Clear();
           // reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("notes_de_fraisDataSet", bindingSource));

            // Actualiser le rapport
            //reportViewer1.RefreshReport();





















            //notes_de_fraisDataSet ns = new notes_de_fraisDataSet();

            //string req = "select*from Memoire_Frais";
            //cnx.Open();
            //SqlCommand cmd = new SqlCommand(req, cnx);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(ns, ns.Tables["Memoire_Frais"].TableName);
            //try
            //{
            //    ReportDataSource ds = new ReportDataSource("Memoire_Frais", ns.Tables["Memoire_Frais"]);
            //    reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            //    this.reportViewer1.LocalReport.DataSources.Clear();

            //    this.reportViewer1.LocalReport.DataSources.Add(ds);
            //    this.reportViewer1.LocalReport.Refresh();
            //    this.reportViewer1.RefreshReport();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            //cnx.Close();




        }
        private void ExporterRapportEnPDF(string cheminVersRapport, DataTable dataTable)
        {
            //ReportViewer reportViewer = new ReportViewer();
            //reportViewer.LocalReport.ReportPath = cheminVersRapport; // Chemin vers le rapport RDLC
            //ReportDataSource reportDataSource = new ReportDataSource("notes_de_fraisDataSet", dataTable); // Nom correct de la source de données
            //reportViewer.LocalReport.DataSources.Clear();
            //reportViewer.LocalReport.DataSources.Add(reportDataSource);

            //byte[] pdfBytes = reportViewer.LocalReport.Render("PDF", null, out string mimeType, out string encoding, out string extension, out string[] streams, out Warning[] warnings);

            //string pdfFilePath = "order.pdf"; // Chemin où vous souhaitez enregistrer le fichier PDF
            //File.WriteAllBytes(pdfFilePath, pdfBytes);

            //// Ouvrir le fichier PDF dans le lecteur PDF externe
            //Process.Start(pdfFilePath);
        }

        private void ordreMission_Load_1(object sender, EventArgs e)
        {

        }

        private void ordreMission_Load_2(object sender, EventArgs e)
        {

        }

        private void ordreMission_Load_3(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet1.Order_mission'. Vous pouvez la déplacer ou la supprimer selon les besoins.


            //this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("notes_de_fraisDataSet1", order_missionBindingSource));

            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("notes_de_fraisDataSet1",order_missionBindingSource1));
            this.order_missionTableAdapter1.Fill(this.notes_de_fraisDataSet1.Order_mission);
            ////var paramDate = new ReportParameter("Date", this.notes_de_fraisDataSet1.Order_mission.DateColumn.ToString());
            ////var paramNom = new ReportParameter("Nom_Employer", this.notes_de_fraisDataSet1.Order_mission.Nom_EmployerColumn.ToString());
            ////var paramPrenom = new ReportParameter("Prenom_Employer", this.notes_de_fraisDataSet1.Order_mission.Prenom_EmployerColumn.ToString());
            ////var paramDesc = new ReportParameter("Description", this.notes_de_fraisDataSet1.Order_mission.DescriptionColumn.ToString());
            ////var paramNom_depart = new ReportParameter("Nom_Departement", this.notes_de_fraisDataSet1.Order_mission.Nom_DepartementColumn.ToString());
            ////var paramAdress = new ReportParameter("adress", this.notes_de_fraisDataSet1.Order_mission.adressColumn.ToString());
            ////var paramDesc_objet = new ReportParameter("Description_Objet", this.notes_de_fraisDataSet1.Order_mission.Description_ObjetColumn.ToString());

            ////var paramlieu_deplacement = new ReportParameter("lieu_deplacement", this.notes_de_fraisDataSet1.Order_mission.lieu_deplacementColumn.ToString());

            ////var paramdate_depart = new ReportParameter("date_depart", this.notes_de_fraisDataSet1.Order_mission.date_departColumn.ToString());
            ////var paramdate_arrive = new ReportParameter("date_arriver", this.notes_de_fraisDataSet1.Order_mission.date_arriverColumn.ToString());


            //////// Ajout des paramètres au rapport
            ////this.reportViewer1.LocalReport.SetParameters(paramDate);
            ////this.reportViewer1.LocalReport.SetParameters(paramNom);
            ////this.reportViewer1.LocalReport.SetParameters(paramPrenom);
            ////this.reportViewer1.LocalReport.SetParameters(paramDesc);
            ////this.reportViewer1.LocalReport.SetParameters(paramNom_depart);
            ////this.reportViewer1.LocalReport.SetParameters(paramAdress);
            ////this.reportViewer1.LocalReport.SetParameters(paramDesc_objet);
            ////this.reportViewer1.LocalReport.SetParameters(paramlieu_deplacement);
            ////this.reportViewer1.LocalReport.SetParameters(paramdate_depart);
            ////this.reportViewer1.LocalReport.SetParameters(paramdate_arrive);
            //this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";


            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();


            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void ordermissionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            //List<Memoire_de_frais> employersList = Memoire_de_frais/* Obtenez la liste des employés */;

            //foreach (Memoire_de_frais employee in employersList)
            //{
            //    this.order_missionTableAdapter1.FillByMatricule_Employer(this.notes_de_fraisDataSet1.Order_mission, employee.Matricule_Employer);

            //    var reportDataSource = new ReportDataSource("notes_de_fraisDataSet1", this.notes_de_fraisDataSet1.Order_mission);

            //    this.reportViewer1.LocalReport.DataSources.Clear();
            //    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            //    var paramlieu_deplacement = new ReportParameter("lieu_deplacement", this.notes_de_fraisDataSet1.Order_mission[0].lieu_deplacementColumn.ToString() + " " + employee.Nom_Employer);
            //    this.reportViewer1.LocalReport.SetParameters(paramlieu_deplacement);

            //    this.reportViewer1.LocalReport.Refresh();
            //    this.reportViewer1.RefreshReport();
            //}




        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void matricule_employerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    //matricule_employerComboBox.Text = ((DataRowView)bs.Current)[9].ToString();
            //    //string selectedMatricule = matricule_employerComboBox.SelectedValue.ToString(); // Assurez-vous que la colonne ValueMember est configurée correctement

            //    this.order_missionTableAdapter1.FillBy1(this.notes_de_fraisDataSet1.Order_mission);

            //    // Associer la source de données du rapport
            //    //this.reportViewer1.LocalReport.DataSources.Clear();
            //    //this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("notes_de_fraisDataSet1", this.notes_de_fraisDataSet1.Order_mission));

            //    // Définir les paramètres du rapport
            //    var paramlieu_deplacement = new ReportParameter("lieu_deplacement", this.notes_de_fraisDataSet1.Order_mission.lieu_deplacementColumn.ToString());
            //    this.reportViewer1.LocalReport.SetParameters(paramlieu_deplacement);

            //    var paramdate_depart = new ReportParameter("date_depart", this.notes_de_fraisDataSet1.Order_mission.date_departColumn.ToString());
            //    this.reportViewer1.LocalReport.SetParameters(paramdate_depart);

            //    var paramDesc_objet = new ReportParameter("Description_Objet", this.notes_de_fraisDataSet1.Order_mission.Description_ObjetColumn.ToString());
            //    this.reportViewer1.LocalReport.SetParameters(paramDesc_objet);

            //    // Actualiser le rapport et le rapportViewer
            //    this.reportViewer1.LocalReport.Refresh();
            //    this.reportViewer1.RefreshReport();
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}



        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.order_missionTableAdapter1.FillBy1(this.notes_de_fraisDataSet1.Order_mission, matricule_employerComboBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

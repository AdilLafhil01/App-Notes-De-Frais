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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
//using DocumentFormat.OpenXml.Drawing.Charts;
using System.Windows.Interop;
using Microsoft.Reporting.WinForms;
using System.Data.OleDb;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace WindowsFormsApp2
{
    public partial class MajNoteDeFrais : Form
    {
        //private TextBox hotelTextBox;
        //private TextBox transportTextBox;
        //private TextBox textBoxResult;

        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-EBLKF75\SQLEXPRESS;Initial Catalog=notes de frais;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        BindingSource bs = new BindingSource();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        SqlCommand cmd;
        public MajNoteDeFrais()
        {
            InitializeComponent();
            
            hotelTextBox.TextChanged += CalculateSum;


            
            transportTextBox.TextChanged += CalculateSum;
            repasTextBox.TextChanged += CalculateSum;
            autresTextBox.TextChanged += CalculateSum;
            carburantTextBox.TextChanged += CalculateSum;


            totalTextBox.ReadOnly = true;

            Controls.Add(hotelTextBox);
            Controls.Add(transportTextBox);
            Controls.Add(repasTextBox);
            Controls.Add(carburantTextBox);
            Controls.Add(autresTextBox);
            Controls.Add(totalTextBox);

            //hotelTextBox = new TextBox();
            //hotelTextBox.Location = new System.Drawing.Point(20, 20);
        }
        private void CalculateSum(object sender, EventArgs e)
        {
            
            try
            { 
                double value1 = double.Parse(hotelTextBox.Text);
                double value2 = double.Parse(transportTextBox.Text);
                double value3 = double.Parse(repasTextBox.Text);
                double value4 = double.Parse(carburantTextBox.Text);
                double value5 = double.Parse(autresTextBox.Text);

                double sum = value1 + value2+value3+value4+value5;
                //DataRowView current = (DataRowView)memoire_fraisBindingSource.Current;
                //current.Row["Total"] = sum;
                totalTextBox.Text = sum.ToString();

            }
            catch (FormatException)
            {
                transportTextBox.Text = "0";
                hotelTextBox.Text = "0";
                repasTextBox.Text = "0";
                carburantTextBox.Text = "0";
                autresTextBox.Text = "0";


                //totalTextBox.Text = "Invalid input";
            }
        }
        private void memoire_fraisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
                DataRowView current = (DataRowView)memoire_fraisBindingSource.Current;
            current[0]=dateDateTimePicker.Value.ToString();
            current[10] = date_departDateTimePicker.Value.ToString();
            current[11] = date_arriverDateTimePicker.Value.ToString();
            this.Validate();
               // MessageBox.Show(current["Date"].ToString()+"--1-"+ current[11].ToString() + "-2--");
                this.memoire_fraisBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.notes_de_fraisDataSet);
                


           

        }

        private void MajNoteDeFrais_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Order_mission'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.order_missionTableAdapter.Fill(this.notes_de_fraisDataSet.Memoire_frais./*, Convert.ToInt32(idIntervenant)*/);

            this.memoire_fraisTableAdapter.Fill(this.notes_de_fraisDataSet.Memoire_frais)
            ReportDataSource rd = new Microsoft.Reporting.WinForms.ReportDataSource("order_mission", order_missionBindingSource);

            DataRowView current = (DataRowView)memoire_fraisBindingSource.Current;
            this.Validate();
            this.memoire_fraisBindingSource.EndEdit();
            //dateDateTimePicker.Text = ((DataRowView)memoire_fraisBindingSource.Current)[0].ToString();
            //discriptionTextBox.Text = ((DataRowView)memoire_fraisBindingSource.Current)[1].ToString();
            //hotelTextBox.Text = ((DataRowView)memoire_fraisBindingSource.Current)[2].ToString();
            //transportTextBox.Text = ((DataRowView)memoire_fraisBindingSource.Current)[3].ToString();
            //carburantTextBox.Text = ((DataRowView)memoire_fraisBindingSource.Current)[4].ToString();
            //repasTextBox.Text = ((DataRowView)memoire_fraisBindingSource.Current)[5].ToString();
            //autresTextBox.Text = ((DataRowView)memoire_fraisBindingSource.Current)[6].ToString();
            //totalTextBox.Text = ((DataRowView)memoire_fraisBindingSource.Current)[7].ToString();
            //contrôleTextBox.Text = ((DataRowView)memoire_fraisBindingSource.Current)[8].ToString();
            //matricule_employerComboBox.Text = ((DataRowView)memoire_fraisBindingSource.Current)[9].ToString();
            //date_departDateTimePicker.Text = ((DataRowView)memoire_fraisBindingSource.Current)[10].ToString();
            //date_arriverDateTimePicker.Text = ((DataRowView)memoire_fraisBindingSource.Current)[11].ToString();
            //lieu_deplacementTextBox.Text = ((DataRowView)memoire_fraisBindingSource.Current)[12].ToString();
            //objetComboBox.Text = ((DataRowView)memoire_fraisBindingSource.Current)[13].ToString();
            //id_intervenantTextBox.Text = ((DataRowView)memoire_fraisBindingSource.Current)[14].ToString();









            //DataRowView currentRow = (DataRowView)memoire_fraisBindingSource.Current;
            //////string Nom_employer = currentRow[7].ToString();
            //////string Prenom_employer = currentRow[8].ToString();
            ////string dateDepart = currentRow[10].ToString();
            ////string lieuDeplacement = currentRow[12].ToString();
            //string idIntervenant = currentRow[14].ToString();
            ////string objet = currentRow[13].ToString();

            ////// Remplir les champs d'interface utilisateur
            ////date_departDateTimePicker.Text = dateDepart;
            ////lieu_deplacementTextBox.Text = lieuDeplacement;
            //id_intervenantTextBox.Text = idIntervenant;
            //objetComboBox.Text = objet;


            //// Remplir le jeu de données


            
            DateTime selectedDate = date_arriverDateTimePicker.Value;

            if (checkBox1.Checked)
            {
                selectedDate = selectedDate.AddDays(1);
            }

            date_arriverDateTimePicker.Text = selectedDate.ToString();
        
            //repasTextBox.TextChanged += new System.EventHandler(hotelTextBox_TextChanged);
            //hotelTextBox.TextChanged+= new System.EventHandler(hotelTextBox_TextChanged);
           
            //transportTextBox.TextChanged += new System.EventHandler(hotelTextBox_TextChanged);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.objets'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.objetsTableAdapter.Fill(this.notes_de_fraisDataSet.objets);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Employers'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employersTableAdapter.Fill(this.notes_de_fraisDataSet.Employers);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Memoire_frais'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.memoire_fraisTableAdapter.Fill(this.notes_de_fraisDataSet.Memoire_frais);

            
        }







        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        //private void hotelTextBox_TextChanged(object sender, EventArgs e)
        ////{
        ////    repasTextBox.Text = "0";
        ////    int hotel = Convert.ToInt32(hotelTextBox.Text);
        ////    int repas= Convert.ToInt32(repasTextBox.Text);
        ////    int transport= Convert.ToInt32(transportTextBox.Text="0");
        ////    int carburant = Convert.ToInt32(carburantTextBox.Text="0");
        ////    int autre = Convert.ToInt32(autresTextBox.Text = "0");

        ////    totalTextBox.Text=Convert.ToString( hotel+repas+transport+carburant+autre);
        ////}

        private void transportTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void matricule_employerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string req = "select*from Memoire_frais where matricule_employer='" + matricule_employerComboBox.Text + "' ";
            cnx.Open();
            cmd = new SqlCommand(req, cnx);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //dt = new DataTable();
            ds.Clear();
            da.Fill(ds, "Memoire_frais");
            foreach (DataRow rd in ds.Tables["Memoire_frais"].Rows)
            {
                dataGridView1.DataSource = ds.Tables["Memoire_frais"];
            }
            cnx.Close();

        }

        private void memoire_fraisBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void id_intervenantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    string req = "select*from Memoire_frais where id_intervenant='" + id_intervenantComboBox.Text + "' ";
            //    cnx.Open();
            //    cmd = new SqlCommand(req, cnx);
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    dt = new DataTable();
            //    ds.Clear();
            //    da.Fill(ds, "Memoire_frais");
            //    foreach (DataRow rd in ds.Tables["Memoire_frais"].Rows)
            //    {
            //        dataGridView1.DataSource = ds.Tables["Memoire_frais"];
            //    }
            //    cnx.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();

            string idIntervenant = id_intervenantTextBox.Text;
            string query = "SELECT e.Nom_Employer, e.Prenom_Employer, e.adress, s.Description, d.Nom_Departement, o.Description_objet " +
                           "FROM Employers e, status s, Departements d, objets o, Memoire_frais m " +
                           "WHERE e.id_departement = d.id_Departement AND e.id_statut = s.id_statut AND m.objet = o.id_objet AND id_intervenant = " + idIntervenant;

            SqlCommand command = new SqlCommand(query, cnx);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Document pdfDocument = new Document();

                    string nomEmploye = reader["Nom_Employer"].ToString();
                    string prenomEmploye = reader["Prenom_Employer"].ToString();
                    string pdfFileName = $"{nomEmploye}_{prenomEmploye}_order.pdf";
                    string pdfFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), pdfFileName);

                    PdfWriter.GetInstance(pdfDocument, new FileStream(pdfFilePath, FileMode.Create));

                    pdfDocument.Open();

                    string adresse = reader["adress"].ToString();
                    string statusDescription = reader["Description"].ToString();
                    string nomDepartement = reader["Nom_Departement"].ToString();
                    string objectDescription = reader["Description_objet"].ToString();

                    pdfDocument.Add(new Paragraph($"Nom Employé: {nomEmploye}\nPrénom Employé: {prenomEmploye}\nAdresse: {adresse}\nStatut: {statusDescription}\nDépartement: {nomDepartement}\nObjet: {objectDescription}\n\n"));

                    pdfDocument.Close();
                }

                reader.Close();
            }

            MessageBox.Show("PDFs generated successfully.");

            cnx.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DateTime selectedDate = date_arriverDateTimePicker.Value;

            //if (checkBox1.Checked)
            //{
            //    selectedDate = selectedDate.AddDays(1);
            //}

            //date_arriverDateTimePicker.Value = selectedDate;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //    cnx.Open();

            //    string query = "SELECT m.Date, e.Nom_Employer, e.Prenom_Employer, m.date_depart, m.date_arriver, m.lieu_deplacement, o.Description_Objet " +
            //                   "FROM Employers e, Memoire_frais m,Objets o " +
            //                   "WHERE e.matricule_Employer = m.matricule_employer and m.objet=o.id_objet";

            //    SqlCommand command = new SqlCommand(query, cnx);

            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //Document pdfDocument = new Document();
            //this.notes_de_fraisDataSet.EnforceConstraints = false;
            //this.order_missionTableAdapter.Fill(this.notes_de_fraisDataSet.Order_mission);
            ////this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("notes_de_fraisDataSet", order_missionBindingSource));

            ////var paramNom = new ReportParameter("Nom_Employer", this.notes_de_fraisDataSet.Order_mission.Nom_EmployerColumn.ToString());
            ////var paramPrenom = new ReportParameter("Prenom_Employer", this.notes_de_fraisDataSet.Order_mission.Prenom_EmployerColumn.ToString());
            ////var paramDesc_objet = new ReportParameter("Description_Objet", this.notes_de_fraisDataSet.Order_mission.Description_ObjetColumn.ToString());

            ////var paramlieu_deplacement = new ReportParameter("lieu_deplacement", this.notes_de_fraisDataSet.Order_mission.lieu_deplacementColumn.ToString());

            ////var paramdate_depart = new ReportParameter("date_depart", this.notes_de_fraisDataSet.Order_mission.date_departColumn.ToString());
            //////this.reportViewer1.LocalReport.SetParameters(paramNom);
            ////        this.reportViewer1.LocalReport.SetParameters(paramPrenom);
            ////        this.reportViewer1.LocalReport.SetParameters(paramDesc_objet);
            ////        this.reportViewer1.LocalReport.SetParameters(paramlieu_deplacement);
            ////        this.reportViewer1.LocalReport.SetParameters(paramdate_depart);
            //this.reportViewer1.LocalReport.Refresh();
            //this.reportViewer1.RefreshReport();




            //string paramID = Convert.ToInt32(id_intervenantTextBox.Text).ToString();


            ///*int paramID =*/ Convert.ToInt32(id_intervenantTextBox.Text);




            notes_de_fraisDataSet ds = new notes_de_fraisDataSet();

            // Récupérer les valeurs à afficher






            // Définir les paramètres du rapport
            id_intervenantTextBox.Text = ((DataRowView)order_missionBindingSource.Current)[13].ToString();










            
            ReportDataSource rd = new Microsoft.Reporting.WinForms.ReportDataSource("order_mission", order_missionBindingSource);
            this.order_missionTableAdapter.Fill(this.notes_de_fraisDataSet.Or/*, Convert.ToInt32(idIntervenant)*/);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rd);
            ReportParameter paramid_intervenant = new ReportParameter("paramId", id_intervenantTextBox.Text);
            this.reportViewer1.LocalReport.SetParameters(paramid_intervenant);

            // Rafraîchir le rapport et le ReportViewer
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.Refresh();









            //var paramNom = new ReportParameter("Nom_Employer", this.notes_de_fraisDataSet.Order_mission.Nom_EmployerColumn.ToString());
            //this.reportViewer1.LocalReport.SetParameters(paramNom);
            //var paramprenom = new ReportParameter("prenom_Employer", this.notes_de_fraisDataSet.Order_mission.Nom_EmployerColumn.ToString());
            //this.reportViewer1.LocalReport.SetParameters(paramprenom);

            //var paramlieu_deplacement = new ReportParameter("lieu_deplacement", this.notes_de_fraisDataSet.Order_mission.lieu_deplacementColumn.ToString());
            //this.reportViewer1.LocalReport.SetParameters(paramlieu_deplacement);

            //var paramdate_depart = new ReportParameter("date_depart", this.notes_de_fraisDataSet.Order_mission.date_departColumn.ToString());
            //this.reportViewer1.LocalReport.SetParameters(paramdate_depart);

            //var paramDesc_objet = new ReportParameter("Description_Objet", this.notes_de_fraisDataSet.Order_mission.Description_ObjetColumn.ToString());
            //this.reportViewer1.LocalReport.SetParameters(paramDesc_objet);









            //    }

            //    reader.Close();
            //}









            //MessageBox.Show("afficher avec succes");

            //cnx.Close();
            //notes_de_fraisDataSet ds = new notes_de_fraisDataSet();
            //date_departDateTimePicker.Text = ((DataRowView)order_missionBindingSource.Current)[3].ToString();
            //lieu_deplacementTextBox.Text = ((DataRowView)order_missionBindingSource.Current)[5].ToString();
            //id_intervenantTextBox.Text = ((DataRowView)order_missionBindingSource.Current)[13].ToString();
            //objetComboBox.Text = ((DataRowView)order_missionBindingSource.Current)[12].ToString();
            //order_missionBindingSource.DataSource = ds;

            //this.order_missionTableAdapter.FillBy1(this.notes_de_fraisDataSet.Order_mission, Convert.ToInt32(id_intervenantTextBox.Text.ToString())) ;
            //ReportDataSource rd = new Microsoft.Reporting.WinForms.ReportDataSource("order_mission", order_missionBindingSource);
            //this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(rd);
            //ReportParameter paramNom = new ReportParameter("paramNom", this.notes_de_fraisDataSet.Order_mission.Nom_EmployerColumn.ToString());
            //this.reportViewer1.LocalReport.SetParameters(paramNom);
            //ReportParameter paramPrenom = new ReportParameter("paramPrenom", this.notes_de_fraisDataSet.Order_mission.Prenom_EmployerColumn.ToString());
            //this.reportViewer1.LocalReport.SetParameters(paramPrenom);
            //ReportParameter paramDate = new ReportParameter("paramDate", this.notes_de_fraisDataSet.Order_mission.date_departColumn.ToString());
            //this.reportViewer1.LocalReport.SetParameters(paramDate);
            //ReportParameter paramLieu = new ReportParameter("paramLieu", this.notes_de_fraisDataSet.Order_mission.lieu_deplacementColumn.ToString());
            //this.reportViewer1.LocalReport.SetParameters(paramLieu);
            //ReportParameter paramDesc = new ReportParameter("paramDesc", this.notes_de_fraisDataSet.Order_mission.Description_ObjetColumn.ToString());
            //this.reportViewer1.LocalReport.SetParameters(paramDesc);
            //this.reportViewer1.LocalReport.Refresh();
            //this.reportViewer1.RefreshReport();
        }

        private void objetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataGridView1.Refresh();
            //string req = "select*from objets where Description_Objet='" + objetComboBox.Text+"' ";
            //cnx.Open();
            //cmd = new SqlCommand(req,cnx);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //ds.Clear();
            //da.Fill(ds, "objets");
            //foreach(DataRow d in ds.Tables["objets"].Rows)
            //{
            //    dataGridView1.DataSource = ds.Tables["objets"];
            //}
            //cnx.Close();

            //ReportParameter paramNom = new ReportParameter("paramNom", ds.Order_mission.Nom_EmployerColumn.ToString());
            //ReportParameter paramPrenom = new ReportParameter("paramPrenom", ds.Order_mission.Prenom_EmployerColumn.ToString());
            //ReportParameter paramDate = new ReportParameter("paramDate", ds.Order_mission.date_departColumn.ToString());
            //ReportParameter paramLieu = new ReportParameter("paramLieu", ds.Order_mission.lieu_deplacementColumn.ToString());
            //ReportParameter paramDesc = new ReportParameter("paramDesc", ds.Order_mission.Description_ObjetColumn.ToString());

            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { paramNom, paramPrenom, paramDate, paramLieu, paramDesc });

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void date_arriverDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = date_arriverDateTimePicker.Value;

            if (checkBox1.Checked)
            {
                selectedDate = selectedDate.AddDays(1);
            }

            date_arriverDateTimePicker.Value = selectedDate;
        }

        //private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        //{
        //    id_intervenantTextBox.Text = ((DataRowView)memoire_fraisBindingSource.Current)[12].ToString();
        //}






        //string nomEmploye = reader["Nom_Employer"].ToString();
        //string prenomEmploye = reader["Prenom_Employer"].ToString();
        //string pdfFileName = $"{nomEmploye}_{prenomEmploye}_activites.pdf";
        //string pdfFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), pdfFileName);

        //PdfWriter.GetInstance(pdfDocument, new FileStream(pdfFilePath, FileMode.Create));

        //pdfDocument.Open();

        //string date = reader["Date"].ToString();
        //string date_depart = reader["date_depart"].ToString();
        ////string date_arriver = reader["date_arriver"].ToString();
        //string lieu_deplacement = reader["lieu_deplacement"].ToString();
        //string Objet = reader["Description_Objet"].ToString();

        //pdfDocument.Add(new Paragraph($"Date : {date}\nNom Employé : {nomEmploye}\nPrénom Employé : {prenomEmploye}\nDescription_Objet : {Objet}\n\n"));

        //            pdfDocument.Close();
        public void navigation()
        {
            dateDateTimePicker.Text = ((DataRowView)order_missionBindingSource.Current)[0].ToString();
            discriptionTextBox.Text = ((DataRowView)order_missionBindingSource.Current)[1].ToString();
            hotelTextBox.Text = ((DataRowView)order_missionBindingSource.Current)[2].ToString();
            transportTextBox.Text = ((DataRowView)bs.Current)[3].ToString();
            carburantTextBox.Text = ((DataRowView)order_missionBindingSource.Current)[4].ToString();
            repasTextBox.Text = ((DataRowView)order_missionBindingSource.Current)[5].ToString();
            autresTextBox.Text = ((DataRowView)order_missionBindingSource.Current)[6].ToString();
            totalTextBox.Text = ((DataRowView)order_missionBindingSource.Current)[7].ToString();
            contrôleTextBox.Text = ((DataRowView)order_missionBindingSource.Current)[8].ToString();
            matricule_employerComboBox.Text = ((DataRowView)order_missionBindingSource.Current)[9].ToString();
            date_departDateTimePicker.Text = ((DataRowView)order_missionBindingSource.Current)[10].ToString();
            date_arriverDateTimePicker.Text = ((DataRowView)order_missionBindingSource.Current)[11].ToString();
            lieu_deplacementTextBox.Text = ((DataRowView)order_missionBindingSource.Current)[12].ToString();
            objetComboBox.Text = ((DataRowView)order_missionBindingSource.Current)[13].ToString();
            id_intervenantTextBox.Text = ((DataRowView)order_missionBindingSource.Current)[14].ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void id_departementLabel1_Click(object sender, EventArgs e)
        {

        }

        private void memoire_fraisBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void prenom_EmployerLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

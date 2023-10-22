using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using Org.BouncyCastle.Ocsp;
using DocumentFormat.OpenXml.Drawing;
using System.Globalization;
using DocumentFormat.OpenXml.Office.Word;
using ClosedXML.Excel;

namespace WindowsFormsApp2
{
    public partial class Import_Data : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-EBLKF75\SQLEXPRESS;Initial Catalog=notes de frais;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        BindingSource bs = new BindingSource();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public Import_Data()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try { 
            string path = "provider=microsoft.jet.OLEDB.4.0;Data source=" + txt_path.Text + ";Extended properties=\"Excel 8.0;HDR=yes;\";";
            OleDbConnection cnn = new OleDbConnection(path);
            OleDbDataAdapter adapter = new OleDbDataAdapter("select*from["+txt_name.Text+"$]",cnn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txt_path.Text = ofd.FileName;
            }
        }

        private void Import_Data_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Memoire_frais'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.memoire_fraisTableAdapter1.Fill(this.notes_de_fraisDataSet.Memoire_frais);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void insertData()
        {
            {
                dataGridView1.Refresh();
                if (dataGridView1.Rows.Count > 0)
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-EBLKF75\SQLEXPRESS;Initial Catalog=notes de frais;Integrated Security=True"))
                    {
                        connection.Open();
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    if (row.Cells[5].Value != null)
                                    {
                                        string ville = row.Cells[5].Value.ToString();

                                        string heurArriverValue = row.Cells[11].Value.ToString();
                                        int hArriver = Convert.ToInt32(heurArriverValue.Substring(0, heurArriverValue.IndexOf("H")));
                                        int minuteArriver = Convert.ToInt32(heurArriverValue.Substring(heurArriverValue.IndexOf("H") + 1));
                                        string dateDepartValue = row.Cells[3].Value.ToString();
                                        DateTime datedepart = Convert.ToDateTime(dateDepartValue);
                                        DateTime dateArriver = datedepart;
                                        dateArriver = dateArriver.AddHours(hArriver);
                                        dateArriver = dateArriver.AddMinutes(minuteArriver);
                                        string req = "INSERT INTO Memoire_frais (Date, Discription, Hotel, Transport, Carburant, Repas, Autres, Total, Contrôle, matricule_employer, date_depart, date_arriver, lieu_deplacement, Objet, Id_rapport) " +
                                            "VALUES (@Date, @Discription, @Hotel, @Transport, @Carburant, @Repas, @Autres, @Total, @Contrôle, @matricule_employer, @date_depart, @date_arriver, @lieu_deplacement, @Objet, @Id_rapport)";

                                        SqlCommand cmd = new SqlCommand(req, connection, transaction);
                                        cmd.Parameters.AddWithValue("@Date", datedepart);
                                        cmd.Parameters.AddWithValue("@Discription", row.Cells[14].Value.ToString());
                                        cmd.Parameters.AddWithValue("@Hotel", 0);
                                        cmd.Parameters.AddWithValue("@Transport", 60);
                                        cmd.Parameters.AddWithValue("@Carburant", 0);
                                        cmd.Parameters.AddWithValue("@Repas", 0);
                                        cmd.Parameters.AddWithValue("@Autres", 0);
                                        cmd.Parameters.AddWithValue("@Total", 0);
                                        cmd.Parameters.AddWithValue("@Contrôle", 0);
                                        cmd.Parameters.AddWithValue("@matricule_employer", "");
                                        cmd.Parameters.AddWithValue("@date_arriver", dateArriver);
                                        cmd.Parameters.AddWithValue("@date_depart", datedepart);
                                        cmd.Parameters.AddWithValue("@lieu_deplacement", ville);
                                        cmd.Parameters.AddWithValue("@Objet", row.Cells[9].Value.ToString());
                                        cmd.Parameters.AddWithValue("@Id_rapport", row.Cells[0].Value.ToString());

                                        string reqSelect = "SELECT TOP 1 * FROM employers WHERE Nom_Employer = @Nom_Employer";
                                        SqlCommand cmd3 = new SqlCommand(reqSelect, connection, transaction);
                                        cmd3.Parameters.AddWithValue("@Nom_Employer", row.Cells[8].Value.ToString());
                                        SqlDataReader dr = cmd3.ExecuteReader();

                                        if (dr.Read())
                                        {
                                            cmd.Parameters["@matricule_Employer"].Value = dr[0].ToString();
                                            
                                            
                                        }
                                        dr.Close();
                                       // MessageBox.Show(dataGridView1.Rows.Count.ToString());

                                        string heureArriverText = row.Cells[11].Value.ToString();
                                        int h = Convert.ToInt32(heureArriverText.Substring(0, heureArriverText.IndexOf("H")));

                                        bool testRepas = ville.Equals("RABAT");
                                        if (testRepas)
                                        {
                                            if (h >= 13)
                                                cmd.Parameters["@Repas"].Value = 80;
                                        }
                                        else
                                        {
                                            dateArriver = dateArriver.AddDays(1);
                                            cmd.Parameters["@date_arriver"].Value = dateArriver;
                                            cmd.Parameters["@Hotel"].Value = 450 * 1;
                                            cmd.Parameters["@Repas"].Value = 190 * 1;
                                        }

                                        cmd.ExecuteNonQuery();
                                    }
                                }
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Une erreur est survenue : " + ex.Message);
                                transaction.Rollback();
                            }
                        }
                    }
                }
            }

            /* dataGridView1.Refresh();
             if (dataGridView1.Rows.Count > 0)
             {
                 using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-EBLKF75\SQLEXPRESS;Initial Catalog=notes de frais;Integrated Security=True"))
                 {
                     connection.Open();
                     using (SqlTransaction transaction = connection.BeginTransaction())
                     {

                         try
                         {
                             foreach (DataGridViewRow row in dataGridView1.Rows)
                             {

                                 if (row.Cells[5] != null && row.Cells[5].Value != null)
                                 {
                                     string ville = row.Cells[5].Value.ToString();



                                     string heurArriverValue = row.Cells[11].Value.ToString();
                                     int hArriver = Convert.ToInt32(heurArriverValue.Substring(0, heurArriverValue.IndexOf("H")));
                                     int minuteArriver = Convert.ToInt32(heurArriverValue.Substring(heurArriverValue.IndexOf("H") + 1));
                                     string dateDepartValue = row.Cells[3].Value.ToString();

                                     /*=Convert.ToDateTime(dateArriverValue)

                                     DateTime datedepart = Convert.ToDateTime(dateDepartValue);
                                     DateTime dateArriver = datedepart;
                                     dateArriver = dateArriver.AddHours(hArriver);
                                     dateArriver = dateArriver.AddMinutes(minuteArriver);
                                     string req = "INSERT INTO Memoire_frais (Date, Discription, Hotel, Transport, Carburant, Repas, Autres, Total, Contrôle, matricule_employer, date_depart, date_arriver, lieu_deplacement, Objet,Id_rapport) " +
                                          "VALUES (@Date, @Discription, @Hotel, @Transport, @Carburant, @Repas, @Autres, @Total, @Contrôle, @matricule_employer, @date_depart, @date_arriver, @lieu_deplacement, @Objet,@Id_rapport)";

                                     SqlCommand cmd = new SqlCommand(req, connection, transaction);
                                     cmd.Parameters.AddWithValue("@Date", datedepart);
                                     cmd.Parameters.AddWithValue("@Discription", row.Cells[14].Value.ToString());
                                     cmd.Parameters.AddWithValue("@Hotel", 0);
                                     cmd.Parameters.AddWithValue("@Transport", 60);
                                     cmd.Parameters.AddWithValue("@Carburant", 0);
                                     cmd.Parameters.AddWithValue("@Repas", 0);
                                     cmd.Parameters.AddWithValue("@Autres", 0);
                                     cmd.Parameters.AddWithValue("@Total", 0);
                                     cmd.Parameters.AddWithValue("@Contrôle", 0);
                                     cmd.Parameters.AddWithValue("@date_arriver", dateArriver);
                                     cmd.Parameters.AddWithValue("@date_depart", datedepart);
                                     cmd.Parameters.AddWithValue("@lieu_deplacement", ville);
                                     cmd.Parameters.AddWithValue("@Objet", row.Cells[9].Value.ToString());

                                     cmd.Parameters.AddWithValue("@Id_rapport", row.Cells[0].Value);
                                     string reqSelect = "select top 1 * from employers where Nom_Employer='" + row.Cells[8].Value.ToString() + "'";
                                     SqlCommand cmd3 = new SqlCommand(reqSelect, connection, transaction);
                                     cmd3.Parameters.AddWithValue("@Nom_Employer", row.Cells[8].Value.ToString());

                                     SqlDataReader dr = cmd3.ExecuteReader();

                                     if (dr.Read())
                                     {
                                         cmd.Parameters.AddWithValue("@matricule_employer", dr[0].ToString());
                                         MessageBox.Show(dr[0].ToString());
                                         MessageBox.Show(row.Cells[8].Value.ToString());

                                     }
                                     dr.Close();







                                     string heureArriverText = row.Cells[11].Value.ToString();

                                     int h = Convert.ToInt32(heureArriverText.Substring(0, heureArriverText.IndexOf("H")));




                                     bool testRepas = ville.Equals("RABAT");
                                     if (testRepas)
                                     {


                                         if (h >= 13)
                                             cmd.Parameters["@Repas"].Value = 80;


                                     }


                                     else
                                     {
                                         dateArriver = dateArriver.AddDays(1);
                                         cmd.Parameters["@date_arriver"].Value = dateArriver;
                                         cmd.Parameters["@Hotel"].Value = 450 * 1;
                                         cmd.Parameters["@Repas"].Value = 190 * 1;
                                     }



                                     cmd.ExecuteNonQuery();








                                 }


                             }

                             transaction.Commit();

                         }

                         catch (Exception ex)
                         {
                             MessageBox.Show("Une erreur est survenue : " + ex.Message);
                             transaction.Rollback();
                         }
                     }

                     dataGridView1.DataSource = null;
                     dataGridView1.DataSource = notes_de_fraisDataSet.Memoire_frais;
                     connection.Close();
                     //MessageBox.Show(row.Cells[3].Value.ToString());
                 }
             }


            */

        }



        private void button1_Click(object sender, EventArgs e)
        {
            insertData();

            /*if (dataGridView1.Rows.Count > 0)
            {
                // Accédez à la cellule
                MessageBox.Show(dataGridView1.Rows[1].Cells[8].Value.ToString());
            }
            else
            {
                // Gérez le cas où 
                MessageBox.Show("la grille ne contient pas suffisamment de lignes");
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel workbook|*.xlsx" })

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            wb.Worksheets.Add(this.notes_de_fraisDataSet.Memoire_frais.CopyToDataTable(), "Memoire_frais");
                            wb.SaveAs(sfd.FileName);

                        }
                        MessageBox.Show("you have successfully exported your data to an excel file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
        }
    }
}

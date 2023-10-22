using ClosedXML.Excel;
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
    public partial class notes_de_frais : Form
    {
        public notes_de_frais()
        {
            InitializeComponent();
        }

        private void notes_de_frais_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Memoire_frais'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.memoire_fraisTableAdapter.Fill(this.notes_de_fraisDataSet.Memoire_frais);

        }

        private void btn_Exporter_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.Reporting.WinForms;
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
    public partial class Notes_Frais : Form
    {
        public Notes_Frais()
        {
            InitializeComponent();
        }

        private void Notes_Frais_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.DataTable1'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.dataTable1TableAdapter.Fill(this.notes_de_fraisDataSet.DataTable1);

            this.reportViewer1.RefreshReport();
        }
        public void restartNoteFrais(int id)
        {
            
            this.dataTable1TableAdapter.FillByid_intervenant(this.notes_de_fraisDataSet.DataTable1, id);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("order_mission2", dataTable1BindingSource));

            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.Refresh();
        }
        
    }
}

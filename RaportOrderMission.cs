using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class RaportOrderMission : Form
    {
        public RaportOrderMission()
        {
            InitializeComponent();
        }

        private void RaportOrderMission_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.DataTable1'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           // this.dataTable1TableAdapter.Fill(this.notes_de_fraisDataSet.DataTable1);
            // TODO: cette ligne de code charge les données dans la table 'notes_de_fraisDataSet.Memoire_frais'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           // this.memoire_fraisTableAdapter.Fill(this.notes_de_fraisDataSet.Memoire_frais);

            this.reportViewer1.RefreshReport();
          //  this.reportViewer2.RefreshReport();
        }

        private void memoire_fraisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*this.Validate();
            this.memoire_fraisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.notes_de_fraisDataSet);*/
           
        }
        public void startReport(int mois,int anne,string matricule)
        {
            // Me.DataTable1TableAdapter.FillByUniteMonth(Me.LaboGardDataSet.DataTable1, datedeparGard.Date.Month, idunite)
            //Me.DataTable1TableAdapter.FillByIdGarde(Me.LaboGardDataSet.DataTable1, idGard)
            //this.memoire_fraisTableAdapter.Fill(this.notes_de_fraisDataSet.Memoire_frais);
            ReportParameter parm = new ReportParameter("mois", Convert.ToInt32(mois).ToString());
            this.reportViewer1.LocalReport.SetParameters(parm);
            this.dataTable1TableAdapter.FillBy_matr_mois(this.notes_de_fraisDataSet.DataTable1, matricule,mois,anne);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("order_mission",dataTable1BindingSource));
            
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.Refresh();

            // para1 As New ReportParameter("dateDparGarde", Date.Now)

            //    Dim para2 As New ReportParameter("DateFinGarde", Date.Now)
            //    Dim para3 As New ReportParameter("idGarde", idGard)
            //    Me.ReportViewer1.LocalReport.SetParameters(para1)
            //    Me.ReportViewer1.LocalReport.SetParameters(para2)
            //    Me.ReportViewer1.LocalReport.SetParameters(para3)
            //    Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("programmeGarde", DataTable1BindingSource))
            //    Me.ReportViewer1.RefreshReport()
            //End Sub
        }
        public void filtrer_desc(string description_objet,int mois)
        {
            ReportParameter parm = new ReportParameter("mois", Convert.ToInt32(mois).ToString());
            this.reportViewer1.LocalReport.SetParameters(parm);
            this.dataTable1TableAdapter.FillBy_description_objet(this.notes_de_fraisDataSet.DataTable1, description_objet);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("order_mission", dataTable1BindingSource));

            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.Refresh();

        }

    }

}

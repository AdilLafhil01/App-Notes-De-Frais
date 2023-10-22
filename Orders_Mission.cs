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
    public partial class Orders_Mission : Form
    {
        public Orders_Mission()
        {
            InitializeComponent();
        }

        private void Orders_Mission_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        public void restart_mission(int moi,int annee,string matricule)
        {
            ReportParameter param=new ReportParameter("moi", Convert.ToInt32(moi).ToString());
            this.reportViewer1.LocalReport.SetParameters(param);
            this.dataTable1TableAdapter1.FillById_rapport(this.notes_de_fraisDataSet1.DataTable1,moi,annee,matricule);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("order_mission2", dataTable1BindingSource));
            //MessageBox.Show(dataTable1BindingSource.Count.ToString());

            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.Refresh();
        }
    }
}

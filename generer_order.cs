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
    public partial class generer_order : Form
    {
        public generer_order()
        {
            InitializeComponent();
        }

        private void generer_order_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("notes_de_fraisDataSet1", order_missionBindingSource));
            this.order_missionTableAdapter1.Fill(this.notes_de_fraisDataSet1.Order_mission);
            this.reportViewer1.Refresh();
            this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}

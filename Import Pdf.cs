using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Import_Pdf : Form
    {
        public Import_Pdf()
        {
            InitializeComponent();
        }

        private void Import_Pdf_Load(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "pdf File|*.pdf";
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(open.FileName))
                {
                    this.pdfViewer1.LoadFromFile(open.FileName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pdfViewer1_Click(object sender, EventArgs e)
        {

        }
    }
}

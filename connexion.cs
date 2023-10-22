//using DocumentFormat.OpenXml.Office.CustomUI;
//using DocumentFormat.OpenXml.Office2010.CustomUI;
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

namespace WindowsFormsApp2
{
    public partial class connexion : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-EBLKF75\SQLEXPRESS;Initial Catalog=notes de frais;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        BindingSource bs = new BindingSource();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        SqlCommand cmd;
        Menu m = new Menu();
        int i = 0;
        bool Exist = false;
        public connexion()
        {
            
            InitializeComponent();
        }
        
        private void txt_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_connecter_Click(object sender, EventArgs e)
        { 
           

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_connecter_Click_1(object sender, EventArgs e)
        {
            cnx.Open();
            string req = "SELECT * FROM authentification";
            SqlCommand cmd = new SqlCommand(req, cnx);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            for (i = 0; i < dt.Rows.Count - 1; i++)
            {
                if (dt.Rows[i][0].ToString() == txt_login.Text && dt.Rows[i][1].ToString() == txt_pass.Text)
                {
                    //cmd.Parameters.AddWithValue("@login", txt_login.Text);
                    //cmd.Parameters.AddWithValue("@password", txt_pass.Text);
                    Exist = true;
                    //MessageBox.Show("login et password ok");
                    // Memoire_de_frais mf = new Memoire_de_frais();
                    m.Show();
                    this.Hide();
                    //mf.Show();

                   



                }


            }
            if (Exist == false)
            {


                MessageBox.Show("check your login or password");
                vider();

            }



            cnx.Close();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void vider()
        {
            txt_login.Text = "";
            txt_pass.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void connexion_Load(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    //private void btn_close_Click_1(object sender, EventArgs e)
    //{

    //}

}

using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Memoire_de_frais : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-EBLKF75\SQLEXPRESS;Initial Catalog=notes de frais;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        BindingSource bs = new BindingSource();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        
        SqlCommand cmd;
        
        public Memoire_de_frais()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();

            

            string req1 = "insert into Memoire_frais values('" + txt_date.Value + "','" + txt_desc.Text + "','" + txt_total.Text + "','" + txt_trans.Text + "','" + txt_carb.Text + "','" + txt_repa.Text + "','" + txt_autr.Text + "','" + txt_total.Text + "','" + txtcontr.Text + "')";
            
            SqlCommand cmd = new SqlCommand(req1,cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("bient ajouter");
           
            

            cnx.Close();

            charger_grid();
        }
        private void charger_grid()
        {
            dataGridView1.Refresh();
            cnx.Open();
            string req1 = "select*from Memoire_frais";
            

            cmd = new SqlCommand(req1, cnx);
            //cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(req1, cnx);
            //ds.Clear();
            ds = new DataSet();
            da.Fill(ds, "Memoire_frais");
            foreach (DataRow rd in ds.Tables[0].Rows)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            cnx.Close();

        }

        private void Memoire_de_frais_Load(object sender, EventArgs e)
        {
            charger_grid();
            bindingsourse();
            nbr_total_frais();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string req3 = "update Memoire_frais set Discription='" + txt_desc.Text + "',Hotel='" + txt_hotel.Text + "' ,Transport= '" + txt_trans.Text+"',Carburant='"+txt_carb.Text+"',Repas='"+txt_repa.Text+ "',Autres='" + txt_autr.Text+"',Total='"+txt_total.Text+ "',Contrôle='"+txtcontr.Text+"' where Date='" + txt_date.Value + "'";
            cnx.Open();
            cmd = new SqlCommand(req3, cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("bient modifier");

            cnx.Close();
            charger_grid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string req3 = "delete from Memoire_frais where Date='" + txt_date.Value + "' ";
            cnx.Open();
            cmd = new SqlCommand(req3, cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("bient supprimer");

            cnx.Close();
            charger_grid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_date.Value = txt_date.MinDate;
            
            txt_desc.Text = "";
            txt_hotel.Text = "";
            txt_trans.Text = "";
            txt_carb.Text = "";
            txt_repa.Text = "";
            txt_autr.Text = "";
            txt_total.Text = "";
            txtcontr.Text = "";

        }
        public void bindingsourse()
        {
            cnx.Open();
            string req2 = "select * from Memoire_frais ";
            cmd = new SqlCommand(req2, cnx);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            


            //dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            dr.Close();
            cnx.Close();


        }
        public void navigation()
        {
            txt_date.Text = ((DataRowView)bs.Current)[0].ToString();
            txt_desc.Text = ((DataRowView)bs.Current)[1].ToString();
            txt_hotel.Text = ((DataRowView)bs.Current)[2].ToString();
            txt_trans.Text = ((DataRowView)bs.Current)[3].ToString();
            txt_carb.Text = ((DataRowView)bs.Current)[4].ToString();
            txt_repa.Text = ((DataRowView)bs.Current)[5].ToString();
            txt_autr.Text = ((DataRowView)bs.Current)[6].ToString();
            txt_total.Text = ((DataRowView)bs.Current)[7].ToString();
            txtcontr.Text = ((DataRowView)bs.Current)[8].ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
            navigation();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
            navigation();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
            navigation();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
            navigation();
        }
        public void nbr_total_frais()
        {
            cnx.Open();
            string req = "select count(*) as nombre_total from Memoire_frais ";
            SqlCommand cmd = new SqlCommand(req, cnx);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string nombre_total = dr["nombre_total"].ToString();
                nbr_total.Text = nombre_total;

            }
            dr.Close();
            cnx.Close();
        }

        public void button5_Click(object sender, EventArgs e)
        {


            string req = "SELECT SUM(" +
             "Convert(decimal, '" + txt_hotel.Text + "') + " +
             "Convert(decimal, '" + txt_trans.Text + "') + " +
             "Convert(decimal, '" + txt_carb.Text + "') + " +
             "Convert(decimal, '" + txt_repa.Text + "') + " +
             "Convert(decimal, '" + txt_autr.Text + "')" +
             ") as somme_total FROM Memoire_frais";

            cnx.Open();
            SqlCommand cmd = new SqlCommand(req, cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string somme_total = dr["somme_total"].ToString();
                txt_total.Text = somme_total;
            }
            dr.Close();
            cnx.Close();
        }

        private void btn_Exporter_Click(object sender, EventArgs e)
        {
            
            
        }

        private void txt_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Rapport_d_activité : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-EBLKF75\SQLEXPRESS;Initial Catalog=notes de frais;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        BindingSource bs = new BindingSource();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        SqlCommand cmd;
        public Rapport_d_activité()
        {
            InitializeComponent();
        }

        private void Rapport_d_activité_Load(object sender, EventArgs e)
        {
            charger_grid();
            charger_combo();
            bindingsourse();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dataGridView1.Refresh();
            string req = "select*from Rapport_activité where Lieu_deplacement='"+comboBox1.Text+"' ";
            cnx.Open();
            cmd = new SqlCommand(req, cnx);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            ds.Clear();
            
            da.Fill(ds,"Rapport_activité");
            
            foreach (DataRow d in ds.Tables["Rapport_activité"].Rows)
            {
                dataGridView1.DataSource = ds.Tables["Rapport_activité"];
                textBox1.Text = d[2].ToString();
                dateTimePicker1.Text = d[0].ToString();
            }
            cnx.Close();

        }
        public void charger_grid()
        {
            //comboBox1.Refresh();

            dataGridView1.Refresh();
            string req = "select*from Rapport_activité ";
            cnx.Open();
            cmd = new SqlCommand(req,cnx);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds.Clear();
            //ds = new DataSet();
            da.Fill(ds,"Rapport_activité");
            foreach (DataRow d in ds.Tables["Rapport_activité"].Rows)
            {
                dataGridView1.DataSource = ds.Tables["Rapport_activité"];
            }
            cnx.Close();

        }
        public void charger_combo()
        {
            
            string req = "select Lieu_deplacement from Rapport_activité ";
            cnx.Open();
            SqlCommand cmd = new SqlCommand(req, cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cnx.Close();
        }
        public void navigation()
        {
            dateTimePicker1.Text = ((DataRowView)bs.Current)[0].ToString();
            comboBox1.Text = ((DataRowView)bs.Current)[1].ToString();
            textBox1.Text = ((DataRowView)bs.Current)[2].ToString();
        }
        public void bindingsourse()
        {
            cnx.Open();
            string req2 = "select * from Rapport_activité ";
            cmd = new SqlCommand(req2, cnx);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            dr.Close();
            cnx.Close();


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

        private void button1_Click(object sender, EventArgs e)
        {
            string req = "insert into Rapport_activité values('"+dateTimePicker1.Value+"','"+comboBox1.Text+"','"+textBox1.Text+"') ";
            cnx.Open();
            cmd = new SqlCommand(req,cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("bient ajouter");
            cnx.Close();
            charger_grid();
            vider();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dataGridView1.Refresh();

            string req = "update Rapport_activité set Date_depart='"+dateTimePicker1.Value+ "' ,Objet='" + textBox1.Text+ "' where Lieu_deplacement='"+comboBox1.Text+ "'    ";
            cnx.Open();
            cmd = new SqlCommand(req,cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("bient modifier");
            cnx.Close();
            charger_grid();
            vider();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView1.Refresh();

            string req = "delete from Rapport_activité where Lieu_deplacement='" + comboBox1.Text+"' ";
            cnx.Open();
            cmd = new SqlCommand(req,cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("bient supprimer");
            
            cnx.Close();
            charger_grid();

            vider();

        }
        public void vider()
        {
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vider();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Gestion_expertise
{
    public partial class main : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString;
        DataSet ds = new DataSet();
        BindingSource bsExp = new BindingSource();
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (string s in listBox1.Items)
            //    dataGridView1.Rows.Add(s.Split('\t'));

            //textBox2.Text = dataGridView1.Rows.Count.ToString();

        }

        private void main_Load(object sender, EventArgs e)
        {
            comboBox1.Focus();
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            string req = "select * from expertise";
            SqlCommand com = new SqlCommand(req, cn);

            SqlDataAdapter daExp = new SqlDataAdapter(com);

            if (ds.Tables["expertise"] != null)
                ds.Tables["expertise"].Clear();

            daExp.Fill(ds, "expertise");

            bsExp.DataSource = ds;
            bsExp.DataMember = "expertise";

            SqlCommandBuilder comB = new SqlCommandBuilder(daExp);


            comboBox1.DataSource = bsExp;
            comboBox1.DisplayMember = "NumExp";
            comboBox1.ValueMember = "NumExp";
            comboBox1.Text = "---Sélectionner une expertise--";
            mainpanel.Controls.Clear();
            ToutesExp TtExp = new ToutesExp();
            mainpanel.Controls.Add(TtExp);
            TtExp.Dock = DockStyle.Fill;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //List<string> l = new List<string>(textBox1.Text.Split('\n'));
            //foreach (string s in l)
            //{
            //    listBox1.Items.Add(s);
            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ajouter_expertise ex = new Ajouter_expertise();
            ex.Show();
        }

        

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            demandeur u = new demandeur(comboBox1.Text);
            mainpanel.Controls.Add(u);
            u.Dock = DockStyle.Fill;
        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            defendeur d = new defendeur(comboBox1.Text);
            mainpanel.Controls.Add(d);
            d.Dock = DockStyle.Fill;
        }

        
            

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                int index = comboBox1.FindString(comboBox1.Text);
                comboBox1.SelectedIndex = index;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            ToutesExp TtExp = new ToutesExp();
            mainpanel.Controls.Add(TtExp);
            TtExp.Dock = DockStyle.Fill;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            suivi_expertise suivi = new suivi_expertise();
            mainpanel.Controls.Add(suivi);
            suivi.Dock = DockStyle.Fill;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Clear();
            ToutesExp TtExp = new ToutesExp();
            mainpanel.Controls.Add(TtExp);
            TtExp.Dock = DockStyle.Fill;
        }
    }
}

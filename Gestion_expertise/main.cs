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
            comboBox1.DisplayMember = "RefCabinet";
            comboBox1.ValueMember = "NumExp";
            comboBox1.Text = "---Sélectionner une expertise--";
            mainpanel.Controls.Clear();
            ToutesExp TtExp = new ToutesExp();
            mainpanel.Controls.Add(TtExp);
            TtExp.Dock = DockStyle.Fill;

            Btn_Def.Enabled = false;
            Btn_Dem.Enabled = false;
            Btn_Document.Enabled = false;
            Btn_Suivi.Enabled = false;
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Ajouter_expertise ex = new Ajouter_expertise();
            ex.Show();
        }

        private void main_size_Changed(object sender, EventArgs e)
        {
            if (this.Width < 1200 && sizeup == true) 
            { 
                tableLayoutPanel1.ColumnStyles[1].Width = 3;
                change_Font(-2,this);
                sizeup = false;
                
            }
            if (this.Width > 1200 && sizeup == false)
            {
                tableLayoutPanel1.ColumnStyles[1].Width = 15;
                change_Font(2,this);
                sizeup = true;
                
            }    
                
        }
        bool sizeup = false;
        public void change_Font(int i,Control cntr)
        {
           foreach(Control cont in cntr.Controls)
            {
                if (cont.HasChildren )
                {
                    change_Font(i,cont);                    
                }
                else
                {
                    cont.Font = new Font(this.Font.Name, cont.Font.Size + i);                    
                }                    
            }
        }
        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Btn_Suivi_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                try
                {
                    mainpanel.Controls.Clear();
                    suivi_expertise suivi = new suivi_expertise(comboBox1.SelectedValue.ToString());
                    mainpanel.Controls.Add(suivi);
                    suivi.Dock = DockStyle.Fill;
                }
                catch (Exception ex) { }
            }
        }

        private void Btn_Dem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                try
                {
                    mainpanel.Controls.Clear();
                    demandeur u = new demandeur(comboBox1.SelectedValue.ToString());
                    mainpanel.Controls.Add(u);
                    u.Dock = DockStyle.Fill;
                }
                catch (Exception ex) { }
            }
        }

        private void Btn_Def_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                try
                {
                    mainpanel.Controls.Clear();
                    defendeur d = new defendeur(comboBox1.SelectedValue.ToString());
                    mainpanel.Controls.Add(d);
                    d.Dock = DockStyle.Fill;
                }
                catch (Exception ex) { }
            }
        }
        private void Btn_Document_Click(object sender, EventArgs e)
        {

            mainpanel.Controls.Clear();
            convocation_page conv = new convocation_page(comboBox1.SelectedValue.ToString());
            mainpanel.Controls.Add(conv);
            conv.Dock = DockStyle.Fill;
        }
        private void Btn_Mahakim_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Mahakim mahakim = new Mahakim();
            mainpanel.Controls.Add(mahakim);
            mahakim.Dock = DockStyle.Fill;
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                int index = comboBox1.FindString(comboBox1.Text);
                comboBox1.SelectedIndex = index;
            }
        }
        private void Btn_TtExp_Click(object sender, EventArgs e)
        {

            mainpanel.Controls.Clear();
            ToutesExp ttExp = new ToutesExp();
            mainpanel.Controls.Add(ttExp);
            ttExp.Dock = DockStyle.Fill;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            mainpanel.Controls.Clear();
            mainpanel.Controls.Clear();
            ToutesExp TtExp = new ToutesExp();
            mainpanel.Controls.Add(TtExp);
            TtExp.Dock = DockStyle.Fill;

            Btn_Def.Enabled = true;
            Btn_Dem.Enabled = true;
            Btn_Document.Enabled = true;
            Btn_Suivi.Enabled = true;
        }

       
    }
}

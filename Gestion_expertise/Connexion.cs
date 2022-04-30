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
    public partial class Connexion : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString;

        public Connexion()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select * from DernierSession ", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                txt_login.Text = dt.Rows[0][0].ToString();
                txt_password.Text = dt.Rows[0][1].ToString();
                keepit.Checked=true;
            }
            }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '*')
                txt_password.PasswordChar = '\0';
            else
                txt_password.PasswordChar = '*';
        }
        
        private void btn_login_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select * from Utilisateur where login = '" + txt_login.Text + "' and password = '" + txt_password.Text + "'", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                SqlCommand com1 = new SqlCommand(" delete from DernierSession ", con);
                com1.ExecuteNonQuery();
                if (keepit.Checked)
                {
                    SqlCommand com = new SqlCommand("insert into DernierSession values ('" + txt_login.Text + "','" + txt_password.Text.Trim() + "')",con);
                    com.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand com = new SqlCommand(" delete from DernierSession ", con);
                    com.ExecuteNonQuery();
                }
                this.Hide();
                main m1 = new main();
                m1.Show();
                
              


            }
            else
                MessageBox.Show("not ok", "not ok");

        }

        private void keepit_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}

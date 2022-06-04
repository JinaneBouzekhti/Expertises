using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Gestion_expertise
{
    public partial class Clé : Form
    {
        public Clé()
        {
            InitializeComponent();
        }

        private void btn_pass_Click(object sender, EventArgs e)
        {

            string cs = ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            SqlDataAdapter sa1 = new SqlDataAdapter("select clé from plus ", cn);
            DataTable dt1 = new DataTable();
            sa1.Fill(dt1);

            label_cle.Visible = false;
            label_val.Visible = false;
            label_vide.Visible = false;
            if (txt_cle.Texts != "" && txt_new.Texts != "" && txt_valid.Texts != "")
            {
                if (txt_cle.Texts == dt1.Rows[0][0].ToString())
                {
                    if (txt_new.Texts == txt_valid.Texts)
                    {
                        SqlCommand com = new SqlCommand("update plus set clé = '" + txt_new.Texts+ "'" , cn);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Le clé de sécurité a été changé avec succès");
                        cn.Close();
                    }
                    else
                        label_val.Visible = true;
                }
                else
                    label_cle.Visible = true;
            }
            else
                label_vide.Visible = true;
        }
    }
}

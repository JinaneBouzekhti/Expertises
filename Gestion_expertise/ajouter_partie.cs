using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_expertise
{
    public partial class ajouter_partie : Form
    {
        public ajouter_partie(string numexp)
        {
            this.numexp = numexp;
            InitializeComponent();
        }
        string numexp;
        private void ajouter_partie_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_traiter_Click(object sender, EventArgs e)
        {
            List<string> lf = new List<string>();
            List<string> l = new List<string>(txt_copier.Text.Split('\n'));
            foreach (string s in l)
            {
                string sentence = s.Replace('\t', ' ').Trim();
                if (sentence != "") ;
                if (sentence.Contains("مدعى عليه"))
                    dgv_def.Rows.Add("مدعى عليه", s.Contains("(1)") ? s.Replace("مدعى عليه", "").Replace("(1)", "").Replace("المحامون", "").Trim() : s.Replace("مدعى عليه", "").Trim());

                else
                    dgv_dem.Rows.Add("مدعي", s.Contains("(1)") ? s.Replace("مدعي", "").Replace("(1)", "").Replace("المحامون", "").Trim() : s.Replace("مدعي", "").Trim());
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString);
            con.Open();
            if (ch_def.Checked)
                for (int i = 0; i < dgv_def.RowCount; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into Défenseur(NomCompletDéf,NumExp) values(N'" + dgv_def.Rows[i].Cells[1].Value + "','" + Convert.ToInt32(numexp) + "')", con);
                    cmd.ExecuteNonQuery();
                }
            if (ch_dem.Checked)
                for (int i = 0; i < dgv_dem.RowCount; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into Demandeur(NomCompletDem,NumExp) values(N'" + dgv_dem.Rows[i].Cells[1].Value + "','" + Convert.ToInt32(numexp) + "')", con);
                    cmd.ExecuteNonQuery();
                }
            this.Close();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

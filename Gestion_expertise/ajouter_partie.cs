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
        public ajouter_partie(string RefCabinet)
        {
            this.RefCabinet = RefCabinet;
            InitializeComponent();
        }
        string RefCabinet;
      

        private void btn_traiter_Click(object sender, EventArgs e)
        {
            List<string> lf = new List<string>();
            List<string> l = new List<string>(txt_copier.Text.Split('\n'));
            foreach (string s in l)
            {
                string sentence = s.Replace('\t', ' ').Trim();
                string nom = s.Contains("(1)") ? s.Replace("مدعى عليه", "").Replace("(1)", "").Replace("مدعي", "").Replace("المحامون", "").Trim() : s.Replace("مدعى عليه", "").Trim();
                if (sentence != "" && nom !="")
                if (sentence.Contains("مدعى عليه"))
                    dgv_def.Rows.Add("مدعى عليه", nom);

                else
                    dgv_dem.Rows.Add("مدعي",nom);
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString);
            con.Open();
            if (ch_def.Checked)
                for (int i = 0; i < dgv_def.RowCount; i++)
                {
                    
                        SqlCommand cmd = new SqlCommand("insert into Défenseur(NomCompletDéf,RefCabinet) values(N'" + dgv_def.Rows[i].Cells[1].Value + "','" + Convert.ToInt32(RefCabinet) + "')", con);
                        cmd.ExecuteNonQuery();
                    
                }
            if (ch_dem.Checked)
                for (int i = 0; i < dgv_dem.RowCount; i++)
                {                   
                        SqlCommand cmd = new SqlCommand("insert into Demandeur(NomCompletDem,RefCabinet) values(N'" + dgv_dem.Rows[i].Cells[1].Value + "','" + Convert.ToInt32(RefCabinet) + "')", con);
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

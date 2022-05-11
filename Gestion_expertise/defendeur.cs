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
    public partial class defendeur : UserControl
    {
        public defendeur(string numexp)
        {
            InitializeComponent();
            this.numexp = numexp;
        }
        string numexp;
        private void defendeur_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString);
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select * from Défenseur where NumExp like '" + numexp + "'", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
                dataGridView1.Rows.Add(dt.Rows[i][1], dt.Rows[i][3], dt.Rows[i][2], dt.Rows[i][4]);
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            ajouter_partie ap = new ajouter_partie(numexp);
            ap.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString);

            con.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++) 
            {
                SqlCommand cmd = new SqlCommand("UPDATE Défenseur SET  Adresse= N'" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "' , Portable = '" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "'Where  NomCompletDéf = N'" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "'", con);
                cmd.ExecuteNonQuery();                
            }
            MessageBox.Show("les modification est enregistré avec succès");
        }
    }
}

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
    public partial class ToutesExp : UserControl
    {
        public ToutesExp()
        {
            InitializeComponent();
        }

        private void ToutesExp_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString);
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select * from expertise", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
                dataGridView1.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8],dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11], dt.Rows[i][12]);
        }
    }
}

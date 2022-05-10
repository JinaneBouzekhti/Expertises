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
    public partial class convocation_page : UserControl
    {
        public convocation_page(string numexp)
        {
            InitializeComponent();
            this.numexp = numexp;
        }

        string numexp;
          
        private void convocation_page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString);
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select * from Défenseur where NumExp like '" + numexp + "'", con);
            SqlDataAdapter sa2 = new SqlDataAdapter("select * from Demandeur where NumExp like '" + numexp + "'", con);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            sa.Fill(dt);
            sa2.Fill(dt2);
            
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt2;
        }
    }
}

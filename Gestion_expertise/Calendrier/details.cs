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

namespace Gestion_expertise.Calandrier
{
    public partial class details : Form
    {
        public details(string date)
        {
            InitializeComponent();
            _date = date;
        }
        string _date;
        private void details_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString);
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("Select RefCabinet , HeureRvPart from Expertise where DateRvPart like '" + _date + "'", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
                listdetails.Items.Add("Expertise " + dt.Rows[i][0] + ": R-V à " + dt.Rows[i][1]);

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

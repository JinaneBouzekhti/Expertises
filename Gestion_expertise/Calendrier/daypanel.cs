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
    public partial class daypanel : UserControl
    {
        public daypanel()
        {
            InitializeComponent();
        }
        public void daynum(int day)
        {
            numdaylab.Text = day.ToString("00");
        }
        string date;
        public void getactivite(int year, int month, int day)
        {
            DateTime thisday = new DateTime(year, month, day);
            date = thisday.ToString("yyyy-MM-dd");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString);
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("Select RefCabinet , HeureRvPart from Expertise where DateRvPart like '" + date + "'", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            int rows = dt.Rows.Count;
            if (dt.Rows.Count > 4)
                rows = 4;
            if (dt.Rows.Count != 0)
            {

                for (int i = 1; i <= rows; i++)
                {
                    foreach (Control c in this.Controls)
                        if (c.Name.StartsWith("label" + (5 - i)))
                        {
                            c.Text = "Expertise " + dt.Rows[i - 1][0] + ": R-V à " + dt.Rows[i - 1][1];
                        }

                }
            }
        }
     

        private void numdaylab_Click(object sender, EventArgs e)
        {
            details d = new details(date);
            d.ShowDialog();
        }
    }
}

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
    public partial class FolderView : UserControl
    {
        public FolderView()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void FolderView_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString);
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select * from expertise", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            
            if (dt.Rows.Count != 0)
            {
                string chemin =dt.Rows[0][17].ToString();
                chemin = chemin.Replace("\\"+chemin.Split('\\').Last(),"");
                webBrowser1.Url=new Uri(chemin);
            }
        }
    }
}

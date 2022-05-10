using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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

        private void btn_exporter_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString);
            cn.Open();

            
            string req = "select NomTribunalP, RefRéféré, DateDésignation, NomMagistrat, DateRvPart, HeureRvPart, NomCompletDem , D.Adresse from TribunauxPremière T inner join Expertise E on T.NumTribunalP = E.NumTribunalP inner join Demandeur D on D.NumExp = E.NumExp  where D.NumExp  like " +numexp;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataAdapter daCA = new SqlDataAdapter(com);
            DataTable data = new DataTable();
            daCA.Fill(data);

            convocation C = new convocation();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                C.SetParameterValue("nomTribunal", data.Rows[i][0]);
                C.SetParameterValue("refe_referer", data.Rows[i][1]);
                C.SetParameterValue("date_Designation", data.Rows[i][2]);
                C.SetParameterValue("juje", data.Rows[i][3]);
                C.SetParameterValue("date_rendez_vous", Convert.ToDateTime(data.Rows[i][4]).ToString("dddd dd MMMM yyyy ", new CultureInfo("ar-AE")));
                C.SetParameterValue("heur_rendez_vous", data.Rows[i][5]);
                C.SetParameterValue("nom complet", data.Rows[i][6]);
                C.SetParameterValue("adresse", data.Rows[i][7] is null ? " " : data.Rows[i][7]);
                C.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"C:\Users\Badreddine\Desktop\test\" + data.Rows[i][6] + ".pdf");
            }

        }
    }
}

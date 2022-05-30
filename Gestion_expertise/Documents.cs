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
using System.IO;

namespace Gestion_expertise
{
    public partial class Documents : UserControl
    {
        string sc = ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString;

        public Documents(string RefCabinet)
        {
            InitializeComponent();
            this.RefCabinet = RefCabinet;
        }

        string RefCabinet;
          
        private void convocation_page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sc);
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select * from Défenseur where RefCabinet like '" + RefCabinet + "'", con);
            SqlDataAdapter sa2 = new SqlDataAdapter("select * from Demandeur where RefCabinet like '" + RefCabinet + "'", con);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            sa.Fill(dt);
            sa2.Fill(dt2);

            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt2;
        }

        private void btn_exporter_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(sc);
            cn.Open();

            string req = "select NomTribunalP, RefRéféré, DateDésignation, NomMagistrat, DateRvPart, HeureRvPart, NomCompletDem As NomComplet, D.Adresse, RépertoireDoc from TribunauxPremière T inner join Expertise E on T.NumTribunalP = E.NumTribunalP inner join Demandeur D on D.RefCabinet = E.RefCabinet  where E.RefCabinet like " + RefCabinet + " union select NomTribunalP, RefRéféré, DateDésignation, NomMagistrat, DateRvPart, HeureRvPart, NomCompletDéf As NomComplet , D.Adresse,RépertoireDoc from TribunauxPremière T inner join Expertise E on T.NumTribunalP = E.NumTribunalP inner join Défenseur D on D.RefCabinet = E.RefCabinet  where E.RefCabinet like " + RefCabinet;
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
                string period="";
                if (Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) >= 9 || Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) < 12 )
                    period = "صباحا";
                if (Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) >= 12 || Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) < 14)
                    period = "زوالا";
                if (Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) >= 14 || Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) < 16)
                    period = "بعد الزوال";
                if (Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) >= 16 || Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) < 18)
                    period = "مساءا";
                C.SetParameterValue("period", period.ToString());
                C.SetParameterValue("heur_rendez_vous", data.Rows[i][5]);
                C.SetParameterValue("nom complet", data.Rows[i][6]);
                C.SetParameterValue("adresse", data.Rows[i][7]);

                string Chemin = data.Rows[i][8].ToString() + @"\" + "الاستدعاءات" + @"\";
                DirectoryInfo Dir = new DirectoryInfo(Chemin);
                if (!Dir.Exists)
                    Dir.Create();

                C.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Chemin + data.Rows[i][6] + ".pdf");
            }
        }

        private void btn_recu_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(sc);
            cn.Open();

            string req = "select NomTribunalP, RefRéféré, DateDésignation, NomMagistrat, DateRvPart, HeureRvPart, NomCompletDem As NomComplet, D.Adresse, RépertoireDoc from TribunauxPremière T inner join Expertise E on T.NumTribunalP = E.NumTribunalP inner join Demandeur D on D.RefCabinet = E.RefCabinet  where E.RefCabinet like " + RefCabinet + " union select NomTribunalP, RefRéféré, DateDésignation, NomMagistrat, DateRvPart, HeureRvPart, NomCompletDéf As NomComplet , D.Adresse,RépertoireDoc from TribunauxPremière T inner join Expertise E on T.NumTribunalP = E.NumTribunalP inner join Défenseur D on D.RefCabinet = E.RefCabinet  where E.RefCabinet like " + RefCabinet;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataAdapter daCA = new SqlDataAdapter(com);
            DataTable data = new DataTable();
            daCA.Fill(data);

            reçu C = new reçu();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                C.SetParameterValue("nomTribunal", data.Rows[i][0]);
                C.SetParameterValue("refe_referer", data.Rows[i][1]);
                C.SetParameterValue("date_Designation", data.Rows[i][2]);
                C.SetParameterValue("juje", data.Rows[i][3]);
                C.SetParameterValue("date_rendez_vous", Convert.ToDateTime(data.Rows[i][4]).ToString("dddd dd MMMM yyyy ", new CultureInfo("ar-AE")));
                C.SetParameterValue("heur_rendez_vous", data.Rows[i][5]);
                string period = "";
                if (Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) >= 9 || Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) < 12)
                    period = "صباحا";
                if (Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) >= 12 || Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) < 14)
                    period = "زوالا";
                if (Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) >= 14 || Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) < 16)
                    period = "بعد الزوال";
                if (Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) >= 16 || Convert.ToInt32(data.Rows[i][5].ToString().Substring(0, 2)) < 18)
                    period = "مساءا";
                C.SetParameterValue("period", period.ToString());
                C.SetParameterValue("nom complet", data.Rows[i][6]);
                C.SetParameterValue("adresse", data.Rows[i][7]);

                string Chemin = data.Rows[i][8].ToString() + @"\" + "التسليمات" + @"\";
                DirectoryInfo Dir = new DirectoryInfo(Chemin);
                if (!Dir.Exists)
                    Dir.Create();
                C.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Chemin + data.Rows[i][6] + ".pdf");
            }


        }
    }
}

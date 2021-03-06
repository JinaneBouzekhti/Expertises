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
            {

                if (Convert.ToInt32(dt.Rows[i][19]) == 0)
                {

                    SqlDataAdapter sa1 = new SqlDataAdapter("select NomTribunalP from TribunauxPremière where NumTribunalP =" + dt.Rows[i][2], con);
                    DataTable dt1 = new DataTable();
                    sa1.Fill(dt1);
                    string nomTr;
                    nomTr = dt1.Rows[0][0].ToString();


                    SqlDataAdapter sa2 = new SqlDataAdapter("select typeExp from TypeExp where NumTypeExp =" + dt.Rows[i][13], con);
                    DataTable dt2 = new DataTable();
                    sa2.Fill(dt2);
                    string nomType;
                    nomType = dt2.Rows[0][0].ToString();



                    SqlDataAdapter sa3 = new SqlDataAdapter("select statut from Statut where NumStatut =" + dt.Rows[i][18], con);
                    DataTable dt3 = new DataTable();
                    sa3.Fill(dt3);
                    string nomStt;
                    nomStt = dt3.Rows[0][0].ToString();

                    dataGridView1.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], nomTr, dt.Rows[i][3], dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], Convert.ToDateTime(dt.Rows[i][7]).ToShortDateString(), Convert.ToDateTime(dt.Rows[i][8]).ToShortDateString(), Convert.ToDateTime(dt.Rows[i][9]).ToShortDateString(), Convert.ToDateTime(dt.Rows[i][10]).ToShortDateString(), dt.Rows[i][11], dt.Rows[i][12], nomType, Convert.ToDateTime(dt.Rows[i][14]).ToShortDateString(), Convert.ToDateTime(dt.Rows[i][15]).ToShortDateString(), dt.Rows[i][16], dt.Rows[i][17], nomStt);

                    if (Convert.ToDateTime(dt.Rows[i][10]).AddDays(30).AddDays(-7) <= DateTime.Now)
                    {

                        for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                        {
                            if (Convert.ToInt32(dataGridView1.Rows[j].Cells[0].Value) == Convert.ToInt32(dt.Rows[i][0]))
                            {
                                dataGridView1.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(244, 72, 29);
                                dataGridView1.Rows[j].DefaultCellStyle.ForeColor = Color.White;
                            }
                        }
                    }

                }
                else
                {
                    

                    SqlDataAdapter sa1 = new SqlDataAdapter("select NomTribunalP from TribunauxPremière where NumTribunalP =" + dt.Rows[i][2], con);
                    DataTable dt1 = new DataTable();
                    sa1.Fill(dt1);
                    string nomTr;
                    nomTr = dt1.Rows[0][0].ToString();


                    SqlDataAdapter sa2 = new SqlDataAdapter("select typeExp from TypeExp where NumTypeExp =" + dt.Rows[i][13], con);
                    DataTable dt2 = new DataTable();
                    sa2.Fill(dt2);
                    string nomType;
                    nomType = dt2.Rows[0][0].ToString();



                    SqlDataAdapter sa3 = new SqlDataAdapter("select statut from Statut where NumStatut =" + dt.Rows[i][18], con);
                    DataTable dt3 = new DataTable();
                    sa3.Fill(dt3);
                    string nomStt;
                    nomStt = dt3.Rows[0][0].ToString();

                    dataGridView2.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], nomTr, dt.Rows[i][3], dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], Convert.ToDateTime(dt.Rows[i][7]).ToShortDateString(), Convert.ToDateTime(dt.Rows[i][8]).ToShortDateString(), Convert.ToDateTime(dt.Rows[i][9]).ToShortDateString(), Convert.ToDateTime(dt.Rows[i][10]).ToShortDateString(), dt.Rows[i][11], dt.Rows[i][12], nomType, Convert.ToDateTime(dt.Rows[i][14]).ToShortDateString(), Convert.ToDateTime(dt.Rows[i][15]).ToShortDateString(), dt.Rows[i][16], dt.Rows[i][17], nomStt);

                }
            }
        }

      
    }
}

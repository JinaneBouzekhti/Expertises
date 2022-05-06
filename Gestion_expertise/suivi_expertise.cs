using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls.RJControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
namespace Gestion_expertise
{
    public partial class suivi_expertise : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString;
        DataSet ds = new DataSet();

        BindingSource bsCA = new BindingSource();
        BindingSource bsTr = new BindingSource();
        BindingSource bsTypeExp = new BindingSource();
        BindingSource bsStt = new BindingSource();

        SqlCommand com;
        SqlCommandBuilder comB;

        SqlDataAdapter daCA;
        SqlDataAdapter daTr;
        SqlDataAdapter daTypeExp;
        SqlDataAdapter daStt;

        OpenFileDialog ofd = new OpenFileDialog();
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public suivi_expertise(string numexp)
        {
            InitializeComponent();
            this.numexp = numexp;
        }
        string numexp;
        private void suivi_expertise_Load(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            string req2 = "select* from TypeExp";
            com = new SqlCommand(req2, cn);
            daTypeExp = new SqlDataAdapter(com);
            if (ds.Tables["TypeExp"] != null)
                ds.Tables["TypeExp"].Clear();

            daTypeExp.Fill(ds, "TypeExp");

            bsTypeExp.DataSource = ds;
            bsTypeExp.DataMember = "TypeExp";

            comB = new SqlCommandBuilder(daTypeExp);

            cmb_type_exp.DataSource = bsTypeExp;
            cmb_type_exp.DisplayMember = "typeExp";
            cmb_type_exp.ValueMember = "NumTypeExp";

            com = null;
            comB = null;


            string req = "select* from CoursAppel";
            com = new SqlCommand(req, cn);
            daCA = new SqlDataAdapter(com);

            if (ds.Tables["CoursAppel"] != null)
                ds.Tables["CoursAppel"].Clear();

            daCA.Fill(ds, "CoursAppel");
            bsCA.DataSource = ds;
            bsCA.DataMember = "CoursAppel";

            comB = new SqlCommandBuilder(daCA);

            cmb_CoursA.DataSource = bsCA;
            cmb_CoursA.DisplayMember = "NomCoursAppel";
            cmb_CoursA.ValueMember = "NumCoursAppel";

            com = null;
            comB = null;


            string req3 = "select* from Statut";
            com = new SqlCommand(req3, cn);
            daStt = new SqlDataAdapter(com);
            if (ds.Tables["Statut"] != null)
                ds.Tables["Statut"].Clear();

            daStt.Fill(ds, "Statut");

            bsStt.DataSource = ds;
            bsStt.DataMember = "Statut";

            comB = new SqlCommandBuilder(daStt);

            cmb_stat.DataSource = bsStt;
            cmb_stat.DisplayMember = "statut";
            cmb_stat.ValueMember = "NumStatut";
            com = null;
            comB = null;

            SqlDataAdapter sa = new SqlDataAdapter("select * from expertise where NumExp like '" + numexp + "'", cn);
            DataTable dt = new DataTable();
            sa.Fill(dt);


            txt_ref_cab.Texts = dt.Rows[0][1].ToString();
            txt_ref_ref.Texts = dt.Rows[0][2].ToString();

            SqlDataAdapter sa1 = new SqlDataAdapter("select * from TribunauxPremière where NumTribunalP =" + dt.Rows[0][3], cn);
            DataTable dt1 = new DataTable();
            sa1.Fill(dt1);
            cmb_trib_pr.Text = dt1.Rows[0][1].ToString();

            SqlDataAdapter sa2 = new SqlDataAdapter("select * from  CoursAppel  where NumCoursAppel =" + dt1.Rows[0][2], cn);
            DataTable dt2 = new DataTable();
            sa2.Fill(dt2);
            cmb_CoursA.Text = dt2.Rows[0][1].ToString();


            txt_magi.Texts = dt.Rows[0][4].ToString();
            txt_jug.Texts = dt.Rows[0][5].ToString();
            txt_gre.Texts = dt.Rows[0][6].ToString();
            txt_type_dec.Texts = dt.Rows[0][7].ToString();

            date_decision.Text = dt.Rows[0][8].ToString();
            date_desi.Text = dt.Rows[0][9].ToString();
            date_acc.Text = dt.Rows[0][10].ToString();
            date_consi.Text = dt.Rows[0][11].ToString();

            txt_lieu.Texts = dt.Rows[0][13].ToString();

            SqlDataAdapter sa3 = new SqlDataAdapter("select * from TypeExp  where NumTypeExp =" + dt.Rows[0][14], cn);
            DataTable dt3 = new DataTable();
            sa3.Fill(dt3);
            cmb_type_exp.Text = dt3.Rows[0][1].ToString();

            date_conv.Text = dt.Rows[0][15].ToString();
            date_rend.Text = dt.Rows[0][16].ToString();


            txt_hor.Texts = dt.Rows[0][17].ToString();
            txt_rep.Texts = dt.Rows[0][18].ToString();

            SqlDataAdapter sa4 = new SqlDataAdapter("select * from Statut  where NumStatut =" + dt.Rows[0][19], cn);
            DataTable dt4 = new DataTable();
            sa4.Fill(dt4);
            cmb_stat.Text = dt4.Rows[0][1].ToString();

            txt_montan.Texts = dt.Rows[0][12].ToString();

            if (Convert.ToInt32(dt.Rows[0][20]) == 1)
            {
                cb_termine.Checked = true;
            }

        }

        private void cmb_CoursA_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_CoursA.SelectedIndex > -1)
            {
                try
                {
                    SqlConnection cn = new SqlConnection(cs);
                    cn.Open();
                    int NumCA = Convert.ToInt32(cmb_CoursA.SelectedValue);
                    string req1 = "select * from TribunauxPremière where NumCoursAppel =" + NumCA;
                    com = new SqlCommand(req1, cn);
                    daTr = new SqlDataAdapter(com);

                    if (ds.Tables["TribunalP"] != null)
                        ds.Tables["Tribunalp"].Clear();

                    daTr.Fill(ds, "TribunalP");
                    bsTr.DataSource = ds;
                    bsTr.DataMember = "TribunalP";

                    comB = new SqlCommandBuilder(daTr);

                    cmb_trib_pr.DataSource = bsTr;
                    cmb_trib_pr.DisplayMember = "NomTribunalP";
                    cmb_trib_pr.ValueMember = "NumTribunalP";

                    com = null;
                    comB = null;
                }
                catch (Exception ex) { }
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            RJTextBox tb = null;
            if (sender is RJTextBox)
            {
                tb = (RJTextBox)sender;
                tb.UnderlinedStyle = true;
            }
     
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            RJTextBox tb = null;
            if (sender is RJTextBox)
            {
                tb = (RJTextBox)sender;
                tb.UnderlinedStyle = false;
            }
        }

        private void cmb_CoursA_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmb_trib_pr_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmb_stat_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmb_type_exp_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        public string GetFolderName()
        {
            int NumExp = 0;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select NumExp from expertise", cn);
            DataTable dt = new DataTable();
            sa.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NumExp = Convert.ToInt32(dt.Rows.Count);
            }
            string NameF;
            NumExp += 1;
            string date = DateTime.Now.ToString("yyyy");
            string ext = Path.GetExtension(ofd.FileName);
            NameF = "Expertise" + "-" + NumExp + "-" + date + ext;
            return NameF;
        }

        private void btn_Rep_Click(object sender, EventArgs e)
        {

            fbd.ShowDialog();
            txt_rep.Texts = fbd.SelectedPath.ToString() + @"\";
        }

    
        public void Activate(Boolean v)
        {
            txt_ref_cab.Enabled = v;
            txt_ref_ref.Enabled = v;
            cmb_CoursA.Enabled = v;
            cmb_trib_pr.Enabled = v;
            txt_magi.Enabled = v;
            txt_jug.Enabled = v;
            txt_gre.Enabled = v;
            txt_type_dec.Enabled = v;
            date_decision.Enabled = v;
            date_desi.Enabled = v;
            date_acc.Enabled = v;
            date_consi.Enabled = v;
            txt_lieu.Enabled = v;
            cmb_type_exp.Enabled = v;
            date_conv.Enabled = v;
            date_rend.Enabled = v;
            txt_hor.Enabled = v;
            cmb_stat.Enabled = v;
            txt_montan.Enabled = v;
            cb_termine.Enabled = v;
            btn_Rep.Enabled = v;
            btn_valider.Visible = v;
            btn_annuler.Visible = v;
            btn_modifier.Visible = !v;
            btn_suprimmer.Visible = !v;
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            Activate(true);
        }
      
       
        private void btn_valider_Click(object sender, EventArgs e)
        {
            bool tr = false;
            if (cb_termine.Checked)
                tr = true;

            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            string rqt = " update expertise set RefCabinet =@RefCabinet , RefRéféré =@RefRéféré,NumTribunalP=@NumTribunalP,NomMagistrat=@NomMagistrat,NomJugeControleur=@NomJugeControleur,NomGreffier=@NomGreffier,TypeDécision=@TypeDécision,DateDécision=@DateDécision,DateDésignation=@DateDésignation,DateAcceptation=@DateAcceptation,DateConsignation=@DateConsignation,MontantConsignation=@MontantConsignation,LieuExp=@LieuExp,NumTypeExp=@NumTypeExp,DateConvPart=@DateConvPart,DateRvPart=@DateRvPart,HeureRvPart=@HeureRvPart,RépertoireDoc=@RépertoireDoc,NumStatut=@NumStatut,Terminé=@Terminer where NumExp like '" + numexp + "'";
            SqlCommand com = new SqlCommand(rqt, cn);

            com.Parameters.Add(new SqlParameter("@RefCabinet", Convert.ToInt32(txt_ref_cab.Texts)));
            com.Parameters.Add(new SqlParameter("@RefRéféré", txt_ref_ref.Texts));
            com.Parameters.Add(new SqlParameter("@NumTribunalP", Convert.ToInt32(cmb_trib_pr.SelectedValue)));
            com.Parameters.Add(new SqlParameter("@NomMagistrat", txt_magi.Texts));
            com.Parameters.Add(new SqlParameter("@NomJugeControleur", txt_jug.Texts));
            com.Parameters.Add(new SqlParameter("@NomGreffier", txt_gre.Texts));
            com.Parameters.Add(new SqlParameter("@TypeDécision", txt_type_dec.Texts));
            com.Parameters.Add(new SqlParameter("@DateDécision", Convert.ToDateTime(date_decision.Text)));
            com.Parameters.Add(new SqlParameter("@DateDésignation", Convert.ToDateTime(date_desi.Text)));
            com.Parameters.Add(new SqlParameter("@DateAcceptation", Convert.ToDateTime(date_acc.Text)));
            com.Parameters.Add(new SqlParameter("@DateConsignation", Convert.ToDateTime(date_consi.Text)));
            com.Parameters.Add(new SqlParameter("@MontantConsignation", txt_montan.Texts));
            com.Parameters.Add(new SqlParameter("@LieuExp", txt_lieu.Texts));
            com.Parameters.Add(new SqlParameter("@NumTypeExp", Convert.ToInt32(cmb_type_exp.SelectedValue)));
            com.Parameters.Add(new SqlParameter("@DateConvPart", Convert.ToDateTime(date_conv.Text)));
            com.Parameters.Add(new SqlParameter("@DateRvPart", Convert.ToDateTime(date_rend.Text)));
            com.Parameters.Add(new SqlParameter("@HeureRvPart", txt_hor.Texts));
            com.Parameters.Add(new SqlParameter("@RépertoireDoc", txt_rep.Texts));
            com.Parameters.Add(new SqlParameter("@NumStatut", Convert.ToInt32(cmb_stat.SelectedValue)));
            com.Parameters.Add(new SqlParameter("@Terminer", tr));


            string rqtUnq = "select RefCabinet from expertise where NumExp !=" + numexp;
            SqlCommand com1 = new SqlCommand(rqtUnq, cn);
            bool Unq = false;
            SqlDataReader dr = com1.ExecuteReader();


            while (dr.Read())
            {
                if (Convert.ToInt32(txt_ref_cab.Texts) == Convert.ToInt32(dr[0]))
                {
                    Unq = true;
                    break;
                }

            }
            dr.Close();
            dr = null;
            com1 = null;

            if (!Unq)
            {
                string Chemin = txt_rep.Text + GetFolderName();
                DirectoryInfo Dir = new DirectoryInfo(Chemin);
                Dir.Create();
                com.ExecuteNonQuery();
                Activate(false);
            }
            else
            {
                MessageBox.Show("Cette expertise existe déja", "Ereur");
            }

            com = null;
            cn.Close();
            cn = null;
        }


        private void btn_annuler_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            string req2 = "select* from TypeExp";
            com = new SqlCommand(req2, cn);
            daTypeExp = new SqlDataAdapter(com);
            if (ds.Tables["TypeExp"] != null)
                ds.Tables["TypeExp"].Clear();

            daTypeExp.Fill(ds, "TypeExp");

            bsTypeExp.DataSource = ds;
            bsTypeExp.DataMember = "TypeExp";

            comB = new SqlCommandBuilder(daTypeExp);

            cmb_type_exp.DataSource = bsTypeExp;
            cmb_type_exp.DisplayMember = "typeExp";
            cmb_type_exp.ValueMember = "NumTypeExp";

            com = null;
            comB = null;


            string req = "select* from CoursAppel";
            com = new SqlCommand(req, cn);
            daCA = new SqlDataAdapter(com);

            if (ds.Tables["CoursAppel"] != null)
                ds.Tables["CoursAppel"].Clear();

            daCA.Fill(ds, "CoursAppel");
            bsCA.DataSource = ds;
            bsCA.DataMember = "CoursAppel";

            comB = new SqlCommandBuilder(daCA);

            cmb_CoursA.DataSource = bsCA;
            cmb_CoursA.DisplayMember = "NomCoursAppel";
            cmb_CoursA.ValueMember = "NumCoursAppel";

            com = null;
            comB = null;


            string req3 = "select* from Statut";
            com = new SqlCommand(req3, cn);
            daStt = new SqlDataAdapter(com);
            if (ds.Tables["Statut"] != null)
                ds.Tables["Statut"].Clear();

            daStt.Fill(ds, "Statut");

            bsStt.DataSource = ds;
            bsStt.DataMember = "Statut";

            comB = new SqlCommandBuilder(daStt);

            cmb_stat.DataSource = bsStt;
            cmb_stat.DisplayMember = "statut";
            cmb_stat.ValueMember = "NumStatut";
            com = null;
            comB = null;

            SqlDataAdapter sa = new SqlDataAdapter("select * from expertise where NumExp like '" + numexp + "'", cn);
            DataTable dt = new DataTable();
            sa.Fill(dt);


            txt_ref_cab.Texts = dt.Rows[0][1].ToString();
            txt_ref_ref.Texts = dt.Rows[0][2].ToString();

            SqlDataAdapter sa1 = new SqlDataAdapter("select * from TribunauxPremière where NumTribunalP =" + dt.Rows[0][3], cn);
            DataTable dt1 = new DataTable();
            sa1.Fill(dt1);
            cmb_trib_pr.Text = dt1.Rows[0][1].ToString();

            SqlDataAdapter sa2 = new SqlDataAdapter("select * from  CoursAppel  where NumCoursAppel =" + dt1.Rows[0][2], cn);
            DataTable dt2 = new DataTable();
            sa2.Fill(dt2);
            cmb_CoursA.Text = dt2.Rows[0][1].ToString();


            txt_magi.Texts = dt.Rows[0][4].ToString();
            txt_jug.Texts = dt.Rows[0][5].ToString();
            txt_gre.Texts = dt.Rows[0][6].ToString();
            txt_type_dec.Texts = dt.Rows[0][7].ToString();

            date_decision.Text = dt.Rows[0][8].ToString();
            date_desi.Text = dt.Rows[0][9].ToString();
            date_acc.Text = dt.Rows[0][10].ToString();
            date_consi.Text = dt.Rows[0][11].ToString();

            txt_lieu.Texts = dt.Rows[0][13].ToString();

            SqlDataAdapter sa3 = new SqlDataAdapter("select * from TypeExp  where NumTypeExp =" + dt.Rows[0][14], cn);
            DataTable dt3 = new DataTable();
            sa3.Fill(dt3);
            cmb_type_exp.Text = dt3.Rows[0][1].ToString();

            date_conv.Text = dt.Rows[0][15].ToString();
            date_rend.Text = dt.Rows[0][16].ToString();


            txt_hor.Texts = dt.Rows[0][17].ToString();
            txt_rep.Texts = dt.Rows[0][18].ToString();

            SqlDataAdapter sa4 = new SqlDataAdapter("select * from Statut  where NumStatut =" + dt.Rows[0][19], cn);
            DataTable dt4 = new DataTable();
            sa4.Fill(dt4);
            cmb_stat.Text = dt4.Rows[0][1].ToString();

            txt_montan.Texts = dt.Rows[0][12].ToString();

            if (Convert.ToInt32(dt.Rows[0][20]) == 1)
            {
                cb_termine.Checked = true;
            }
            Activate(false);
        }
        private void btn_suprimmer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûre de cette supression !!", "Supression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                string rqt = "delete from expertise where NumExp like '" + numexp + "'";
                SqlCommand com = new SqlCommand(rqt, cn);
                com.ExecuteNonQuery();
                this.Controls.Clear();
                ToutesExp uc = null;
                uc = new ToutesExp();
                this.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;

            }

        }
    }
}

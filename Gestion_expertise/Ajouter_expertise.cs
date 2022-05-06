using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Gestion_expertise
{
    public partial class Ajouter_expertise : Form
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
        public Ajouter_expertise()
        {
            InitializeComponent();
        }

        private void Ajouter_expertise_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            //Remplisage comboBox CoursA:
            string req = "select* from CoursAppel";
            com = new SqlCommand(req, cn);
            daCA = new SqlDataAdapter(com);

            if (ds.Tables["CoursAppel"] != null)
                ds.Tables["CoursAppel"].Clear();

            daCA.Fill(ds, "CoursAppel");
            bsCA.DataSource = ds;
            bsCA.DataMember = "CoursAppel";

            comB = new SqlCommandBuilder(daCA);

            com_CoursA.DataSource = bsCA;
            com_CoursA.DisplayMember = "NomCoursAppel";
            com_CoursA.ValueMember = "NumCoursAppel";
            com_CoursA.Text = "-------";


            //Remplisage comboBox TypeExp:
            string req2 = "select* from TypeExp";
            com = new SqlCommand(req2, cn);
            daTypeExp = new SqlDataAdapter(com);
            if (ds.Tables["TypeExp"] != null)
                ds.Tables["TypeExp"].Clear();

            daTypeExp.Fill(ds, "TypeExp");

            bsTypeExp.DataSource = ds;
            bsTypeExp.DataMember = "TypeExp";

            comB = new SqlCommandBuilder(daTypeExp);

            com_type_exp.DataSource = bsTypeExp;
            com_type_exp.DisplayMember = "typeExp";
            com_type_exp.ValueMember = "NumTypeExp";
            com_type_exp.Text = "-------";

            com = null;
            comB = null;

            //Remplisage comboBox Statut:
            string req3 = "select* from Statut";
            com = new SqlCommand(req3, cn);
            daStt = new SqlDataAdapter(com);
            if (ds.Tables["Statut"] != null)
                ds.Tables["Statut"].Clear();

            daStt.Fill(ds, "Statut");

            bsStt.DataSource = ds;
            bsStt.DataMember = "Statut";

            comB = new SqlCommandBuilder(daStt);

            com_statu.DataSource = bsStt;
            com_statu.DisplayMember = "statut";
            com_statu.ValueMember = "NumStatut";
            com_statu.Text = "-------";
            com = null;
            comB = null;
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
        private void btn_open_file_Click(object sender, EventArgs e)
        {

            fbd.ShowDialog();
            txt_rep.Text = fbd.SelectedPath.ToString() + @"\";

        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            string rqt = "insert into expertise values (@NumExp,@RefCabinet,@RefRéféré,@NumTribunalP,@NomMagistrat,@NomJugeControleur,@NomGreffier,@TypeDécision,@DateDécision,@DateDésignation,@DateAcceptation,@DateConsignation,@MontantConsignation,@LieuExp,@NumTypeExp,@DateConvPart,@DateRvPart,@HeureRvPart,@RépertoireDoc,@NumStatut,@Terminer)";

            com = new SqlCommand(rqt, cn);

            int NumExp = 0;
            SqlDataAdapter sa = new SqlDataAdapter("select NumExp from expertise", cn);
            DataTable dt = new DataTable();
            sa.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NumExp = Convert.ToInt32(dt.Rows.Count);
            }

            NumExp += 1;
            bool terminer = false;
            com.Parameters.Add(new SqlParameter("@NumExp", NumExp));
            com.Parameters.Add(new SqlParameter("@RefCabinet", Convert.ToInt32(txt_ref_ref.Text)));
            com.Parameters.Add(new SqlParameter("@RefRéféré", txt_ref_ref.Text));
            com.Parameters.Add(new SqlParameter("@NumTribunalP", Convert.ToInt32(com_tribunalP.SelectedValue)));
            com.Parameters.Add(new SqlParameter("@NomMagistrat", txt_magistrat.Text));
            com.Parameters.Add(new SqlParameter("@NomJugeControleur", txt_juge.Text));
            com.Parameters.Add(new SqlParameter("@NomGreffier", txt_greffier.Text));
            com.Parameters.Add(new SqlParameter("@TypeDécision", txt_type_decision.Text));
            com.Parameters.Add(new SqlParameter("@DateDécision", Convert.ToDateTime(date_decision.Text)));
            com.Parameters.Add(new SqlParameter("@DateDésignation", Convert.ToDateTime(date_desi.Text)));
            com.Parameters.Add(new SqlParameter("@DateAcceptation", Convert.ToDateTime(date_acc.Text)));
            com.Parameters.Add(new SqlParameter("@DateConsignation", Convert.ToDateTime(date_consi.Text)));
            com.Parameters.Add(new SqlParameter("@MontantConsignation", txt_montant.Text));
            com.Parameters.Add(new SqlParameter("@LieuExp", txt_lieu.Text));
            com.Parameters.Add(new SqlParameter("@NumTypeExp", Convert.ToInt32(com_type_exp.SelectedValue)));
            com.Parameters.Add(new SqlParameter("@DateConvPart", Convert.ToDateTime(date_conv.Text)));
            com.Parameters.Add(new SqlParameter("@DateRvPart", Convert.ToDateTime(date_rend.Text)));
            com.Parameters.Add(new SqlParameter("@HeureRvPart", txt_horai.Text));
            com.Parameters.Add(new SqlParameter("@RépertoireDoc", txt_rep.Text));
            com.Parameters.Add(new SqlParameter("@NumStatut", Convert.ToInt32(com_statu.SelectedValue)));
            com.Parameters.Add(new SqlParameter("@Terminer", terminer));

            string rqtUnq = "select RefCabinet from expertise";
            SqlCommand com1 = new SqlCommand(rqtUnq, cn);
            bool Unq = false;
            SqlDataReader dr = com1.ExecuteReader();


            while (dr.Read())
            {
                if (Convert.ToInt32(dr[0]) == Convert.ToInt32(txt_ref_ref.Text))
                {
                    MessageBox.Show("Cette expertise existe déja", "Ereur");
                    Unq = true;
                    break;
                }

            }
            dr.Close();
            dr = null;
            com1 = null;
            if (!Unq)
            {


                if (txt_rep.Text == "" || txt_rep.Text == @"\")
                {
                    lbl_VideDs.Visible = true;
                }
                else
                {
                    string Chemin = txt_rep.Text + GetFolderName();
                    DirectoryInfo Dir = new DirectoryInfo(Chemin);
                    Dir.Create();
                    com.ExecuteNonQuery();
                    this.Hide();
                }

            }

            com = null;
            cn.Close();
            cn = null;

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void com_tribunal_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }



        private void com_statu_KeyDown(object sender, KeyEventArgs e)
        {

            e.SuppressKeyPress = true;
        }

        private void com_type_exp_KeyDown(object sender, KeyEventArgs e)
        {

            e.SuppressKeyPress = true;
        }

        private void com_CoursA_SelectedValueChanged(object sender, EventArgs e)
        {

            //Remplisage comboBox Tribunal:
            if (com_CoursA.SelectedIndex > -1)
            {
                try
                {
                    SqlConnection cn = new SqlConnection(cs);
                    cn.Open();
                    int NumCA = Convert.ToInt32(com_CoursA.SelectedValue);
                    string req1 = "select * from TribunauxPremière where NumCoursAppel =" + NumCA;
                    com = new SqlCommand(req1, cn);
                    daTr = new SqlDataAdapter(com);

                    if (ds.Tables["TribunalP"] != null)
                        ds.Tables["Tribunalp"].Clear();

                    daTr.Fill(ds, "TribunalP");
                    bsTr.DataSource = ds;
                    bsTr.DataMember = "TribunalP";

                    comB = new SqlCommandBuilder(daTr);

                    com_tribunalP.DataSource = bsTr;
                    com_tribunalP.DisplayMember = "NomTribunalP";
                    com_tribunalP.ValueMember = "NumTribunalP";
                    com_tribunalP.Text = "-------";

                    com = null;
                    comB = null;
                }
                catch (Exception ex) { }

            }
        }

        private void Ajouter_expertise_SizeChanged(object sender, EventArgs e)
        {
            if(this.Width<1200)
            this.Font =  new Font("Arial", 10, FontStyle.Bold);
            else
                this.Font = new Font("Arial", 14, FontStyle.Bold);
        }
    }
}

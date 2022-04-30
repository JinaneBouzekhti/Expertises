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
        BindingSource bsTr = new BindingSource();
        BindingSource bsTypeExp = new BindingSource();
        BindingSource bsStt = new BindingSource();
        SqlCommand com;
        SqlCommandBuilder comB;
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
            //Remplisage comboBox Tribunal:
            string req1 = "select* from Tribunal";
            com = new SqlCommand(req1, cn);
            daTr = new SqlDataAdapter(com);

            if (ds.Tables["Tribunal"] != null)
                ds.Tables["Tribunal"].Clear();

            daTr.Fill(ds, "Tribunal");
            bsTr.DataSource = ds;
            bsTr.DataMember = "Tribunal";
            
            comB = new SqlCommandBuilder(daTr);

            com_tribunal.DataSource = bsTr;
            com_tribunal.DisplayMember = "NomTribunal";
            com_tribunal.ValueMember = "NumTribunal";
            com_tribunal.Text = "-------";

            com = null;
            comB = null;

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
            string NameF;
            string NumExp = txt_n_exp.Text;
            string ext = Path.GetExtension(ofd.FileName);
            NameF = "Expertise" + NumExp + ext;
            return NameF;
        }
        private void btn_open_file_Click(object sender, EventArgs e)
        {
            
                fbd.ShowDialog();
                txt_rep.Text = fbd.SelectedPath.ToString()+@"\";
                
        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            string rqt = "insert into expertise values (@NumExp,@NomExp,@NumTribunal,@NomMagistrat,@NomJugeControleur,@NomGreffier,@TypeDécision,@DateDécision,@NumServExp,@DateDésignation,@DateAcceptation,@DateConsignation,@MontantConsignation,@RefRéféré,@RefCabinet,@NumRG,@LieuExp,@NumTypeExp,@DateConvPart,@DateRvPart,@HeureRvPart,@RépertoireDoc,@NumStatut)";

            com = new SqlCommand(rqt, cn);

            com.Parameters.Add(new SqlParameter("@NumExp", txt_n_exp.Text));
            com.Parameters.Add(new SqlParameter("@NomExp", txt_nom_exp.Text));
            com.Parameters.Add(new SqlParameter("@NumTribunal", Convert.ToInt32(com_tribunal.SelectedValue)));
            com.Parameters.Add(new SqlParameter("@NomMagistrat", txt_magistrat.Text));
            com.Parameters.Add(new SqlParameter("@NomJugeControleur", txt_juge.Text));
            com.Parameters.Add(new SqlParameter("@NomGreffier", txt_greffier.Text));
            com.Parameters.Add(new SqlParameter("@TypeDécision", txt_type_decision.Text));
            com.Parameters.Add(new SqlParameter("@DateDécision", Convert.ToDateTime(date_decision.Text)));
            com.Parameters.Add(new SqlParameter("@NumServExp", txt_no_ser_exp.Text));
            com.Parameters.Add(new SqlParameter("@DateDésignation", Convert.ToDateTime(date_desi.Text)));
            com.Parameters.Add(new SqlParameter("@DateAcceptation", Convert.ToDateTime(date_acc.Text)));
            com.Parameters.Add(new SqlParameter("@DateConsignation", Convert.ToDateTime(date_consi.Text)));
            com.Parameters.Add(new SqlParameter("@MontantConsignation", txt_montant.Text));
            com.Parameters.Add(new SqlParameter("@RefRéféré", txt_ref_ref.Text));
            com.Parameters.Add(new SqlParameter("@RefCabinet", txt_ref_cab.Text));
            com.Parameters.Add(new SqlParameter("@NumRG", txt_no_rg.Text));
            com.Parameters.Add(new SqlParameter("@LieuExp", txt_lieu.Text));
            com.Parameters.Add(new SqlParameter("@NumTypeExp", Convert.ToInt32(com_type_exp.SelectedValue)));
            com.Parameters.Add(new SqlParameter("@DateConvPart", Convert.ToDateTime(date_conv.Text)));
            com.Parameters.Add(new SqlParameter("@DateRvPart", Convert.ToDateTime(date_rend.Text)));
            com.Parameters.Add(new SqlParameter("@HeureRvPart", txt_horai.Text));
            com.Parameters.Add(new SqlParameter("@RépertoireDoc", txt_rep.Text));
            com.Parameters.Add(new SqlParameter("@NumStatut", Convert.ToInt32(com_statu.SelectedValue)));

            string rqtPK = "select NumExp from expertise";
            SqlCommand com1 = new SqlCommand(rqtPK, cn);
            bool pk = false;
            SqlDataReader dr = com1.ExecuteReader();


            while (dr.Read())
            {
                if (dr[0].ToString() == txt_n_exp.Text.ToString())
                {
                    MessageBox.Show("Cette expertise existe déja", "Ereur");
                    pk = true;
                    break;
                }

            }
            dr.Close();
            dr = null;
            com1 = null;
            if (!pk)
            {
                 if (txt_n_exp.Text == "")
                 {
                    lbl_NExp.Visible = true;
                 }
                else
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

       
    }
}

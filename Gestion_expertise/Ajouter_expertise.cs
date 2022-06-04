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
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Gestion_expertise
{
    public partial class Ajouter_expertise : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString;

        DataSet ds = new DataSet();
        BindingSource bsCA = new BindingSource();
        BindingSource bsTr = new BindingSource();
        BindingSource bsTypeExp = new BindingSource();
        BindingSource bsTypeExp2 = new BindingSource();
        BindingSource bsStt = new BindingSource();

        SqlCommand com;
        SqlCommandBuilder comB;

        SqlDataAdapter daCA;
        SqlDataAdapter daTr;
        SqlDataAdapter daTypeExp;
        SqlDataAdapter daTypeExp2;
        SqlDataAdapter daStt;

        OpenFileDialog ofd = new OpenFileDialog();
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public Ajouter_expertise(string log)
        {
            InitializeComponent();
            this.log = log;
        }
        string log;

        private void Ajouter_expertise_Load(object sender, EventArgs e)
        {
            int RefCab;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            SqlDataAdapter sa = new SqlDataAdapter("select Max(RefCabinet) from expertise", cn);
            DataTable dt = new DataTable();
            sa.Fill(dt);

            if (dt.Rows[0][0].ToString().Equals(""))
                RefCab = 0;
            else
                RefCab = Convert.ToInt32(dt.Rows[0][0]);

            RefCab += 1;
            txt_ref_cab.Text = RefCab.ToString();
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
            //com_CoursA.Text = "-------";

            //Remplisage comboBox CodeTypeExp:
            string req2 = "select* from TypeExp";
            com = new SqlCommand(req2, cn);
            daTypeExp = new SqlDataAdapter(com);
            if (ds.Tables["TypeExp"] != null)
                ds.Tables["TypeExp"].Clear();

            daTypeExp.Fill(ds, "TypeExp");

            bsTypeExp.DataSource = ds;
            bsTypeExp.DataMember = "TypeExp";

            comB = new SqlCommandBuilder(daTypeExp);


            com_RefType.DataSource = bsTypeExp;
            com_RefType.DisplayMember = "Code";
            com_RefType.ValueMember = "NumTypeExp";

            //com_RefType.Text = "-------";
            com = null;
            comB = null;

            //Remplisage comboBox TypeExp:
            com = new SqlCommand(req2, cn);
            daTypeExp2 = new SqlDataAdapter(com);
            if (ds.Tables["TypeExp2"] != null)
                ds.Tables["TypeExp2"].Clear();

            daTypeExp2.Fill(ds, "TypeExp2");

            bsTypeExp2.DataSource = ds;
            bsTypeExp2.DataMember = "TypeExp2";

            comB = new SqlCommandBuilder(daTypeExp2);

            com_type_exp.DataSource = bsTypeExp2;
            com_type_exp.DisplayMember = "typeExp";
            com_type_exp.ValueMember = "NumTypeExp";

            //com_type_exp.Text = "-------";
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
            //com_statu.Text = "-------";
            com = null;
            comB = null;

            txt_horai.Text = "Ex: 00:00";
            txt_horai.ForeColor = Color.Gray ;
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
                    //com_tribunalP.Text = "-------";

                    com = null;
                    comB = null;
                }
                catch (Exception ex) { }
            }
        }


        public string GetFolderName()
        {
            int RefCab;
            string NameF;

            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select Max(RefCabinet) from expertise", cn);
            DataTable dt = new DataTable();
            sa.Fill(dt);

            if (dt.Rows[0][0].ToString().Equals(""))
                RefCab = 0;
            else
                RefCab = Convert.ToInt32(dt.Rows[0][0]);

            RefCab += 1;

            string date = DateTime.Now.ToString("yyyy");
            string ext = Path.GetExtension(ofd.FileName);
            NameF = "EXP" + "-" + RefCab + "-" + date + ext;
            return NameF;
        }

        private void btn_open_file_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog();
            txt_rep.Text = fbd.SelectedPath.ToString() + @"\" + GetFolderName();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            lblHrr.Visible = false;
            lbl_VideDs.Visible = false;
            lbl_oblig.Visible = false;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            SqlDataAdapter sa = new SqlDataAdapter("select type from Utilisateur where login like '" + log + "'", cn);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            if (Convert.ToInt32(dt.Rows[0][0]) == 1)
            {

                string Ref = txt_refYear.Text + "/" + com_RefType.Text + "/" + txt_refCode.Text;


                string rqt = "insert into expertise values (@RefCabinet,@RefRéféré,@NumTribunalP,@NomMagistrat,@NomJugeControleur,@sujet,@TypeDécision,@DateDécision,@DateDésignation,@DateAcceptation,@DateConsignation,@MontantConsignation,@LieuExp,@NumTypeExp,@DateConvPart,@DateRvPart,@HeureRvPart,@RépertoireDoc,@NumStatut,@Terminer)";

                com = new SqlCommand(rqt, cn);

                bool terminer = false;
                com.Parameters.Add(new SqlParameter("@RefCabinet", txt_ref_cab.Text));
                com.Parameters.Add(new SqlParameter("@RefRéféré", Ref));
                com.Parameters.Add(new SqlParameter("@NumTribunalP", Convert.ToInt32(com_tribunalP.SelectedValue)));
                com.Parameters.Add(new SqlParameter("@NomMagistrat", txt_magistrat.Text));
                com.Parameters.Add(new SqlParameter("@NomJugeControleur", txt_juge.Text));
                com.Parameters.Add(new SqlParameter("@sujet", txt_sujet.Text));
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

                if (txt_refYear.Text == "" || txt_refCode.Text == "" || txt_lieu.Text == "" || txt_horai.Text == "")
                {
                    lbl_oblig.Visible = true;
                }
                else
                {

                    if (!Regex.Match(txt_horai.Text, "^([0-1][0-9])?([2][0-3])?:([0-5][0-9])$").Success) 
                    {
                        lblHrr.Visible = true;
                    } 
                    else 
                    { 
                        if (txt_rep.Text == "" || txt_rep.Text == @"\" + GetFolderName())
                        {
                            lbl_VideDs.Visible = true;
                        }
                        else
                        {

                            string Chemin = txt_rep.Text;
                            DirectoryInfo Dir = new DirectoryInfo(Chemin);
                            if (!Dir.Exists)
                            {
                                Dir.Create();
                                com.ExecuteNonQuery();
                                this.Hide();
                            }
                            else
                            {
                                com.ExecuteNonQuery();
                                this.Hide();
                            }
                        }
                    }

                    com = null;
                    cn.Close();
                    cn = null;
                }
            }
            else
            {
                string message, title, defaultValue;
                object myValue;
                message = "Entrer le clé de securité";
                title = "Clé de securité";
                defaultValue = "";
                myValue = Interaction.InputBox(message, title, defaultValue);

                SqlDataAdapter sa1 = new SqlDataAdapter("select clé from plus ", cn);
                DataTable dt1 = new DataTable();
                sa1.Fill(dt1);

                if ((string)myValue == dt1.Rows[0][0].ToString())
                {
                    string Ref = txt_refYear.Text + "/" + com_RefType.Text + "/" + txt_refCode.Text;


                    string rqt = "insert into expertise values (@RefCabinet,@RefRéféré,@NumTribunalP,@NomMagistrat,@NomJugeControleur,@sujet,@TypeDécision,@DateDécision,@DateDésignation,@DateAcceptation,@DateConsignation,@MontantConsignation,@LieuExp,@NumTypeExp,@DateConvPart,@DateRvPart,@HeureRvPart,@RépertoireDoc,@NumStatut,@Terminer)";

                    com = new SqlCommand(rqt, cn);

                    bool terminer = false;
                    com.Parameters.Add(new SqlParameter("@RefCabinet", txt_ref_cab.Text));
                    com.Parameters.Add(new SqlParameter("@RefRéféré", Ref));
                    com.Parameters.Add(new SqlParameter("@NumTribunalP", Convert.ToInt32(com_tribunalP.SelectedValue)));
                    com.Parameters.Add(new SqlParameter("@NomMagistrat", txt_magistrat.Text));
                    com.Parameters.Add(new SqlParameter("@NomJugeControleur", txt_juge.Text));
                    com.Parameters.Add(new SqlParameter("@sujet", txt_sujet.Text));
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

                    if (txt_refYear.Text == "" || txt_refCode.Text == "" || txt_lieu.Text == "" || txt_horai.Text == "")
                    {
                        lbl_oblig.Visible = true;
                    }
                    else
                    {

                        if (!Regex.Match(txt_horai.Text, "^([0-1][0-9])?([2][0-3])?:([0-5][0-9])$").Success)
                        {
                            lblHrr.Visible = true;
                        }
                        else
                        {
                            if (txt_rep.Text == "" || txt_rep.Text == @"\" + GetFolderName())
                            {
                                lbl_VideDs.Visible = true;
                            }
                            else
                            {

                                string Chemin = txt_rep.Text;
                                DirectoryInfo Dir = new DirectoryInfo(Chemin);
                                if (!Dir.Exists)
                                {
                                    Dir.Create();
                                    com.ExecuteNonQuery();
                                    this.Hide();
                                }
                                else
                                {
                                    com.ExecuteNonQuery();
                                    this.Hide();
                                }
                            }
                        }

                        com = null;
                        cn.Close();
                        cn = null;
                    }
                }
                else
                {
                    if ((string)myValue != "")
                        Microsoft.VisualBasic.Interaction.MsgBox("Clé de sécurité ( " + myValue.ToString() + " ) est incorrect , Impossible de modifier cette expertise !!!", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Erreur");
                }
            }
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

        private void Ajouter_expertise_SizeChanged(object sender, EventArgs e)
        {
            if(this.Width<1200)
                this.Font =  new Font("Arial", 10, FontStyle.Bold);
            else
                this.Font = new Font("Arial", 14, FontStyle.Bold);
        }

        private void com_RefType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_RefType.SelectedIndex > -1)
            {
                try
                {
                    SqlConnection cn = new SqlConnection(cs);
                    cn.Open();
                    int NumType = Convert.ToInt32(com_RefType.SelectedValue);
                    string req3 = "select * from TypeExp where NumTypeExp =" + NumType;
                    com = new SqlCommand(req3, cn);
                    daTypeExp2 = new SqlDataAdapter(com);
                    if (ds.Tables["TypeExp2"] != null)
                        ds.Tables["TypeExp2"].Clear();

                    daTypeExp2.Fill(ds, "TypeExp2");

                    bsTypeExp2.DataSource = ds;
                    bsTypeExp2.DataMember = "TypeExp2";

                    comB = new SqlCommandBuilder(daTypeExp2);

                    com_type_exp.DataSource = bsTypeExp2;
                    com_type_exp.DisplayMember = "typeExp";
                    com_type_exp.ValueMember = "NumTypeExp";
                    com = null;
                    comB = null;
                }
                catch (Exception ex) { }
            }
        }

        private void tableLayoutPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void txt_horai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

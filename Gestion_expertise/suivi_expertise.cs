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
using Microsoft.VisualBasic;
namespace Gestion_expertise
{
    public partial class suivi_expertise : UserControl
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
        public suivi_expertise(string RefCabinet, string log )
        {
            InitializeComponent();
            this.RefCabinet = RefCabinet;
            this.log = log;
        }
        string RefCabinet;
        string log;
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


            com_RefType.DataSource = bsTypeExp;
            com_RefType.DisplayMember = "Code";
            com_RefType.ValueMember = "NumTypeExp";
            com_RefType.Text = "-------";

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

            SqlDataAdapter sa = new SqlDataAdapter("select * from expertise where RefCabinet like '" + RefCabinet + "'", cn);
            DataTable dt = new DataTable();
            sa.Fill(dt);


            txt_ref_cab.Texts = dt.Rows[0][0].ToString();
            string Ref = dt.Rows[0][1].ToString();
            string[] list = Ref.Split('/');

            txt_refYear.Texts = list[0];
            com_RefType.Text = list[1];
            txt_refCode.Texts = list[2];

            SqlDataAdapter sa1 = new SqlDataAdapter("select * from TribunauxPremière where NumTribunalP =" + dt.Rows[0][2], cn);
            DataTable dt1 = new DataTable();
            sa1.Fill(dt1);
            cmb_trib_pr.Text = dt1.Rows[0][1].ToString();


            SqlDataAdapter sa2 = new SqlDataAdapter("select * from  CoursAppel  where NumCoursAppel =" + dt1.Rows[0][2], cn);
            DataTable dt2 = new DataTable();
            sa2.Fill(dt2);
            cmb_CoursA.Text = dt2.Rows[0][1].ToString();


            txt_magi.Texts = dt.Rows[0][3].ToString();
            txt_jug.Texts = dt.Rows[0][4].ToString();
            txt_gre.Texts = dt.Rows[0][5].ToString();
            txt_type_dec.Texts = dt.Rows[0][6].ToString();

            date_decision.Text = dt.Rows[0][7].ToString();
            date_desi.Text = dt.Rows[0][8].ToString();
            date_acc.Text = dt.Rows[0][9].ToString();
            date_consi.Text = dt.Rows[0][10].ToString();

            txt_lieu.Texts = dt.Rows[0][12].ToString();

            SqlDataAdapter sa3 = new SqlDataAdapter("select * from TypeExp  where NumTypeExp =" + dt.Rows[0][13], cn);
            DataTable dt3 = new DataTable();
            sa3.Fill(dt3);
            cmb_type_exp.Text = dt3.Rows[0][1].ToString();


            date_conv.Text = dt.Rows[0][14].ToString();
            date_rend.Text = dt.Rows[0][15].ToString();


            txt_hor.Texts = dt.Rows[0][16].ToString();
            txt_rep.Texts = dt.Rows[0][17].ToString();

            SqlDataAdapter sa4 = new SqlDataAdapter("select * from Statut  where NumStatut =" + dt.Rows[0][18], cn);
            DataTable dt4 = new DataTable();
            sa4.Fill(dt4);
            cmb_stat.Text = dt4.Rows[0][1].ToString();

            txt_montan.Texts = dt.Rows[0][11].ToString();

            if (Convert.ToInt32(dt.Rows[0][19]) == 1)
            {
                cb_termine.Checked = true;
            }

        }

        private void cmb_CoursA_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_CoursA.Enabled)
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
            string NameF;
            string date = DateTime.Now.ToString("yyyy");
            string ext = Path.GetExtension(ofd.FileName);
            NameF = "EXP" + "-" + RefCabinet + "-" + date + ext;
            return NameF;
        }

        private void btn_Rep_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog();
            txt_rep.Texts = fbd.SelectedPath.ToString() + @"\" + GetFolderName() ;
        }

        public void Activate(Boolean v)
        {
            txt_refYear.Enabled = v;
            com_RefType.Enabled = v;
            txt_refCode.Enabled = v;
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
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            SqlDataAdapter sa = new SqlDataAdapter("select type from Utilisateur where login like '" + log + "'", cn);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            if (Convert.ToInt32(dt.Rows[0][0]) == 1)
            {
                Activate(true);
            }
            else
            {

            
                string message, title, defaultValue;
            object myValue;
            message = "Entrer le clé de securité";
            title = "Clé de securité";
            defaultValue = "";
            myValue = Interaction.InputBox(message, title, defaultValue);

            if ((string)myValue == "B20J21I22")
            {
                Activate(true);
            }
            else
            {
                if ((string)myValue != "")
                    Microsoft.VisualBasic.Interaction.MsgBox("Clé de sécurité ( " + myValue.ToString() + " ) est incorrect , Impossible de modifier cette expertise !!!", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Erreur");
            }
            }
        }
      
       
        private void btn_valider_Click(object sender, EventArgs e)
        {
            string Ref = txt_refYear.Texts + "/" + com_RefType.Text + "/" + txt_refCode.Texts;
            bool tr = false;
            if (cb_termine.Checked)
                tr = true;

            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select T.NumTribunalP from TribunauxPremière T inner join Expertise E on T.NumTribunalP = E.NumTribunalP where RefCabinet like " + RefCabinet, cn);
            DataTable dt = new DataTable();
            sa.Fill(dt);

           
            string rqt = " update expertise set RefRéféré =@RefRéféré,NumTribunalP=@NumTribunalP,NomMagistrat=@NomMagistrat,NomJugeControleur=@NomJugeControleur,NomGreffier=@NomGreffier,TypeDécision=@TypeDécision,DateDécision=@DateDécision,DateDésignation=@DateDésignation,DateAcceptation=@DateAcceptation,DateConsignation=@DateConsignation,MontantConsignation=@MontantConsignation,LieuExp=@LieuExp,NumTypeExp=@NumTypeExp,DateConvPart=@DateConvPart,DateRvPart=@DateRvPart,HeureRvPart=@HeureRvPart,RépertoireDoc=@RépertoireDoc,NumStatut=@NumStatut,Terminé=@Terminer where RefCabinet like '" + RefCabinet + "'";
            SqlCommand com = new SqlCommand(rqt, cn);

           com.Parameters.Add(new SqlParameter("@RefRéféré", Ref));
            if(cmb_trib_pr.SelectedValue != null)
            com.Parameters.Add(new SqlParameter("@NumTribunalP", Convert.ToInt32(cmb_trib_pr.SelectedValue)));
            else
            com.Parameters.Add(new SqlParameter("@NumTribunalP", dt.Rows[0][0]));
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

            string Chemin = txt_rep.Texts;
            if (Chemin != "")
                {
                    DirectoryInfo Dir = new DirectoryInfo(Chemin);
                    if (!Dir.Exists)
                    {
                        Dir.Create();
                        com.ExecuteNonQuery();
                        Activate(false);
                    }
                    else
                    {
                        com.ExecuteNonQuery();
                        Activate(false);
                    }
                }
                else
                {
                    com.ExecuteNonQuery();
                    Activate(false);
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

            com_RefType.DataSource = bsTypeExp;
            com_RefType.DisplayMember = "Code";
            com_RefType.ValueMember = "NumTypeExp";
            com_RefType.Text = "-------";

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

            SqlDataAdapter sa = new SqlDataAdapter("select * from expertise where RefCabinet like '" + RefCabinet + "'", cn);
            DataTable dt = new DataTable();
            sa.Fill(dt);


            txt_ref_cab.Texts = dt.Rows[0][0].ToString();
            string Ref = dt.Rows[0][1].ToString();
            string[] list = Ref.Split('/');

            txt_refYear.Texts = list[0];
            com_RefType.Text = list[1];
            txt_refCode.Texts = list[2];

            SqlDataAdapter sa1 = new SqlDataAdapter("select NomTribunalP,NumCoursAppel from TribunauxPremière T inner join Expertise E on T.NumTribunalP = E.NumTribunalP where RefCabinet like " + RefCabinet, cn);
            DataTable dt1 = new DataTable();
            sa1.Fill(dt1);

            SqlDataAdapter sa2 = new SqlDataAdapter("select * from  CoursAppel  where NumCoursAppel =" + dt1.Rows[0][1], cn);
            DataTable dt2 = new DataTable();
            sa2.Fill(dt2);
            cmb_CoursA.Text = dt2.Rows[0][1].ToString();

            cmb_trib_pr.Text = dt1.Rows[0][0].ToString();

            txt_magi.Texts = dt.Rows[0][3].ToString();
            txt_jug.Texts = dt.Rows[0][4].ToString();
            txt_gre.Texts = dt.Rows[0][5].ToString();
            txt_type_dec.Texts = dt.Rows[0][6].ToString();

            date_decision.Text = dt.Rows[0][7].ToString();
            date_desi.Text = dt.Rows[0][8].ToString();
            date_acc.Text = dt.Rows[0][9].ToString();
            date_consi.Text = dt.Rows[0][10].ToString();

            txt_lieu.Texts = dt.Rows[0][12].ToString();

            SqlDataAdapter sa3 = new SqlDataAdapter("select * from TypeExp  where NumTypeExp =" + dt.Rows[0][13], cn);
            DataTable dt3 = new DataTable();
            sa3.Fill(dt3);
            cmb_type_exp.Text = dt3.Rows[0][1].ToString();

            date_conv.Text = dt.Rows[0][14].ToString();
            date_rend.Text = dt.Rows[0][15].ToString();


            txt_hor.Texts = dt.Rows[0][16].ToString();
            txt_rep.Texts = dt.Rows[0][17].ToString();

            SqlDataAdapter sa4 = new SqlDataAdapter("select * from Statut  where NumStatut =" + dt.Rows[0][18], cn);
            DataTable dt4 = new DataTable();
            sa4.Fill(dt4);
            cmb_stat.Text = dt4.Rows[0][1].ToString();

            txt_montan.Texts = dt.Rows[0][11].ToString();

            if (Convert.ToInt32(dt.Rows[0][19]) == 1)
            {
                cb_termine.Checked = true;
            }

            Activate(false);
        }

        private void btn_suprimmer_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            SqlDataAdapter sa = new SqlDataAdapter("select type from Utilisateur where login like '" + log + "'", cn);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            if (Convert.ToInt32(dt.Rows[0][0]) == 1)
            {
                if (MessageBox.Show("Etes-vous sûre de cette supression !!", "Supression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string dossier = "";
                        if (txt_rep.Texts != "")
                            dossier = txt_rep.Texts;

                        string rqt = "delete from expertise where RefCabinet like '" + RefCabinet + "'";
                        SqlCommand com = new SqlCommand(rqt, cn);

                        if (dossier != "")
                        {
                            if (Directory.Exists(dossier))
                                Directory.Delete(dossier, true);
                        }
                        com.ExecuteNonQuery();
                        this.Controls.Clear();
                        ToutesExp uc = null;
                        uc = new ToutesExp();
                        this.Controls.Add(uc);
                        uc.Dock = DockStyle.Fill;
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

                if((string)myValue == "B20J21I22")
                {
                    if (MessageBox.Show("Etes-vous sûre de cette supression !!", "Supression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                         string dossier = "";
                         if (txt_rep.Texts != "")
                                    dossier = txt_rep.Texts;

                         string rqt = "delete from expertise where RefCabinet like '" + RefCabinet + "'";
                         SqlCommand com = new SqlCommand(rqt, cn);

                                if (dossier != "")
                                {
                                    if (Directory.Exists(dossier))
                                        Directory.Delete(dossier, true);
                                }
                                com.ExecuteNonQuery();
                                this.Controls.Clear();
                                ToutesExp uc = null;
                                uc = new ToutesExp();
                                this.Controls.Add(uc);
                                uc.Dock = DockStyle.Fill;
                    }
                }
                else
                {
                        if ((string)myValue != "")
                            Microsoft.VisualBasic.Interaction.MsgBox("Clé de sécurité est incorrect ( " + myValue.ToString() + " ), Impossible de supprimer cette expertise !!!", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Erreur");
                }
            }
        }

        private void com_RefType_SelectedValueChanged(object sender, EventArgs e)
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

                    cmb_type_exp.DataSource = bsTypeExp2;
                    cmb_type_exp.DisplayMember = "typeExp";
                    cmb_type_exp.ValueMember = "NumTypeExp";
                    com = null;
                    comB = null;
                }
                catch (Exception ex) { }
            }
        }


        //dragfile
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
        public void addfile(string source, string destination)
        {
            string fileName = source.Split('\\').Last();
            if (File.Exists(source))
            {
                if (!File.Exists(destination + fileName))
                {
                    File.Copy(source, destination + fileName);
                    MessageBox.Show(fileName + " copie avec succé");

                }
                else
                    MessageBox.Show(fileName + " deja existe");
            }
            else
            {
                if (!Directory.Exists(destination + fileName))
                {

                    Copy(source, destination + fileName);

                    MessageBox.Show(fileName + " copie avec succé");

                }
                else
                    MessageBox.Show(fileName + " deja existe");
            }

        }
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string s in files)
            {
                addfile(s, txt_rep.Texts+"\\");                
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Multiselect = true;
            opf.ShowDialog();

            if (opf.FileNames.Count() != 0)
                foreach (string s in opf.FileNames)
                    addfile(s, txt_rep.Texts +"\\");           
        }

     
    }
}

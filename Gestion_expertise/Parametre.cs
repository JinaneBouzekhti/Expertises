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
    public partial class Parametre : Form
    {
        public Parametre(string User)
        {
            InitializeComponent();
            login = User;
        }
        string login;
        private void Parametre_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            SqlDataAdapter sa = new SqlDataAdapter("select * from Utilisateur where login like '" + login + "'", cn);
            DataTable dt = new DataTable();
            sa.Fill(dt);

            if (Convert.ToInt32(dt.Rows[0][7]) == 1)
                btn_admin.Visible = true;
            txt_log.Texts = dt.Rows[0][0].ToString();
            txt_nom.Texts = dt.Rows[0][2].ToString();
            txt_pren.Texts = dt.Rows[0][3].ToString();
            txt_mail.Texts = dt.Rows[0][4].ToString();
            log = dt.Rows[0][0].ToString();
            password = dt.Rows[0][1].ToString();
            nom = dt.Rows[0][2].ToString();
            prenom = dt.Rows[0][3].ToString();
            mail = dt.Rows[0][4].ToString();
            btn_profil.Visible = false;
            cn.Close();
        }
        string log,nom,prenom,mail,password;

        private void btn_profil_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand com = new SqlCommand("update Utilisateur set Nom = '" + txt_nom.Texts + "',Prenom = ' " + txt_pren.Texts + "', Email = '"+txt_mail.Texts+"' Where login = '"+log+"'",cn);
            com.ExecuteNonQuery();
            log = txt_log.Texts;
            nom = txt_nom.Texts;
            prenom = txt_pren.Texts;
            mail = txt_mail.Texts;
            btn_profil.Visible = false;
            cn.Close();
        }

        private void btn_pass_Click(object sender, EventArgs e)
        {
            label_vide.Visible = false;
            label_pass.Visible = false;
            label_val.Visible = false;
            if (txt_pas.Texts != "" && txt_new.Texts != "" && txt_valid.Texts != "")
            {
                if (txt_pas.Texts == password)
                {
                    if (txt_new.Texts == txt_valid.Texts)
                    {
                        string cs = ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString;
                        SqlConnection cn = new SqlConnection(cs);
                        cn.Open();
                        SqlCommand com = new SqlCommand("update Utilisateur set password = '" + txt_new.Texts + "' Where login = '" + log + "'", cn);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Le mot de passe a été changé avec succès");
                        cn.Close();
                    }
                    else
                        label_val.Visible = true;
                }
                else
                    label_pass.Visible = true;
            }
            else
                label_vide.Visible = true;
        }

        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            adminpanel ad = new adminpanel();
            ad.ShowDialog();
        }

        private void txt_log__TextChanged(object sender, EventArgs e)
        {
            if (nom != txt_nom.Texts || prenom != txt_pren.Texts || mail != txt_mail.Texts)
                btn_profil.Visible = true;
            else
                btn_profil.Visible = false;
        }
    }
}

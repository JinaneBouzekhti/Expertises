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
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
        }

        private void adminpanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'expertisesDataSet2.Utilisateur' table. You can move, or remove it, as needed.
            this.utilisateurTableAdapter.Fill(this.expertisesDataSet2.Utilisateur);
            txt_log.Texts = dgv_users.Rows[0].Cells[0].Value.ToString();
            txt_pas.Texts = dgv_users.Rows[0].Cells[1].Value.ToString();
            txt_nom.Texts = dgv_users.Rows[0].Cells[2].Value.ToString();
            txt_pren.Texts = dgv_users.Rows[0].Cells[3].Value.ToString();
            txt_mail.Texts = dgv_users.Rows[0].Cells[4].Value.ToString();
            cb_valide.Checked =Convert.ToBoolean(dgv_users.Rows[0].Cells[5].Value.ToString()) ;
        }

        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_log.Texts = dgv_users.Rows[dgv_users.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txt_pas.Texts = dgv_users.Rows[dgv_users.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txt_nom.Texts = dgv_users.Rows[dgv_users.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txt_pren.Texts = dgv_users.Rows[dgv_users.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txt_mail.Texts = dgv_users.Rows[dgv_users.CurrentCell.RowIndex].Cells[4].Value.ToString();
            cb_valide.Checked = Convert.ToBoolean(dgv_users.Rows[dgv_users.CurrentCell.RowIndex].Cells[5].Value.ToString());
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Activate(true);
            txt_log.Texts = "";
            txt_mail.Texts = "";
            txt_nom.Texts = "";
            txt_pas.Texts = "";
            txt_pren.Texts = "";
            cb_valide.Enabled = true;
            btn = 1;
        }

        private void Activate(bool v)
        {
            txt_log.Enabled = v;
            txt_mail.Enabled = v;
            txt_nom.Enabled = v;
            txt_pas.Enabled = v;
            txt_pren.Enabled = v;
            cb_valide.Enabled = v;
            btn_valider.Visible = v;
            btn_annuler.Visible = v;
            btn_ajouter.Visible = !v;
            btn_suprimmer.Visible = !v;
            btn_nodifier.Visible = !v;
        }
        int btn;
        private void btn_nodifier_Click(object sender, EventArgs e)
        {
            Activate(true);
            btn = 2;
            oldlogin = txt_log.Texts;
        }
        string oldlogin;
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            txt_log.Texts = dgv_users.Rows[dgv_users.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txt_pas.Texts = dgv_users.Rows[dgv_users.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txt_nom.Texts = dgv_users.Rows[dgv_users.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txt_pren.Texts = dgv_users.Rows[dgv_users.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txt_mail.Texts = dgv_users.Rows[dgv_users.CurrentCell.RowIndex].Cells[4].Value.ToString();
            cb_valide.Checked = Convert.ToBoolean(dgv_users.Rows[dgv_users.CurrentCell.RowIndex].Cells[5].Value.ToString());
            Activate(false);
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString);
            con.Open();
            if (isempty()==false)
            {
                if (btn == 1)
                {
                    SqlCommand cmd = new SqlCommand("insert into utilisateur values ('" + txt_log.Texts + "','" + txt_pas.Texts + "','" + txt_nom.Texts + "','" + txt_pren.Texts + "','" + txt_mail.Texts + "'," + Convert.ToString(cb_valide.Checked ? 1 : 0) + ",''); ",con);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("delete from utilisateur where login ='" + oldlogin + "'",con);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("insert into utilisateur values ('" + txt_log.Texts + "','" + txt_pas.Texts + "','" + txt_nom.Texts + "','" + txt_pren.Texts + "','" + txt_mail.Texts + "'," + Convert.ToString(cb_valide.Checked ? 1 : 0) + ",''); ",con);
                    cmd2.ExecuteNonQuery();
                }
            }
            else
                MessageBox.Show("tous les champs sont obligatoire", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.utilisateurTableAdapter.Fill(this.expertisesDataSet2.Utilisateur);
            Activate(false);
        }

        private bool isempty()
        {
            if (txt_log.Texts == "" || txt_pas.Texts == "" || txt_nom.Texts == "" || txt_pren.Texts == "" || txt_mail.Texts == "")

                return true;
            else
                return false;
        }

        private void btn_suprimmer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["expertises.Properties.Settings.expertisesConnectionString"].ConnectionString);
            con.Open();
            if (MessageBox.Show("Etes-vous sûre de cette supression !!", "Supression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from utilisateur where login like '" + txt_log.Texts + "'", con);
                cmd.ExecuteNonQuery();
                this.utilisateurTableAdapter.Fill(this.expertisesDataSet2.Utilisateur);
            }
        }
    }
}

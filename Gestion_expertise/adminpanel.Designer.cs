
namespace Gestion_expertise
{
    partial class adminpanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomtypeUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expertisesDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expertisesDataSet2 = new Gestion_expertise.expertisesDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.expertisesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expertisesDataSet = new Gestion_expertise.expertisesDataSet();
            this.btn_nodifier = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_suprimmer = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.utilisateurTableAdapter = new Gestion_expertise.expertisesDataSet2TableAdapters.UtilisateurTableAdapter();
            this.rjComboBox1 = new CustomControls.RJControls.RJComboBox();
            this.cb_valide = new WinFormsApp1.CheckBoxCustom();
            this.txt_mail = new CustomControls.RJControls.RJTextBox();
            this.txt_pren = new CustomControls.RJControls.RJTextBox();
            this.txt_nom = new CustomControls.RJControls.RJTextBox();
            this.txt_pas = new CustomControls.RJControls.RJTextBox();
            this.txt_log = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgv_users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_users.AutoGenerateColumns = false;
            this.dgv_users.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.NomtypeUtilisateur,
            this.validationDataGridViewCheckBoxColumn});
            this.dgv_users.DataSource = this.utilisateurBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_users.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_users.EnableHeadersVisualStyles = false;
            this.dgv_users.GridColor = System.Drawing.Color.Gray;
            this.dgv_users.Location = new System.Drawing.Point(6, 6);
            this.dgv_users.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.RowHeadersWidth = 51;
            this.dgv_users.RowTemplate.Height = 29;
            this.dgv_users.Size = new System.Drawing.Size(814, 277);
            this.dgv_users.TabIndex = 4;
            this.dgv_users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_users_CellContentClick);
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NomtypeUtilisateur
            // 
            this.NomtypeUtilisateur.DataPropertyName = "NomtypeUtilisateur";
            this.NomtypeUtilisateur.HeaderText = "Type";
            this.NomtypeUtilisateur.Name = "NomtypeUtilisateur";
            this.NomtypeUtilisateur.ReadOnly = true;
            // 
            // validationDataGridViewCheckBoxColumn
            // 
            this.validationDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.validationDataGridViewCheckBoxColumn.DataPropertyName = "Validation";
            this.validationDataGridViewCheckBoxColumn.HeaderText = "Validation";
            this.validationDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.validationDataGridViewCheckBoxColumn.Name = "validationDataGridViewCheckBoxColumn";
            this.validationDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "Utilisateur";
            this.utilisateurBindingSource.DataSource = this.expertisesDataSet2BindingSource;
            // 
            // expertisesDataSet2BindingSource
            // 
            this.expertisesDataSet2BindingSource.DataSource = this.expertisesDataSet2;
            this.expertisesDataSet2BindingSource.Position = 0;
            // 
            // expertisesDataSet2
            // 
            this.expertisesDataSet2.DataSetName = "expertisesDataSet2";
            this.expertisesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(20, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(20, 386);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mot de passe ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(20, 443);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(20, 500);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(433, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(429, 441);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Compte valide";
            // 
            // expertisesDataSetBindingSource
            // 
            this.expertisesDataSetBindingSource.DataSource = this.expertisesDataSet;
            this.expertisesDataSetBindingSource.Position = 0;
            // 
            // expertisesDataSet
            // 
            this.expertisesDataSet.DataSetName = "expertisesDataSet";
            this.expertisesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_nodifier
            // 
            this.btn_nodifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nodifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.btn_nodifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_nodifier.Image = global::Gestion_expertise.Properties.Resources.edit_property_25px;
            this.btn_nodifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nodifier.Location = new System.Drawing.Point(545, 524);
            this.btn_nodifier.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nodifier.Name = "btn_nodifier";
            this.btn_nodifier.Size = new System.Drawing.Size(136, 34);
            this.btn_nodifier.TabIndex = 124;
            this.btn_nodifier.Text = "Modifier";
            this.btn_nodifier.UseVisualStyleBackColor = false;
            this.btn_nodifier.Click += new System.EventHandler(this.btn_nodifier_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.btn_valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_valider.Image = global::Gestion_expertise.Properties.Resources.save_as_25px;
            this.btn_valider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_valider.Location = new System.Drawing.Point(623, 562);
            this.btn_valider.Margin = new System.Windows.Forms.Padding(2);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(99, 34);
            this.btn_valider.TabIndex = 122;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Visible = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_suprimmer
            // 
            this.btn_suprimmer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_suprimmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.btn_suprimmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suprimmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_suprimmer.Image = global::Gestion_expertise.Properties.Resources.delete_trash_25px;
            this.btn_suprimmer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suprimmer.Location = new System.Drawing.Point(407, 524);
            this.btn_suprimmer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_suprimmer.Name = "btn_suprimmer";
            this.btn_suprimmer.Size = new System.Drawing.Size(136, 34);
            this.btn_suprimmer.TabIndex = 121;
            this.btn_suprimmer.Text = "Suprimmer";
            this.btn_suprimmer.UseVisualStyleBackColor = false;
            this.btn_suprimmer.Click += new System.EventHandler(this.btn_suprimmer_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.btn_annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_annuler.Image = global::Gestion_expertise.Properties.Resources.undo_25px;
            this.btn_annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_annuler.Location = new System.Drawing.Point(520, 562);
            this.btn_annuler.Margin = new System.Windows.Forms.Padding(2);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(99, 34);
            this.btn_annuler.TabIndex = 123;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Visible = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.btn_ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_ajouter.Image = global::Gestion_expertise.Properties.Resources.add_25px;
            this.btn_ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ajouter.Location = new System.Drawing.Point(683, 524);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(136, 34);
            this.btn_ajouter.TabIndex = 120;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(433, 385);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 125;
            this.label7.Text = "Type";
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.rjComboBox1.BorderSize = 2;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Enabled = false;
            this.rjComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(545, 377);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBox1.Size = new System.Drawing.Size(249, 30);
            this.rjComboBox1.TabIndex = 126;
            this.rjComboBox1.Texts = "";
            // 
            // cb_valide
            // 
            this.cb_valide.Enabled = false;
            this.cb_valide.Location = new System.Drawing.Point(575, 435);
            this.cb_valide.Margin = new System.Windows.Forms.Padding(2);
            this.cb_valide.MinimumSize = new System.Drawing.Size(19, 18);
            this.cb_valide.Name = "cb_valide";
            this.cb_valide.OffBackColor = System.Drawing.Color.Gray;
            this.cb_valide.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cb_valide.OnBackColor = System.Drawing.Color.Gainsboro;
            this.cb_valide.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.cb_valide.Size = new System.Drawing.Size(62, 28);
            this.cb_valide.TabIndex = 97;
            this.cb_valide.UseVisualStyleBackColor = true;
            // 
            // txt_mail
            // 
            this.txt_mail.BackColor = System.Drawing.SystemColors.Window;
            this.txt_mail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.txt_mail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_mail.BorderSize = 2;
            this.txt_mail.Enabled = false;
            this.txt_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_mail.ForeColor = System.Drawing.Color.DimGray;
            this.txt_mail.Location = new System.Drawing.Point(547, 319);
            this.txt_mail.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mail.Multiline = false;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_mail.PasswordChar = false;
            this.txt_mail.Size = new System.Drawing.Size(249, 30);
            this.txt_mail.TabIndex = 14;
            this.txt_mail.Texts = "";
            this.txt_mail.UnderlinedStyle = false;
            // 
            // txt_pren
            // 
            this.txt_pren.BackColor = System.Drawing.SystemColors.Window;
            this.txt_pren.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.txt_pren.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_pren.BorderSize = 2;
            this.txt_pren.Enabled = false;
            this.txt_pren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_pren.ForeColor = System.Drawing.Color.DimGray;
            this.txt_pren.Location = new System.Drawing.Point(152, 490);
            this.txt_pren.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pren.Multiline = false;
            this.txt_pren.Name = "txt_pren";
            this.txt_pren.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_pren.PasswordChar = false;
            this.txt_pren.Size = new System.Drawing.Size(264, 30);
            this.txt_pren.TabIndex = 12;
            this.txt_pren.Texts = "";
            this.txt_pren.UnderlinedStyle = false;
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.txt_nom.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_nom.BorderSize = 2;
            this.txt_nom.Enabled = false;
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_nom.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nom.Location = new System.Drawing.Point(152, 433);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom.Multiline = false;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_nom.PasswordChar = false;
            this.txt_nom.Size = new System.Drawing.Size(264, 30);
            this.txt_nom.TabIndex = 10;
            this.txt_nom.Texts = "";
            this.txt_nom.UnderlinedStyle = false;
            // 
            // txt_pas
            // 
            this.txt_pas.BackColor = System.Drawing.SystemColors.Window;
            this.txt_pas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.txt_pas.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_pas.BorderSize = 2;
            this.txt_pas.Enabled = false;
            this.txt_pas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_pas.ForeColor = System.Drawing.Color.DimGray;
            this.txt_pas.Location = new System.Drawing.Point(152, 376);
            this.txt_pas.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pas.Multiline = false;
            this.txt_pas.Name = "txt_pas";
            this.txt_pas.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_pas.PasswordChar = false;
            this.txt_pas.Size = new System.Drawing.Size(264, 30);
            this.txt_pas.TabIndex = 8;
            this.txt_pas.Texts = "";
            this.txt_pas.UnderlinedStyle = false;
            // 
            // txt_log
            // 
            this.txt_log.BackColor = System.Drawing.SystemColors.Window;
            this.txt_log.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.txt_log.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_log.BorderSize = 2;
            this.txt_log.Enabled = false;
            this.txt_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_log.ForeColor = System.Drawing.Color.DimGray;
            this.txt_log.Location = new System.Drawing.Point(152, 319);
            this.txt_log.Margin = new System.Windows.Forms.Padding(4);
            this.txt_log.Multiline = false;
            this.txt_log.Name = "txt_log";
            this.txt_log.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_log.PasswordChar = false;
            this.txt_log.Size = new System.Drawing.Size(264, 30);
            this.txt_log.TabIndex = 6;
            this.txt_log.Texts = "";
            this.txt_log.UnderlinedStyle = false;
            // 
            // adminpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 604);
            this.Controls.Add(this.rjComboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_nodifier);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_suprimmer);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.cb_valide);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pren);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "adminpanel";
            this.Text = "adminpanel";
            this.Load += new System.EventHandler(this.adminpanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.BindingSource expertisesDataSetBindingSource;
        private expertisesDataSet expertisesDataSet;
        private System.Windows.Forms.BindingSource expertisesDataSet2BindingSource;
        private expertisesDataSet2 expertisesDataSet2;
        private expertisesDataSet2TableAdapters.UtilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txt_log;
        private CustomControls.RJControls.RJTextBox txt_pas;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox txt_nom;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txt_pren;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJTextBox txt_mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private WinFormsApp1.CheckBoxCustom cb_valide;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_suprimmer;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_nodifier;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJControls.RJComboBox rjComboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomtypeUtilisateur;
        private System.Windows.Forms.DataGridViewCheckBoxColumn validationDataGridViewCheckBoxColumn;
    }
}
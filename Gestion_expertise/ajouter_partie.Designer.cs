
namespace Gestion_expertise
{
    partial class ajouter_partie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_copier = new System.Windows.Forms.TextBox();
            this.dgv_dem = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_def = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_traiter = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ch_def = new System.Windows.Forms.CheckBox();
            this.ch_dem = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_def)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_copier
            // 
            this.txt_copier.Location = new System.Drawing.Point(12, 157);
            this.txt_copier.Multiline = true;
            this.txt_copier.Name = "txt_copier";
            this.txt_copier.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_copier.Size = new System.Drawing.Size(437, 515);
            this.txt_copier.TabIndex = 0;
            // 
            // dgv_dem
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgv_dem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dem.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_dem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_dem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_dem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.nom});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_dem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_dem.EnableHeadersVisualStyles = false;
            this.dgv_dem.GridColor = System.Drawing.Color.Gray;
            this.dgv_dem.Location = new System.Drawing.Point(469, 48);
            this.dgv_dem.Name = "dgv_dem";
            this.dgv_dem.RowHeadersWidth = 51;
            this.dgv_dem.RowTemplate.Height = 29;
            this.dgv_dem.Size = new System.Drawing.Size(501, 292);
            this.dgv_dem.TabIndex = 3;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 150;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom Complet";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 115);
            this.label1.TabIndex = 5;
            this.label1.Text = "Copier toutes les parties de l\'expertise a partire de site \r\n(www.mahakim.ma)\r\n__" +
    "___________________________________________________________\r\n\r\n Et collez-les ic" +
    "i sans apporter de modifications";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(469, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Demandeur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(469, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Défendeur";
            // 
            // dgv_def
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgv_def.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_def.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_def.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_def.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_def.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_def.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_def.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_def.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_def.EnableHeadersVisualStyles = false;
            this.dgv_def.GridColor = System.Drawing.Color.Gray;
            this.dgv_def.Location = new System.Drawing.Point(469, 379);
            this.dgv_def.Name = "dgv_def";
            this.dgv_def.RowHeadersWidth = 51;
            this.dgv_def.RowTemplate.Height = 29;
            this.dgv_def.Size = new System.Drawing.Size(501, 292);
            this.dgv_def.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Type";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom Complet";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.btn_ajouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_ajouter.Location = new System.Drawing.Point(828, 708);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(142, 32);
            this.btn_ajouter.TabIndex = 27;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_traiter
            // 
            this.btn_traiter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_traiter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_traiter.Location = new System.Drawing.Point(12, 677);
            this.btn_traiter.Name = "btn_traiter";
            this.btn_traiter.Size = new System.Drawing.Size(173, 32);
            this.btn_traiter.TabIndex = 28;
            this.btn_traiter.Text = "Traiter";
            this.btn_traiter.UseVisualStyleBackColor = false;
            this.btn_traiter.Click += new System.EventHandler(this.btn_traiter_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.btn_annuler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_annuler.Location = new System.Drawing.Point(680, 708);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(142, 32);
            this.btn_annuler.TabIndex = 29;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(469, 677);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ajouter :";
            // 
            // ch_def
            // 
            this.ch_def.AutoSize = true;
            this.ch_def.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ch_def.Location = new System.Drawing.Point(540, 677);
            this.ch_def.Name = "ch_def";
            this.ch_def.Size = new System.Drawing.Size(105, 24);
            this.ch_def.TabIndex = 31;
            this.ch_def.Text = "Défendeur";
            this.ch_def.UseVisualStyleBackColor = true;
            // 
            // ch_dem
            // 
            this.ch_dem.AutoSize = true;
            this.ch_dem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ch_dem.Location = new System.Drawing.Point(647, 677);
            this.ch_dem.Name = "ch_dem";
            this.ch_dem.Size = new System.Drawing.Size(113, 24);
            this.ch_dem.TabIndex = 32;
            this.ch_dem.Text = "Demandeur";
            this.ch_dem.UseVisualStyleBackColor = true;
            // 
            // ajouter_partie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.ch_dem);
            this.Controls.Add(this.ch_def);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_traiter);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.dgv_def);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_dem);
            this.Controls.Add(this.txt_copier);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ajouter_partie";
            this.Text = "ajouter_partie";
            this.Load += new System.EventHandler(this.ajouter_partie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_def)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_copier;
        private System.Windows.Forms.DataGridView dgv_dem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_def;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_traiter;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ch_def;
        private System.Windows.Forms.CheckBox ch_dem;
    }
}
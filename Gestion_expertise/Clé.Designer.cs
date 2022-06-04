
namespace Gestion_expertise
{
    partial class Clé
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clé));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_val = new System.Windows.Forms.Label();
            this.label_cle = new System.Windows.Forms.Label();
            this.label_vide = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_valid = new CustomControls.RJControls.RJTextBox();
            this.txt_new = new CustomControls.RJControls.RJTextBox();
            this.txt_cle = new CustomControls.RJControls.RJTextBox();
            this.btn_pass = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.btn_pass);
            this.groupBox2.Controls.Add(this.label_val);
            this.groupBox2.Controls.Add(this.label_cle);
            this.groupBox2.Controls.Add(this.label_vide);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_valid);
            this.groupBox2.Controls.Add(this.txt_new);
            this.groupBox2.Controls.Add(this.txt_cle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(1, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(590, 197);
            this.groupBox2.TabIndex = 151;
            this.groupBox2.TabStop = false;
            // 
            // label_val
            // 
            this.label_val.AutoSize = true;
            this.label_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_val.ForeColor = System.Drawing.Color.Red;
            this.label_val.Location = new System.Drawing.Point(189, 147);
            this.label_val.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_val.Name = "label_val";
            this.label_val.Size = new System.Drawing.Size(176, 13);
            this.label_val.TabIndex = 150;
            this.label_val.Text = "Les deux clé ne sont pas identiques";
            this.label_val.Visible = false;
            // 
            // label_cle
            // 
            this.label_cle.AutoSize = true;
            this.label_cle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cle.ForeColor = System.Drawing.Color.Red;
            this.label_cle.Location = new System.Drawing.Point(189, 51);
            this.label_cle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cle.Name = "label_cle";
            this.label_cle.Size = new System.Drawing.Size(118, 13);
            this.label_cle.TabIndex = 149;
            this.label_cle.Text = "Clé de sécurité incorect";
            this.label_cle.Visible = false;
            // 
            // label_vide
            // 
            this.label_vide.AutoSize = true;
            this.label_vide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vide.ForeColor = System.Drawing.Color.Red;
            this.label_vide.Location = new System.Drawing.Point(410, 171);
            this.label_vide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_vide.Name = "label_vide";
            this.label_vide.Size = new System.Drawing.Size(166, 13);
            this.label_vide.TabIndex = 148;
            this.label_vide.Text = "Tous les champs sont obligatoires";
            this.label_vide.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(7, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 16);
            this.label8.TabIndex = 138;
            this.label8.Text = "Nouveau  clé de sécurité ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 129;
            this.label2.Text = "Clé de sécurité actuel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(7, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 16);
            this.label9.TabIndex = 140;
            this.label9.Text = "Confirmer clé de sécurité ";
            // 
            // txt_valid
            // 
            this.txt_valid.BackColor = System.Drawing.Color.White;
            this.txt_valid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.txt_valid.BorderFocusColor = System.Drawing.SystemColors.ControlDark;
            this.txt_valid.BorderSize = 2;
            this.txt_valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_valid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_valid.Location = new System.Drawing.Point(192, 113);
            this.txt_valid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_valid.Multiline = false;
            this.txt_valid.Name = "txt_valid";
            this.txt_valid.Padding = new System.Windows.Forms.Padding(6);
            this.txt_valid.PasswordChar = true;
            this.txt_valid.Size = new System.Drawing.Size(282, 30);
            this.txt_valid.TabIndex = 141;
            this.txt_valid.Texts = "";
            this.txt_valid.UnderlinedStyle = true;
            // 
            // txt_new
            // 
            this.txt_new.BackColor = System.Drawing.Color.White;
            this.txt_new.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.txt_new.BorderFocusColor = System.Drawing.SystemColors.ControlDark;
            this.txt_new.BorderSize = 2;
            this.txt_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_new.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_new.Location = new System.Drawing.Point(192, 67);
            this.txt_new.Margin = new System.Windows.Forms.Padding(4);
            this.txt_new.Multiline = false;
            this.txt_new.Name = "txt_new";
            this.txt_new.Padding = new System.Windows.Forms.Padding(6);
            this.txt_new.PasswordChar = true;
            this.txt_new.Size = new System.Drawing.Size(282, 30);
            this.txt_new.TabIndex = 139;
            this.txt_new.Texts = "";
            this.txt_new.UnderlinedStyle = true;
            // 
            // txt_cle
            // 
            this.txt_cle.BackColor = System.Drawing.Color.White;
            this.txt_cle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.txt_cle.BorderFocusColor = System.Drawing.SystemColors.ControlDark;
            this.txt_cle.BorderSize = 2;
            this.txt_cle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_cle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cle.Location = new System.Drawing.Point(192, 21);
            this.txt_cle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cle.Multiline = false;
            this.txt_cle.Name = "txt_cle";
            this.txt_cle.Padding = new System.Windows.Forms.Padding(6);
            this.txt_cle.PasswordChar = true;
            this.txt_cle.Size = new System.Drawing.Size(282, 30);
            this.txt_cle.TabIndex = 130;
            this.txt_cle.Texts = "";
            this.txt_cle.UnderlinedStyle = true;
            // 
            // btn_pass
            // 
            this.btn_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pass.BackColor = System.Drawing.Color.Transparent;
            this.btn_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_pass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pass.Image = global::Gestion_expertise.Properties.Resources.save_as_25px;
            this.btn_pass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pass.Location = new System.Drawing.Point(493, 130);
            this.btn_pass.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.Size = new System.Drawing.Size(32, 30);
            this.btn_pass.TabIndex = 152;
            this.btn_pass.UseVisualStyleBackColor = false;
            this.btn_pass.Click += new System.EventHandler(this.btn_pass_Click);
            // 
            // Clé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(592, 199);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Clé";
            this.Text = "Clé de sécurité";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_val;
        private System.Windows.Forms.Label label_cle;
        private System.Windows.Forms.Label label_vide;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private CustomControls.RJControls.RJTextBox txt_valid;
        private CustomControls.RJControls.RJTextBox txt_new;
        private CustomControls.RJControls.RJTextBox txt_cle;
        private System.Windows.Forms.Button btn_pass;
    }
}
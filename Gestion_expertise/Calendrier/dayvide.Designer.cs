
namespace Gestion_expertise.Calandrier
{
    partial class dayvide
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numdaylab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numdaylab
            // 
            this.numdaylab.AutoSize = true;
            this.numdaylab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numdaylab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numdaylab.ForeColor = System.Drawing.Color.Gray;
            this.numdaylab.Location = new System.Drawing.Point(18, 13);
            this.numdaylab.Name = "numdaylab";
            this.numdaylab.Size = new System.Drawing.Size(36, 25);
            this.numdaylab.TabIndex = 1;
            this.numdaylab.Text = "00";
            // 
            // dayvide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.numdaylab);
            this.Name = "dayvide";
            this.Size = new System.Drawing.Size(180, 120);
            this.Load += new System.EventHandler(this.dayvide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numdaylab;
    }
}

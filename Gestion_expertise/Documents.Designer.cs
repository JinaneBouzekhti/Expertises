
namespace Gestion_expertise
{
    partial class Documents
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.défenseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expertisesDataSet = new Gestion_expertise.expertisesDataSet();
            this.demandeurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expertisesDataSet1 = new Gestion_expertise.expertisesDataSet1();
            this.défenseurTableAdapter = new Gestion_expertise.expertisesDataSetTableAdapters.DéfenseurTableAdapter();
            this.expertisesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demandeurTableAdapter = new Gestion_expertise.expertisesDataSet1TableAdapters.DemandeurTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.convocation = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.conteur = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.défenseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandeurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSetBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.convocation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(937, 564);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "GENERATION DES DOCUMMENTS";
            // 
            // défenseurBindingSource
            // 
            this.défenseurBindingSource.DataMember = "Défenseur";
            this.défenseurBindingSource.DataSource = this.expertisesDataSet;
            // 
            // expertisesDataSet
            // 
            this.expertisesDataSet.DataSetName = "expertisesDataSet";
            this.expertisesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // demandeurBindingSource
            // 
            this.demandeurBindingSource.DataMember = "Demandeur";
            this.demandeurBindingSource.DataSource = this.expertisesDataSet1;
            // 
            // expertisesDataSet1
            // 
            this.expertisesDataSet1.DataSetName = "expertisesDataSet1";
            this.expertisesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // défenseurTableAdapter
            // 
            this.défenseurTableAdapter.ClearBeforeFill = true;
            // 
            // expertisesDataSetBindingSource
            // 
            this.expertisesDataSetBindingSource.DataSource = this.expertisesDataSet;
            this.expertisesDataSetBindingSource.Position = 0;
            // 
            // demandeurTableAdapter
            // 
            this.demandeurTableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.convocation);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(931, 400);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // convocation
            // 
            this.convocation.BackColor = System.Drawing.Color.White;
            this.convocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convocation.Controls.Add(this.label3);
            this.convocation.Controls.Add(this.label2);
            this.convocation.Controls.Add(this.pictureBox1);
            this.convocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.convocation.Location = new System.Drawing.Point(3, 3);
            this.convocation.Name = "convocation";
            this.convocation.Size = new System.Drawing.Size(221, 178);
            this.convocation.TabIndex = 31;
            this.convocation.Click += new System.EventHandler(this.btn_exporter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 85);
            this.label3.TabIndex = 2;
            this.label3.Text = "     Ce bouton crée toutes les \r\nconvocations aux parties en \r\nconflit ,toutes ce" +
    "s convocations \r\nsont automatiquement chargées \r\ndans le dossier de l\'affaire.\r\n" +
    "";
            this.label3.Click += new System.EventHandler(this.btn_exporter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "LES \r\nCONVOCATIONS";
            this.label2.Click += new System.EventHandler(this.btn_exporter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(230, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 178);
            this.panel1.TabIndex = 32;
            this.panel1.Click += new System.EventHandler(this.btn_recu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.Location = new System.Drawing.Point(15, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 85);
            this.label4.TabIndex = 2;
            this.label4.Text = "   Ce bouton crée toutes les \r\nreçus aux parties en conflit,\r\ntoutes ces reçus so" +
    "nt\r\nautomatiquement chargées \r\ndans le dossier de l\'affaire.\r\n";
            this.label4.Click += new System.EventHandler(this.btn_recu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 40);
            this.label5.TabIndex = 1;
            this.label5.Text = "LES \r\nREÇUS ";
            this.label5.Click += new System.EventHandler(this.btn_recu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_expertise.Properties.Resources.file_invoice_32px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btn_exporter_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gestion_expertise.Properties.Resources.file_contract_32px;
            this.pictureBox2.Location = new System.Drawing.Point(3, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btn_recu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 107);
            this.panel2.TabIndex = 31;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.conteur, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.progressBar1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(929, 105);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // conteur
            // 
            this.conteur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.conteur.AutoSize = true;
            this.conteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conteur.Location = new System.Drawing.Point(827, 13);
            this.conteur.Name = "conteur";
            this.conteur.Size = new System.Drawing.Size(99, 18);
            this.conteur.TabIndex = 0;
            this.conteur.Text = "13 file sur 120";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.PaleGreen;
            this.progressBar1.Location = new System.Drawing.Point(3, 50);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(923, 36);
            this.progressBar1.TabIndex = 1;
            // 
            // Documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Documents";
            this.Size = new System.Drawing.Size(937, 564);
            this.Load += new System.EventHandler(this.convocation_page_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.défenseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandeurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSetBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.convocation.ResumeLayout(false);
            this.convocation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource défenseurBindingSource;
        private expertisesDataSet expertisesDataSet;
        private expertisesDataSetTableAdapters.DéfenseurTableAdapter défenseurTableAdapter;
        private System.Windows.Forms.BindingSource demandeurBindingSource;
        private expertisesDataSet1 expertisesDataSet1;
        private System.Windows.Forms.BindingSource expertisesDataSetBindingSource;
        private expertisesDataSet1TableAdapters.DemandeurTableAdapter demandeurTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel convocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label conteur;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

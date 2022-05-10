
namespace Gestion_expertise
{
    partial class convocation_page
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomCompletDéfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkdef = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.défenseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expertisesDataSet = new Gestion_expertise.expertisesDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nomCompletDemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portableDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkdem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.demandeurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expertisesDataSet1 = new Gestion_expertise.expertisesDataSet1();
            this.btn_exporter = new System.Windows.Forms.Button();
            this.défenseurTableAdapter = new Gestion_expertise.expertisesDataSetTableAdapters.DéfenseurTableAdapter();
            this.expertisesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demandeurTableAdapter = new Gestion_expertise.expertisesDataSet1TableAdapters.DemandeurTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.défenseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandeurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_exporter, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.737589F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.26241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(937, 564);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomCompletDéfDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.portableDataGridViewTextBoxColumn,
            this.checkdef});
            this.dataGridView1.DataSource = this.défenseurBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(3, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(462, 483);
            this.dataGridView1.TabIndex = 3;
            // 
            // nomCompletDéfDataGridViewTextBoxColumn
            // 
            this.nomCompletDéfDataGridViewTextBoxColumn.DataPropertyName = "NomCompletDéf";
            this.nomCompletDéfDataGridViewTextBoxColumn.HeaderText = "NomCompletDéf";
            this.nomCompletDéfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomCompletDéfDataGridViewTextBoxColumn.Name = "nomCompletDéfDataGridViewTextBoxColumn";
            this.nomCompletDéfDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.Width = 125;
            // 
            // portableDataGridViewTextBoxColumn
            // 
            this.portableDataGridViewTextBoxColumn.DataPropertyName = "Portable";
            this.portableDataGridViewTextBoxColumn.HeaderText = "Portable";
            this.portableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.portableDataGridViewTextBoxColumn.Name = "portableDataGridViewTextBoxColumn";
            this.portableDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkdef
            // 
            this.checkdef.DataPropertyName = "NumDéf";
            this.checkdef.HeaderText = "check";
            this.checkdef.MinimumWidth = 6;
            this.checkdef.Name = "checkdef";
            this.checkdef.ReadOnly = true;
            this.checkdef.Width = 125;
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
            // dataGridView2
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomCompletDemDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn1,
            this.portableDataGridViewTextBoxColumn1,
            this.checkdem});
            this.dataGridView2.DataSource = this.demandeurBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.Gray;
            this.dataGridView2.Location = new System.Drawing.Point(471, 37);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(463, 483);
            this.dataGridView2.TabIndex = 4;
            // 
            // nomCompletDemDataGridViewTextBoxColumn
            // 
            this.nomCompletDemDataGridViewTextBoxColumn.DataPropertyName = "NomCompletDem";
            this.nomCompletDemDataGridViewTextBoxColumn.HeaderText = "NomCompletDem";
            this.nomCompletDemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomCompletDemDataGridViewTextBoxColumn.Name = "nomCompletDemDataGridViewTextBoxColumn";
            this.nomCompletDemDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresseDataGridViewTextBoxColumn1
            // 
            this.adresseDataGridViewTextBoxColumn1.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn1.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.adresseDataGridViewTextBoxColumn1.Name = "adresseDataGridViewTextBoxColumn1";
            this.adresseDataGridViewTextBoxColumn1.Width = 125;
            // 
            // portableDataGridViewTextBoxColumn1
            // 
            this.portableDataGridViewTextBoxColumn1.DataPropertyName = "Portable";
            this.portableDataGridViewTextBoxColumn1.HeaderText = "Portable";
            this.portableDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.portableDataGridViewTextBoxColumn1.Name = "portableDataGridViewTextBoxColumn1";
            this.portableDataGridViewTextBoxColumn1.Width = 125;
            // 
            // checkdem
            // 
            this.checkdem.DataPropertyName = "NumDem";
            this.checkdem.HeaderText = "chek";
            this.checkdem.MinimumWidth = 6;
            this.checkdem.Name = "checkdem";
            this.checkdem.ReadOnly = true;
            this.checkdem.Width = 125;
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
            // btn_exporter
            // 
            this.btn_exporter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_exporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            this.btn_exporter.Location = new System.Drawing.Point(769, 527);
            this.btn_exporter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exporter.Name = "btn_exporter";
            this.btn_exporter.Size = new System.Drawing.Size(165, 32);
            this.btn_exporter.TabIndex = 27;
            this.btn_exporter.Text = "Exporter";
            this.btn_exporter.UseVisualStyleBackColor = false;
            this.btn_exporter.Click += new System.EventHandler(this.btn_exporter_Click);
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
            // convocation_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "convocation_page";
            this.Size = new System.Drawing.Size(937, 564);
            this.Load += new System.EventHandler(this.convocation_page_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.défenseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandeurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertisesDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource défenseurBindingSource;
        private expertisesDataSet expertisesDataSet;
        private System.Windows.Forms.DataGridView dataGridView2;
        private expertisesDataSetTableAdapters.DéfenseurTableAdapter défenseurTableAdapter;
        private System.Windows.Forms.BindingSource demandeurBindingSource;
        private expertisesDataSet1 expertisesDataSet1;
        private System.Windows.Forms.BindingSource expertisesDataSetBindingSource;
        private expertisesDataSet1TableAdapters.DemandeurTableAdapter demandeurTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCompletDemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn portableDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCompletDéfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkdef;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkdem;
        private System.Windows.Forms.Button btn_exporter;
    }
}

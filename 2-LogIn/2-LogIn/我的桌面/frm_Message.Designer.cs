namespace _2_LogIn
{
    partial class frm_Message
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
            this.gv_Notice = new System.Windows.Forms.DataGridView();
            this.educationalSystemDataSet1 = new _2_LogIn.EducationalSystemDataSet1();
            this.tbMessegeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_MessegeTableAdapter = new _2_LogIn.EducationalSystemDataSet1TableAdapters.tb_MessegeTableAdapter();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Notice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationalSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMessegeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Notice
            // 
            this.gv_Notice.AutoGenerateColumns = false;
            this.gv_Notice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Notice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Title,
            this.Detail,
            this.Category,
            this.Sender,
            this.SendTime,
            this.Status});
            this.gv_Notice.DataSource = this.tbMessegeBindingSource;
            this.gv_Notice.Location = new System.Drawing.Point(12, 43);
            this.gv_Notice.Name = "gv_Notice";
            this.gv_Notice.ReadOnly = true;
            this.gv_Notice.RowTemplate.Height = 30;
            this.gv_Notice.Size = new System.Drawing.Size(1189, 493);
            this.gv_Notice.TabIndex = 8;
            this.gv_Notice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Notice_CellContentClick);
            // 
            // educationalSystemDataSet1
            // 
            this.educationalSystemDataSet1.DataSetName = "EducationalSystemDataSet1";
            this.educationalSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMessegeBindingSource
            // 
            this.tbMessegeBindingSource.DataMember = "tb_Messege";
            this.tbMessegeBindingSource.DataSource = this.educationalSystemDataSet1;
            // 
            // tb_MessegeTableAdapter
            // 
            this.tb_MessegeTableAdapter.ClearBeforeFill = true;
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "Detail";
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Sender
            // 
            this.Sender.DataPropertyName = "Sender";
            this.Sender.HeaderText = "Sender";
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            // 
            // SendTime
            // 
            this.SendTime.DataPropertyName = "SendTime";
            this.SendTime.HeaderText = "SendTime";
            this.SendTime.Name = "SendTime";
            this.SendTime.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // frm_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 579);
            this.Controls.Add(this.gv_Notice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Message";
            this.Text = "frm_Message";
            this.Load += new System.EventHandler(this.frm_Message_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Notice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationalSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMessegeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Notice;
        private EducationalSystemDataSet1 educationalSystemDataSet1;
        private System.Windows.Forms.BindingSource tbMessegeBindingSource;
        private EducationalSystemDataSet1TableAdapters.tb_MessegeTableAdapter tb_MessegeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
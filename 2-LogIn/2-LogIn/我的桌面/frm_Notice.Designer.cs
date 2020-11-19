namespace _2_LogIn
{
    partial class frm_Notice
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
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNoticeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationalSystemDataSet = new _2_LogIn.EducationalSystemDataSet();
            this.tb_NoticeTableAdapter = new _2_LogIn.EducationalSystemDataSetTableAdapters.tb_NoticeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Notice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNoticeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationalSystemDataSet)).BeginInit();
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
            this.gv_Notice.DataSource = this.tbNoticeBindingSource;
            this.gv_Notice.Location = new System.Drawing.Point(12, 12);
            this.gv_Notice.Name = "gv_Notice";
            this.gv_Notice.ReadOnly = true;
            this.gv_Notice.RowTemplate.Height = 30;
            this.gv_Notice.Size = new System.Drawing.Size(1189, 493);
            this.gv_Notice.TabIndex = 7;
            this.gv_Notice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Notice_CellContentClick);
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
            // tbNoticeBindingSource
            // 
            this.tbNoticeBindingSource.DataMember = "tb_Notice";
            this.tbNoticeBindingSource.DataSource = this.educationalSystemDataSet;
            // 
            // educationalSystemDataSet
            // 
            this.educationalSystemDataSet.DataSetName = "EducationalSystemDataSet";
            this.educationalSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_NoticeTableAdapter
            // 
            this.tb_NoticeTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 579);
            this.Controls.Add(this.gv_Notice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Notice";
            this.Text = "frm_Notice";
            this.Load += new System.EventHandler(this.frm_Notice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Notice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNoticeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationalSystemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Notice;
        private EducationalSystemDataSet educationalSystemDataSet;
        private System.Windows.Forms.BindingSource tbNoticeBindingSource;
        private EducationalSystemDataSetTableAdapters.tb_NoticeTableAdapter tb_NoticeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.noticeData = new _2_LogIn.NoticeData();
            this.tbNoticeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_NoticeTableAdapter = new _2_LogIn.NoticeDataTableAdapters.tb_NoticeTableAdapter();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Notice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNoticeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Notice
            // 
            this.gv_Notice.AutoGenerateColumns = false;
            this.gv_Notice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Notice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.detailDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.senderDataGridViewTextBoxColumn,
            this.sendTimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.gv_Notice.DataSource = this.tbNoticeBindingSource;
            this.gv_Notice.Location = new System.Drawing.Point(40, 29);
            this.gv_Notice.Name = "gv_Notice";
            this.gv_Notice.RowTemplate.Height = 30;
            this.gv_Notice.Size = new System.Drawing.Size(1120, 467);
            this.gv_Notice.TabIndex = 0;
            this.gv_Notice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Notice_CellContentClick);
            // 
            // noticeData
            // 
            this.noticeData.DataSetName = "NoticeData";
            this.noticeData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNoticeBindingSource
            // 
            this.tbNoticeBindingSource.DataMember = "tb_Notice";
            this.tbNoticeBindingSource.DataSource = this.noticeData;
            // 
            // tb_NoticeTableAdapter
            // 
            this.tb_NoticeTableAdapter.ClearBeforeFill = true;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // detailDataGridViewTextBoxColumn
            // 
            this.detailDataGridViewTextBoxColumn.DataPropertyName = "Detail";
            this.detailDataGridViewTextBoxColumn.HeaderText = "Detail";
            this.detailDataGridViewTextBoxColumn.Name = "detailDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // senderDataGridViewTextBoxColumn
            // 
            this.senderDataGridViewTextBoxColumn.DataPropertyName = "Sender";
            this.senderDataGridViewTextBoxColumn.HeaderText = "Sender";
            this.senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            // 
            // sendTimeDataGridViewTextBoxColumn
            // 
            this.sendTimeDataGridViewTextBoxColumn.DataPropertyName = "SendTime";
            this.sendTimeDataGridViewTextBoxColumn.HeaderText = "SendTime";
            this.sendTimeDataGridViewTextBoxColumn.Name = "sendTimeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // frm_Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 523);
            this.Controls.Add(this.gv_Notice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Notice";
            this.Text = "frm_Notice";
            this.Load += new System.EventHandler(this.frm_Notice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Notice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNoticeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Notice;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NoticeData noticeData;
        private System.Windows.Forms.BindingSource tbNoticeBindingSource;
        private NoticeDataTableAdapters.tb_NoticeTableAdapter tb_NoticeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
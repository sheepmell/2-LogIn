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
            this.tbNoticeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noticeData = new _2_LogIn.NoticeData();
            this.tb_NoticeTableAdapter = new _2_LogIn.NoticeDataTableAdapters.tb_NoticeTableAdapter();
            this.gv_NoticeReply = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Notice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNoticeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NoticeReply)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Notice
            // 
            this.gv_Notice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Notice.Location = new System.Drawing.Point(34, 25);
            this.gv_Notice.Name = "gv_Notice";
            this.gv_Notice.RowTemplate.Height = 30;
            this.gv_Notice.Size = new System.Drawing.Size(1485, 467);
            this.gv_Notice.TabIndex = 0;
            this.gv_Notice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Notice_CellContentClick);
            // 
            // tbNoticeBindingSource
            // 
            this.tbNoticeBindingSource.DataMember = "tb_Notice";
            this.tbNoticeBindingSource.DataSource = this.noticeData;
            // 
            // noticeData
            // 
            this.noticeData.DataSetName = "NoticeData";
            this.noticeData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_NoticeTableAdapter
            // 
            this.tb_NoticeTableAdapter.ClearBeforeFill = true;
            // 
            // gv_NoticeReply
            // 
            this.gv_NoticeReply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_NoticeReply.Location = new System.Drawing.Point(34, 533);
            this.gv_NoticeReply.Name = "gv_NoticeReply";
            this.gv_NoticeReply.RowTemplate.Height = 30;
            this.gv_NoticeReply.Size = new System.Drawing.Size(1485, 185);
            this.gv_NoticeReply.TabIndex = 1;
            // 
            // frm_Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 803);
            this.Controls.Add(this.gv_NoticeReply);
            this.Controls.Add(this.gv_Notice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Notice";
            this.Text = "frm_Notice";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Notice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNoticeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NoticeReply)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Notice;
        private NoticeData noticeData;
        private System.Windows.Forms.BindingSource tbNoticeBindingSource;
        private NoticeDataTableAdapters.tb_NoticeTableAdapter tb_NoticeTableAdapter;
        private System.Windows.Forms.DataGridView gv_NoticeReply;
    }
}
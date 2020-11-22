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
            this.gv_Message = new System.Windows.Forms.DataGridView();
            this.messageData = new _2_LogIn.MessageData();
            this.tbMessegeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_MessegeTableAdapter = new _2_LogIn.MessageDataTableAdapters.tb_MessegeTableAdapter();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMessegeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Message
            // 
            this.gv_Message.AutoGenerateColumns = false;
            this.gv_Message.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Message.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.detailDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.senderDataGridViewTextBoxColumn,
            this.sendTimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.gv_Message.DataSource = this.tbMessegeBindingSource;
            this.gv_Message.Location = new System.Drawing.Point(43, 26);
            this.gv_Message.Name = "gv_Message";
            this.gv_Message.RowTemplate.Height = 30;
            this.gv_Message.Size = new System.Drawing.Size(1120, 467);
            this.gv_Message.TabIndex = 0;
            this.gv_Message.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // messageData
            // 
            this.messageData.DataSetName = "MessageData";
            this.messageData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMessegeBindingSource
            // 
            this.tbMessegeBindingSource.DataMember = "tb_Messege";
            this.tbMessegeBindingSource.DataSource = this.messageData;
            // 
            // tb_MessegeTableAdapter
            // 
            this.tb_MessegeTableAdapter.ClearBeforeFill = true;
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
            // frm_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 523);
            this.Controls.Add(this.gv_Message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Message";
            this.Text = "frm_Message";
            this.Load += new System.EventHandler(this.frm_Message_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMessegeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Message;
        private MessageData messageData;
        private System.Windows.Forms.BindingSource tbMessegeBindingSource;
        private MessageDataTableAdapters.tb_MessegeTableAdapter tb_MessegeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
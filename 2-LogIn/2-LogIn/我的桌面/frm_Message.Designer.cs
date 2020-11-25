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
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.No,
            this.Title,
            this.Detail,
            this.Category,
            this.Sender,
            this.SendTime,
            this.Status});
            this.gv_Message.DataSource = this.tbMessegeBindingSource;
            this.gv_Message.Location = new System.Drawing.Point(36, 26);
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
            // No
            // 
            this.No.DataPropertyName = "No";
            this.No.HeaderText = "No";
            this.No.Name = "No";
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "Detail";
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Sender
            // 
            this.Sender.DataPropertyName = "Sender";
            this.Sender.HeaderText = "Sender";
            this.Sender.Name = "Sender";
            // 
            // SendTime
            // 
            this.SendTime.DataPropertyName = "SendTime";
            this.SendTime.HeaderText = "SendTime";
            this.SendTime.Name = "SendTime";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
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
            this.tbMessegeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageData = new _2_LogIn.MessageData();
            this.tb_MessegeTableAdapter = new _2_LogIn.MessageDataTableAdapters.tb_MessegeTableAdapter();
            this.gv_MessageReply = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMessegeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_MessageReply)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Message
            // 
            this.gv_Message.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Message.Location = new System.Drawing.Point(36, 26);
            this.gv_Message.Name = "gv_Message";
            this.gv_Message.RowTemplate.Height = 30;
            this.gv_Message.Size = new System.Drawing.Size(1490, 467);
            this.gv_Message.TabIndex = 0;
            this.gv_Message.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbMessegeBindingSource
            // 
            this.tbMessegeBindingSource.DataMember = "tb_Messege";
            this.tbMessegeBindingSource.DataSource = this.messageData;
            // 
            // messageData
            // 
            this.messageData.DataSetName = "MessageData";
            this.messageData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_MessegeTableAdapter
            // 
            this.tb_MessegeTableAdapter.ClearBeforeFill = true;
            // 
            // gv_MessageReply
            // 
            this.gv_MessageReply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_MessageReply.Location = new System.Drawing.Point(36, 538);
            this.gv_MessageReply.Name = "gv_MessageReply";
            this.gv_MessageReply.RowTemplate.Height = 30;
            this.gv_MessageReply.Size = new System.Drawing.Size(1490, 185);
            this.gv_MessageReply.TabIndex = 2;
            // 
            // frm_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 803);
            this.Controls.Add(this.gv_MessageReply);
            this.Controls.Add(this.gv_Message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Message";
            this.Text = "frm_Message";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMessegeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_MessageReply)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Message;
        private MessageData messageData;
        private System.Windows.Forms.BindingSource tbMessegeBindingSource;
        private MessageDataTableAdapters.tb_MessegeTableAdapter tb_MessegeTableAdapter;
        private System.Windows.Forms.DataGridView gv_MessageReply;
    }
}
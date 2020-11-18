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
            this.gv_Message = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Message)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Message
            // 
            this.gv_Message.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Message.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Title,
            this.Category,
            this.Sender,
            this.SendTime,
            this.Operation});
            this.gv_Message.Location = new System.Drawing.Point(41, 35);
            this.gv_Message.Name = "gv_Message";
            this.gv_Message.RowTemplate.Height = 30;
            this.gv_Message.Size = new System.Drawing.Size(1106, 490);
            this.gv_Message.TabIndex = 8;
            // 
            // No
            // 
            this.No.HeaderText = "序号";
            this.No.Name = "No";
            // 
            // Title
            // 
            this.Title.HeaderText = "标题";
            this.Title.Name = "Title";
            this.Title.Width = 500;
            // 
            // Category
            // 
            this.Category.HeaderText = "类别";
            this.Category.Name = "Category";
            // 
            // Sender
            // 
            this.Sender.HeaderText = "发送人";
            this.Sender.Name = "Sender";
            // 
            // SendTime
            // 
            this.SendTime.HeaderText = "发送时间";
            this.SendTime.Name = "SendTime";
            this.SendTime.Width = 120;
            // 
            // Operation
            // 
            this.Operation.HeaderText = "操作";
            this.Operation.Name = "Operation";
            // 
            // frm_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 579);
            this.Controls.Add(this.gv_Message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Message";
            this.Text = "frm_Message";
            this.Load += new System.EventHandler(this.frm_Message_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Message)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
    }
}
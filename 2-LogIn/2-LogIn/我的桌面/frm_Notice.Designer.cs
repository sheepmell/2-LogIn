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
            this.gv_Notice = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Notice)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Notice
            // 
            this.gv_Notice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Notice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Title,
            this.Category,
            this.Sender,
            this.SendTime,
            this.Operation});
            this.gv_Notice.Location = new System.Drawing.Point(12, 12);
            this.gv_Notice.Name = "gv_Notice";
            this.gv_Notice.RowTemplate.Height = 30;
            this.gv_Notice.Size = new System.Drawing.Size(1106, 490);
            this.gv_Notice.TabIndex = 7;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Notice;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
    }
}
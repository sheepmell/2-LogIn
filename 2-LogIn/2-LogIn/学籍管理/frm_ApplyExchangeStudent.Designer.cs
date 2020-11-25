namespace _2_LogIn
{
    partial class frm_ApplyExchangeStudent
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
            this.gv_Apply = new System.Windows.Forms.DataGridView();
            this.Opeartion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.终审状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.当前状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学籍状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.允许调配 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.专业 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学校 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.交换学期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学生 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Apply)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Apply
            // 
            this.gv_Apply.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Apply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Apply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学生,
            this.交换学期,
            this.学校,
            this.专业,
            this.允许调配,
            this.学籍状态,
            this.当前状态,
            this.终审状态,
            this.Opeartion});
            this.gv_Apply.Location = new System.Drawing.Point(35, 28);
            this.gv_Apply.Name = "gv_Apply";
            this.gv_Apply.RowTemplate.Height = 30;
            this.gv_Apply.Size = new System.Drawing.Size(1120, 467);
            this.gv_Apply.TabIndex = 1;
            // 
            // Opeartion
            // 
            this.Opeartion.HeaderText = "操作";
            this.Opeartion.Name = "Opeartion";
            // 
            // 终审状态
            // 
            this.终审状态.HeaderText = "终审状态";
            this.终审状态.Name = "终审状态";
            // 
            // 当前状态
            // 
            this.当前状态.HeaderText = "当前状态";
            this.当前状态.Name = "当前状态";
            // 
            // 学籍状态
            // 
            this.学籍状态.HeaderText = "学籍状态";
            this.学籍状态.Name = "学籍状态";
            // 
            // 允许调配
            // 
            this.允许调配.HeaderText = "允许调配";
            this.允许调配.Name = "允许调配";
            // 
            // 专业
            // 
            this.专业.HeaderText = "专业";
            this.专业.Name = "专业";
            // 
            // 学校
            // 
            this.学校.HeaderText = "学校";
            this.学校.Name = "学校";
            // 
            // 交换学期
            // 
            this.交换学期.HeaderText = "交换学期";
            this.交换学期.Name = "交换学期";
            // 
            // 学生
            // 
            this.学生.HeaderText = "学生";
            this.学生.Name = "学生";
            // 
            // frm_ApplyExchangeStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 523);
            this.Controls.Add(this.gv_Apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ApplyExchangeStudent";
            this.Text = "frm_ApplyExchangeStudent";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Apply)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Apply;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生;
        private System.Windows.Forms.DataGridViewTextBoxColumn 交换学期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学校;
        private System.Windows.Forms.DataGridViewTextBoxColumn 专业;
        private System.Windows.Forms.DataGridViewTextBoxColumn 允许调配;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学籍状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 当前状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 终审状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opeartion;
    }
}
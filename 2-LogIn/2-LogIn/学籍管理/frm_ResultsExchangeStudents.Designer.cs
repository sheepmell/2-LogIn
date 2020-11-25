namespace _2_LogIn
{
    partial class frm_ResultsExchangeStudents
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
            this.gv_Results = new System.Windows.Forms.DataGridView();
            this.学生 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学年学期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总学时 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.终审状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opeartion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Results)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Results
            // 
            this.gv_Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学生,
            this.学年学期,
            this.课程号,
            this.课程名称,
            this.总成绩,
            this.总学时,
            this.学分,
            this.终审状态,
            this.Opeartion});
            this.gv_Results.Location = new System.Drawing.Point(35, 28);
            this.gv_Results.Name = "gv_Results";
            this.gv_Results.RowTemplate.Height = 30;
            this.gv_Results.Size = new System.Drawing.Size(1120, 467);
            this.gv_Results.TabIndex = 2;
            // 
            // 学生
            // 
            this.学生.HeaderText = "学生";
            this.学生.Name = "学生";
            // 
            // 学年学期
            // 
            this.学年学期.HeaderText = "学年学期";
            this.学年学期.Name = "学年学期";
            // 
            // 课程号
            // 
            this.课程号.HeaderText = "课程号";
            this.课程号.Name = "课程号";
            // 
            // 课程名称
            // 
            this.课程名称.HeaderText = "课程名称";
            this.课程名称.Name = "课程名称";
            // 
            // 总成绩
            // 
            this.总成绩.HeaderText = "总成绩";
            this.总成绩.Name = "总成绩";
            // 
            // 总学时
            // 
            this.总学时.HeaderText = "总学时";
            this.总学时.Name = "总学时";
            // 
            // 学分
            // 
            this.学分.HeaderText = "学分";
            this.学分.Name = "学分";
            // 
            // 终审状态
            // 
            this.终审状态.HeaderText = "终审状态";
            this.终审状态.Name = "终审状态";
            // 
            // Opeartion
            // 
            this.Opeartion.HeaderText = "操作";
            this.Opeartion.Name = "Opeartion";
            // 
            // frm_ResultsExchangeStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 523);
            this.Controls.Add(this.gv_Results);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ResultsExchangeStudents";
            this.Text = "frm_ResultsExchangeStudents";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Results;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学年学期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总学时;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学分;
        private System.Windows.Forms.DataGridViewTextBoxColumn 终审状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opeartion;
    }
}
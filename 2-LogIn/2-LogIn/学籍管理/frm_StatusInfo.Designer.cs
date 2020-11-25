namespace _2_LogIn
{
    partial class frm_StatusInfo
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
            this.gv_Info = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改字段 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改信息 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.审核状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opeartion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Info
            // 
            this.gv_Info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.学号,
            this.姓名,
            this.修改字段,
            this.修改信息,
            this.审核状态,
            this.修改时间,
            this.Opeartion});
            this.gv_Info.Location = new System.Drawing.Point(26, 30);
            this.gv_Info.Name = "gv_Info";
            this.gv_Info.RowTemplate.Height = 30;
            this.gv_Info.Size = new System.Drawing.Size(1120, 467);
            this.gv_Info.TabIndex = 2;
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            // 
            // 学号
            // 
            this.学号.HeaderText = "学号";
            this.学号.Name = "学号";
            // 
            // 姓名
            // 
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            // 
            // 修改字段
            // 
            this.修改字段.HeaderText = "修改字段";
            this.修改字段.Name = "修改字段";
            // 
            // 修改信息
            // 
            this.修改信息.HeaderText = "修改信息";
            this.修改信息.Name = "修改信息";
            // 
            // 审核状态
            // 
            this.审核状态.HeaderText = "审核状态";
            this.审核状态.Name = "审核状态";
            // 
            // 修改时间
            // 
            this.修改时间.HeaderText = "修改时间";
            this.修改时间.Name = "修改时间";
            // 
            // Opeartion
            // 
            this.Opeartion.HeaderText = "操作";
            this.Opeartion.Name = "Opeartion";
            // 
            // frm_StatusInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 523);
            this.Controls.Add(this.gv_Info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_StatusInfo";
            this.Text = "学籍信息管理";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修改字段;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修改信息;
        private System.Windows.Forms.DataGridViewTextBoxColumn 审核状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修改时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opeartion;
    }
}
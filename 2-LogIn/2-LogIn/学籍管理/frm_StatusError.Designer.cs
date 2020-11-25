namespace _2_LogIn
{
    partial class frm_StatusError
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
            this.gv_StatusError = new System.Windows.Forms.DataGridView();
            this.原班级 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.原学籍 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.新学院 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.新专业 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.新班级 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.新学籍 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.新状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.异动类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.终审状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_StatusError)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_StatusError
            // 
            this.gv_StatusError.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_StatusError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_StatusError.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.原班级,
            this.原学籍,
            this.新学院,
            this.新专业,
            this.新班级,
            this.新学籍,
            this.新状态,
            this.异动类别,
            this.终审状态});
            this.gv_StatusError.Location = new System.Drawing.Point(35, 28);
            this.gv_StatusError.Name = "gv_StatusError";
            this.gv_StatusError.RowTemplate.Height = 30;
            this.gv_StatusError.Size = new System.Drawing.Size(1120, 467);
            this.gv_StatusError.TabIndex = 1;
            // 
            // 原班级
            // 
            this.原班级.HeaderText = "原班级";
            this.原班级.Name = "原班级";
            // 
            // 原学籍
            // 
            this.原学籍.HeaderText = "原学籍";
            this.原学籍.Name = "原学籍";
            // 
            // 新学院
            // 
            this.新学院.HeaderText = "新学院";
            this.新学院.Name = "新学院";
            // 
            // 新专业
            // 
            this.新专业.HeaderText = "新专业";
            this.新专业.Name = "新专业";
            // 
            // 新班级
            // 
            this.新班级.HeaderText = "新班级";
            this.新班级.Name = "新班级";
            // 
            // 新学籍
            // 
            this.新学籍.HeaderText = "新学籍";
            this.新学籍.Name = "新学籍";
            // 
            // 新状态
            // 
            this.新状态.HeaderText = "新状态";
            this.新状态.Name = "新状态";
            // 
            // 异动类别
            // 
            this.异动类别.HeaderText = "异动类别";
            this.异动类别.Name = "异动类别";
            // 
            // 终审状态
            // 
            this.终审状态.HeaderText = "终审状态";
            this.终审状态.Name = "终审状态";
            // 
            // frm_StatusError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 523);
            this.Controls.Add(this.gv_StatusError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_StatusError";
            this.Text = "frm_StatusError";
            ((System.ComponentModel.ISupportInitialize)(this.gv_StatusError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_StatusError;
        private System.Windows.Forms.DataGridViewTextBoxColumn 原班级;
        private System.Windows.Forms.DataGridViewTextBoxColumn 原学籍;
        private System.Windows.Forms.DataGridViewTextBoxColumn 新学院;
        private System.Windows.Forms.DataGridViewTextBoxColumn 新专业;
        private System.Windows.Forms.DataGridViewTextBoxColumn 新班级;
        private System.Windows.Forms.DataGridViewTextBoxColumn 新学籍;
        private System.Windows.Forms.DataGridViewTextBoxColumn 新状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 异动类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 终审状态;
    }
}
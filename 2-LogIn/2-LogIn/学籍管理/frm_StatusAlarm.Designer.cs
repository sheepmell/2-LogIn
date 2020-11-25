namespace _2_LogIn
{
    partial class frm_StatusAlarm
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
            this.gv_StatusAlarm = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlarmTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_StatusAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_StatusAlarm
            // 
            this.gv_StatusAlarm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_StatusAlarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_StatusAlarm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.AlarmTerm,
            this.result,
            this.Tips});
            this.gv_StatusAlarm.Location = new System.Drawing.Point(35, 28);
            this.gv_StatusAlarm.Name = "gv_StatusAlarm";
            this.gv_StatusAlarm.RowTemplate.Height = 30;
            this.gv_StatusAlarm.Size = new System.Drawing.Size(1120, 467);
            this.gv_StatusAlarm.TabIndex = 1;
            // 
            // No
            // 
            this.No.HeaderText = "序号";
            this.No.Name = "No";
            // 
            // AlarmTerm
            // 
            this.AlarmTerm.HeaderText = "预警学期";
            this.AlarmTerm.Name = "AlarmTerm";
            // 
            // result
            // 
            this.result.HeaderText = "处理结果";
            this.result.Name = "result";
            // 
            // Tips
            // 
            this.Tips.HeaderText = "提示信息";
            this.Tips.Name = "Tips";
            // 
            // frm_StatusAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 523);
            this.Controls.Add(this.gv_StatusAlarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_StatusAlarm";
            this.Text = "frm_StatusAlarm";
            ((System.ComponentModel.ISupportInitialize)(this.gv_StatusAlarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_StatusAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tips;
    }
}
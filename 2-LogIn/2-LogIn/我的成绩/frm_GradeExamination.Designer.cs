namespace _2_LogIn
{
    partial class frm_GradeExamination
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
            this.gv_ExamResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ExamResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_ExamResult
            // 
            this.gv_ExamResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_ExamResult.Location = new System.Drawing.Point(35, 23);
            this.gv_ExamResult.Name = "gv_ExamResult";
            this.gv_ExamResult.RowTemplate.Height = 30;
            this.gv_ExamResult.Size = new System.Drawing.Size(1120, 467);
            this.gv_ExamResult.TabIndex = 0;
            // 
            // frm_GradeExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 523);
            this.Controls.Add(this.gv_ExamResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_GradeExamination";
            this.Text = "frm_GradeExamination";
            ((System.ComponentModel.ISupportInitialize)(this.gv_ExamResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_ExamResult;
    }
}
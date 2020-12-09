namespace _2_LogIn
{
    partial class frm_SocialExaminationRegistration
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
            this.btn_Reject = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.dgv_SelectedExams = new System.Windows.Forms.DataGridView();
            this.dgv_AllExams = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectedExams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllExams)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Reject
            // 
            this.btn_Reject.Location = new System.Drawing.Point(795, 244);
            this.btn_Reject.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reject.Name = "btn_Reject";
            this.btn_Reject.Size = new System.Drawing.Size(112, 35);
            this.btn_Reject.TabIndex = 11;
            this.btn_Reject.Text = "退考↑";
            this.btn_Reject.UseVisualStyleBackColor = true;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(283, 244);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(109, 35);
            this.btn_Select.TabIndex = 10;
            this.btn_Select.Text = "选考↓";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // dgv_SelectedExams
            // 
            this.dgv_SelectedExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectedExams.Location = new System.Drawing.Point(283, 298);
            this.dgv_SelectedExams.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_SelectedExams.Name = "dgv_SelectedExams";
            this.dgv_SelectedExams.RowTemplate.Height = 23;
            this.dgv_SelectedExams.Size = new System.Drawing.Size(624, 212);
            this.dgv_SelectedExams.TabIndex = 9;
            // 
            // dgv_AllExams
            // 
            this.dgv_AllExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllExams.Location = new System.Drawing.Point(283, 13);
            this.dgv_AllExams.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_AllExams.Name = "dgv_AllExams";
            this.dgv_AllExams.RowTemplate.Height = 23;
            this.dgv_AllExams.Size = new System.Drawing.Size(624, 205);
            this.dgv_AllExams.TabIndex = 8;
            // 
            // frm_SocialExaminationRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 523);
            this.Controls.Add(this.btn_Reject);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.dgv_SelectedExams);
            this.Controls.Add(this.dgv_AllExams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SocialExaminationRegistration";
            this.Text = "frm_SocialExaminationRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectedExams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllExams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Reject;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.DataGridView dgv_SelectedExams;
        private System.Windows.Forms.DataGridView dgv_AllExams;
    }
}
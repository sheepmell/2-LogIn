namespace _2_LogIn
{
    partial class frm_StudentCoursSelectionCenter
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
            this.dgv_SelectedCourses = new System.Windows.Forms.DataGridView();
            this.dgv_AllCourses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectedCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Reject
            // 
            this.btn_Reject.Location = new System.Drawing.Point(795, 244);
            this.btn_Reject.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reject.Name = "btn_Reject";
            this.btn_Reject.Size = new System.Drawing.Size(112, 35);
            this.btn_Reject.TabIndex = 7;
            this.btn_Reject.Text = "退选↑";
            this.btn_Reject.UseVisualStyleBackColor = true;
            this.btn_Reject.Click += new System.EventHandler(this.btn_Reject_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(283, 244);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(109, 35);
            this.btn_Select.TabIndex = 6;
            this.btn_Select.Text = "选修↓";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // dgv_SelectedCourses
            // 
            this.dgv_SelectedCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectedCourses.Location = new System.Drawing.Point(283, 298);
            this.dgv_SelectedCourses.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_SelectedCourses.Name = "dgv_SelectedCourses";
            this.dgv_SelectedCourses.RowTemplate.Height = 23;
            this.dgv_SelectedCourses.Size = new System.Drawing.Size(624, 212);
            this.dgv_SelectedCourses.TabIndex = 5;
            // 
            // dgv_AllCourses
            // 
            this.dgv_AllCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllCourses.Location = new System.Drawing.Point(283, 13);
            this.dgv_AllCourses.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_AllCourses.Name = "dgv_AllCourses";
            this.dgv_AllCourses.RowTemplate.Height = 23;
            this.dgv_AllCourses.Size = new System.Drawing.Size(624, 205);
            this.dgv_AllCourses.TabIndex = 4;
            // 
            // frm_StudentCoursSelectionCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 523);
            this.Controls.Add(this.btn_Reject);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.dgv_SelectedCourses);
            this.Controls.Add(this.dgv_AllCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_StudentCoursSelectionCenter";
            this.Text = "frm_StudentCoursSelectionCenter";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectedCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Reject;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.DataGridView dgv_SelectedCourses;
        private System.Windows.Forms.DataGridView dgv_AllCourses;
    }
}
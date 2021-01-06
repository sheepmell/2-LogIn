namespace _2_LogIn
{
    partial class frm_MyScore
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
            this.gv_Score = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Score)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Score
            // 
            this.gv_Score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Score.Location = new System.Drawing.Point(66, 36);
            this.gv_Score.Name = "gv_Score";
            this.gv_Score.RowTemplate.Height = 30;
            this.gv_Score.Size = new System.Drawing.Size(1431, 730);
            this.gv_Score.TabIndex = 0;
            // 
            // frm_MyScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 803);
            this.Controls.Add(this.gv_Score);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MyScore";
            this.Text = "frm_MyScore";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Score)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Score;
    }
}
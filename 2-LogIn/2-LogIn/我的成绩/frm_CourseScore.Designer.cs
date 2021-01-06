namespace _2_LogIn
{
    partial class frm_CourseScore
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
            this.btn_Query = new System.Windows.Forms.Button();
            this.gv_CourseMessage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CourseMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(744, 69);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 31);
            this.btn_Query.TabIndex = 9;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // gv_CourseMessage
            // 
            this.gv_CourseMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_CourseMessage.Location = new System.Drawing.Point(54, 124);
            this.gv_CourseMessage.Name = "gv_CourseMessage";
            this.gv_CourseMessage.RowTemplate.Height = 30;
            this.gv_CourseMessage.Size = new System.Drawing.Size(1440, 560);
            this.gv_CourseMessage.TabIndex = 10;
            // 
            // frm_CourseScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 803);
            this.Controls.Add(this.gv_CourseMessage);
            this.Controls.Add(this.btn_Query);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CourseScore";
            this.Text = "frm_CourseScore";
            ((System.ComponentModel.ISupportInitialize)(this.gv_CourseMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.DataGridView gv_CourseMessage;
    }
}
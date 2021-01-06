namespace _2_LogIn
{
    partial class frm_BookSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Term = new System.Windows.Forms.ComboBox();
            this.gv_Books = new System.Windows.Forms.DataGridView();
            this.btn_Query = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Books)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "学期：";
            // 
            // cmb_Term
            // 
            this.cmb_Term.FormattingEnabled = true;
            this.cmb_Term.Location = new System.Drawing.Point(598, 84);
            this.cmb_Term.Name = "cmb_Term";
            this.cmb_Term.Size = new System.Drawing.Size(290, 26);
            this.cmb_Term.TabIndex = 1;
            // 
            // gv_Books
            // 
            this.gv_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Books.Location = new System.Drawing.Point(156, 161);
            this.gv_Books.Name = "gv_Books";
            this.gv_Books.RowTemplate.Height = 30;
            this.gv_Books.Size = new System.Drawing.Size(1249, 589);
            this.gv_Books.TabIndex = 2;
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(958, 79);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(84, 34);
            this.btn_Query.TabIndex = 3;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // frm_BookSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 803);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.gv_Books);
            this.Controls.Add(this.cmb_Term);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_BookSelection";
            this.Text = "frm_BookSelection";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Term;
        private System.Windows.Forms.DataGridView gv_Books;
        private System.Windows.Forms.Button btn_Query;
    }
}
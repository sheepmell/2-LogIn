namespace _2_LogIn
{
    partial class frm_FacultyHomepage
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
            this.cmb_Class = new System.Windows.Forms.ComboBox();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.cmb_Term = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_Evaluation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Evaluation)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(761, 105);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 30);
            this.btn_Query.TabIndex = 36;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // cmb_Class
            // 
            this.cmb_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Class.FormattingEnabled = true;
            this.cmb_Class.Location = new System.Drawing.Point(518, 164);
            this.cmb_Class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Class.Name = "cmb_Class";
            this.cmb_Class.Size = new System.Drawing.Size(183, 26);
            this.cmb_Class.TabIndex = 35;
            // 
            // cmb_Course
            // 
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Location = new System.Drawing.Point(518, 107);
            this.cmb_Course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(183, 26);
            this.cmb_Course.TabIndex = 34;
            // 
            // cmb_Term
            // 
            this.cmb_Term.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Term.FormattingEnabled = true;
            this.cmb_Term.Location = new System.Drawing.Point(518, 56);
            this.cmb_Term.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Term.Name = "cmb_Term";
            this.cmb_Term.Size = new System.Drawing.Size(183, 26);
            this.cmb_Term.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "班级：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "课程：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "学期：";
            // 
            // gv_Evaluation
            // 
            this.gv_Evaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Evaluation.Location = new System.Drawing.Point(83, 219);
            this.gv_Evaluation.Name = "gv_Evaluation";
            this.gv_Evaluation.RowTemplate.Height = 30;
            this.gv_Evaluation.Size = new System.Drawing.Size(1032, 407);
            this.gv_Evaluation.TabIndex = 37;
            // 
            // frm_FacultyHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 671);
            this.Controls.Add(this.gv_Evaluation);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.cmb_Class);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.cmb_Term);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_FacultyHomepage";
            this.Text = "教师主页";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Evaluation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.ComboBox cmb_Class;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.ComboBox cmb_Term;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gv_Evaluation;
    }
}
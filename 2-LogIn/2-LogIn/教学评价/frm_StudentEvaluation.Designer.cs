namespace _2_LogIn
{
    partial class frm_StudentEvaluation
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
            this.gv_Evaluation = new System.Windows.Forms.DataGridView();
            this.btn_Evaluate = new System.Windows.Forms.Button();
            this.gv_EvaluationScore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Evaluation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_EvaluationScore)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Evaluation
            // 
            this.gv_Evaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Evaluation.Location = new System.Drawing.Point(74, 34);
            this.gv_Evaluation.Name = "gv_Evaluation";
            this.gv_Evaluation.RowTemplate.Height = 30;
            this.gv_Evaluation.Size = new System.Drawing.Size(1440, 304);
            this.gv_Evaluation.TabIndex = 0;
            // 
            // btn_Evaluate
            // 
            this.btn_Evaluate.Location = new System.Drawing.Point(753, 354);
            this.btn_Evaluate.Name = "btn_Evaluate";
            this.btn_Evaluate.Size = new System.Drawing.Size(77, 32);
            this.btn_Evaluate.TabIndex = 1;
            this.btn_Evaluate.Text = "评教";
            this.btn_Evaluate.UseVisualStyleBackColor = true;
            this.btn_Evaluate.Click += new System.EventHandler(this.btn_Evaluate_Click);
            // 
            // gv_EvaluationScore
            // 
            this.gv_EvaluationScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_EvaluationScore.Location = new System.Drawing.Point(74, 404);
            this.gv_EvaluationScore.Name = "gv_EvaluationScore";
            this.gv_EvaluationScore.RowTemplate.Height = 30;
            this.gv_EvaluationScore.Size = new System.Drawing.Size(1440, 304);
            this.gv_EvaluationScore.TabIndex = 2;
            // 
            // frm_StudentEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 803);
            this.Controls.Add(this.gv_EvaluationScore);
            this.Controls.Add(this.btn_Evaluate);
            this.Controls.Add(this.gv_Evaluation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_StudentEvaluation";
            this.Text = "frm_StudentEvaluation";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Evaluation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_EvaluationScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Evaluation;
        private System.Windows.Forms.Button btn_Evaluate;
        private System.Windows.Forms.DataGridView gv_EvaluationScore;
    }
}
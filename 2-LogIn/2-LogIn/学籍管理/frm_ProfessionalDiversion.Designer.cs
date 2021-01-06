namespace _2_LogIn
{
    partial class frm_ProfessionalDiversion
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
            this.gv_Major = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.可选专业 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.专业 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.已选人数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opeartion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Volunt = new System.Windows.Forms.DataGridView();
            this.志愿 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.已选专业 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学院 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Major)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Volunt)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Major
            // 
            this.gv_Major.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Major.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Major.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.可选专业,
            this.专业,
            this.已选人数,
            this.Opeartion});
            this.gv_Major.Location = new System.Drawing.Point(35, 45);
            this.gv_Major.Name = "gv_Major";
            this.gv_Major.RowTemplate.Height = 30;
            this.gv_Major.Size = new System.Drawing.Size(1484, 355);
            this.gv_Major.TabIndex = 1;
            // 
            // No
            // 
            this.No.HeaderText = "序号";
            this.No.Name = "No";
            // 
            // 可选专业
            // 
            this.可选专业.HeaderText = "可选专业";
            this.可选专业.Name = "可选专业";
            // 
            // 专业
            // 
            this.专业.HeaderText = "专业";
            this.专业.Name = "专业";
            // 
            // 已选人数
            // 
            this.已选人数.HeaderText = "已选人数";
            this.已选人数.Name = "已选人数";
            // 
            // Opeartion
            // 
            this.Opeartion.HeaderText = "操作";
            this.Opeartion.Name = "Opeartion";
            // 
            // gv_Volunt
            // 
            this.gv_Volunt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Volunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Volunt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.志愿,
            this.已选专业,
            this.学院,
            this.dataGridViewTextBoxColumn8});
            this.gv_Volunt.Location = new System.Drawing.Point(35, 435);
            this.gv_Volunt.Name = "gv_Volunt";
            this.gv_Volunt.RowTemplate.Height = 30;
            this.gv_Volunt.Size = new System.Drawing.Size(1484, 318);
            this.gv_Volunt.TabIndex = 2;
            // 
            // 志愿
            // 
            this.志愿.HeaderText = "志愿";
            this.志愿.Name = "志愿";
            // 
            // 已选专业
            // 
            this.已选专业.HeaderText = "已选专业";
            this.已选专业.Name = "已选专业";
            // 
            // 学院
            // 
            this.学院.HeaderText = "学院";
            this.学院.Name = "学院";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "操作";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // frm_ProfessionalDiversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 803);
            this.Controls.Add(this.gv_Volunt);
            this.Controls.Add(this.gv_Major);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ProfessionalDiversion";
            this.Text = "frm_ProfessionalDiversion";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Major)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Volunt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn 可选专业;
        private System.Windows.Forms.DataGridViewTextBoxColumn 专业;
        private System.Windows.Forms.DataGridViewTextBoxColumn 已选人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opeartion;
        private System.Windows.Forms.DataGridView gv_Volunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn 志愿;
        private System.Windows.Forms.DataGridViewTextBoxColumn 已选专业;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学院;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
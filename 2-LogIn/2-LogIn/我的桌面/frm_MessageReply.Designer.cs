﻿namespace _2_LogIn
{
    partial class frm_MessageReply
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
            this.txt_Reply = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Reply
            // 
            this.txt_Reply.Location = new System.Drawing.Point(62, 88);
            this.txt_Reply.Name = "txt_Reply";
            this.txt_Reply.Size = new System.Drawing.Size(305, 28);
            this.txt_Reply.TabIndex = 0;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(171, 180);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 31);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "确定";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // frm_MessageReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 274);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_Reply);
            this.Name = "frm_MessageReply";
            this.Text = "回复";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Reply;
        private System.Windows.Forms.Button btn_Submit;
    }
}
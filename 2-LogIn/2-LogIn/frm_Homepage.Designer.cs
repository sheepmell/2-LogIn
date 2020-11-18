namespace _2_LogIn
{
    partial class frm_Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Homepage));
            this.tbc_Home = new System.Windows.Forms.TabControl();
            this.tbp_Home = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbp_Desktop = new System.Windows.Forms.TabPage();
            this.panel_Destop = new System.Windows.Forms.Panel();
            this.lkl_ChangePassword = new System.Windows.Forms.LinkLabel();
            this.lkl_ChangeInfo = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lkl_Message = new System.Windows.Forms.LinkLabel();
            this.lkl_Notice = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tbc_Home.SuspendLayout();
            this.tbp_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbp_Desktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_Home
            // 
            this.tbc_Home.Controls.Add(this.tbp_Home);
            this.tbc_Home.Controls.Add(this.tbp_Desktop);
            this.tbc_Home.Controls.Add(this.tabPage3);
            this.tbc_Home.Controls.Add(this.tabPage4);
            this.tbc_Home.Controls.Add(this.tabPage5);
            this.tbc_Home.Controls.Add(this.tabPage6);
            this.tbc_Home.Location = new System.Drawing.Point(0, 0);
            this.tbc_Home.Name = "tbc_Home";
            this.tbc_Home.SelectedIndex = 0;
            this.tbc_Home.Size = new System.Drawing.Size(1749, 847);
            this.tbc_Home.TabIndex = 0;
            // 
            // tbp_Home
            // 
            this.tbp_Home.Controls.Add(this.pictureBox1);
            this.tbp_Home.Location = new System.Drawing.Point(4, 28);
            this.tbp_Home.Name = "tbp_Home";
            this.tbp_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Home.Size = new System.Drawing.Size(1741, 815);
            this.tbp_Home.TabIndex = 0;
            this.tbp_Home.Text = "⏏";
            this.tbp_Home.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1368, 660);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbp_Desktop
            // 
            this.tbp_Desktop.Controls.Add(this.panel_Destop);
            this.tbp_Desktop.Controls.Add(this.lkl_ChangePassword);
            this.tbp_Desktop.Controls.Add(this.lkl_ChangeInfo);
            this.tbp_Desktop.Controls.Add(this.label2);
            this.tbp_Desktop.Controls.Add(this.lkl_Message);
            this.tbp_Desktop.Controls.Add(this.lkl_Notice);
            this.tbp_Desktop.Controls.Add(this.label1);
            this.tbp_Desktop.Location = new System.Drawing.Point(4, 28);
            this.tbp_Desktop.Name = "tbp_Desktop";
            this.tbp_Desktop.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Desktop.Size = new System.Drawing.Size(1741, 815);
            this.tbp_Desktop.TabIndex = 1;
            this.tbp_Desktop.Text = "我的桌面";
            this.tbp_Desktop.UseVisualStyleBackColor = true;
            // 
            // panel_Destop
            // 
            this.panel_Destop.Location = new System.Drawing.Point(165, 34);
            this.panel_Destop.Name = "panel_Destop";
            this.panel_Destop.Size = new System.Drawing.Size(1615, 752);
            this.panel_Destop.TabIndex = 7;
            // 
            // lkl_ChangePassword
            // 
            this.lkl_ChangePassword.AutoSize = true;
            this.lkl_ChangePassword.Location = new System.Drawing.Point(61, 341);
            this.lkl_ChangePassword.Name = "lkl_ChangePassword";
            this.lkl_ChangePassword.Size = new System.Drawing.Size(80, 18);
            this.lkl_ChangePassword.TabIndex = 5;
            this.lkl_ChangePassword.TabStop = true;
            this.lkl_ChangePassword.Text = "修改密码";
            this.lkl_ChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_ChangePassword_LinkClicked);
            // 
            // lkl_ChangeInfo
            // 
            this.lkl_ChangeInfo.AutoSize = true;
            this.lkl_ChangeInfo.Location = new System.Drawing.Point(43, 290);
            this.lkl_ChangeInfo.Name = "lkl_ChangeInfo";
            this.lkl_ChangeInfo.Size = new System.Drawing.Size(116, 18);
            this.lkl_ChangeInfo.TabIndex = 4;
            this.lkl_ChangeInfo.TabStop = true;
            this.lkl_ChangeInfo.Text = "修改个人信息";
            this.lkl_ChangeInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_ChangeInfo_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "个人信息";
            // 
            // lkl_Message
            // 
            this.lkl_Message.AutoSize = true;
            this.lkl_Message.Location = new System.Drawing.Point(61, 188);
            this.lkl_Message.Name = "lkl_Message";
            this.lkl_Message.Size = new System.Drawing.Size(80, 18);
            this.lkl_Message.TabIndex = 2;
            this.lkl_Message.TabStop = true;
            this.lkl_Message.Text = "已收留言";
            this.lkl_Message.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_Message_LinkClicked);
            // 
            // lkl_Notice
            // 
            this.lkl_Notice.AutoSize = true;
            this.lkl_Notice.Location = new System.Drawing.Point(61, 137);
            this.lkl_Notice.Name = "lkl_Notice";
            this.lkl_Notice.Size = new System.Drawing.Size(80, 18);
            this.lkl_Notice.TabIndex = 1;
            this.lkl_Notice.TabStop = true;
            this.lkl_Notice.Text = "已收公告";
            this.lkl_Notice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_Notice_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "公告留言";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1741, 815);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1741, 815);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1741, 815);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1741, 815);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // frm_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1825, 835);
            this.Controls.Add(this.tbc_Home);
            this.Name = "frm_Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.frm_Homepage_Load);
            this.tbc_Home.ResumeLayout(false);
            this.tbp_Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbp_Desktop.ResumeLayout(false);
            this.tbp_Desktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Home;
        private System.Windows.Forms.TabPage tbp_Home;
        private System.Windows.Forms.TabPage tbp_Desktop;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lkl_ChangePassword;
        private System.Windows.Forms.LinkLabel lkl_ChangeInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lkl_Message;
        private System.Windows.Forms.LinkLabel lkl_Notice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Destop;
    }
}
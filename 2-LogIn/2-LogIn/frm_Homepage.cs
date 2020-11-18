using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;

namespace _2_LogIn
{
    public partial class frm_Homepage : Form
    {
        private string _StudentNo;
        public frm_Homepage()
        {
            InitializeComponent();
            this.FormClosed += Frm_Homepage_FormClosed;
        }
        public frm_Homepage(string studentNo) : this()
        {
            this._StudentNo = studentNo;
        }
        private void Frm_Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void lkl_Notice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Notice frm_Notice = new frm_Notice();
            frm_Notice.TopLevel = false;
            this.panel_Destop.Controls.Clear();
            this.panel_Destop.Controls.Add(frm_Notice);
            frm_Notice.Show();
        }

        private void lkl_Message_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Message frm_Message = new frm_Message();
            frm_Message.TopLevel = false;
            this.panel_Destop.Controls.Clear();
            this.panel_Destop.Controls.Add(frm_Message);
            frm_Message.Show();
        }

        private void lkl_ChangeInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_ChangeInfo frm_ChangeInfo = new frm_ChangeInfo(_StudentNo);
            frm_ChangeInfo.TopLevel = false;
            this.panel_Destop.Controls.Clear();
            this.panel_Destop.Controls.Add(frm_ChangeInfo);
            frm_ChangeInfo.Show();
        }

        private void frm_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void lkl_ChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_ChangePassword frm_ChangePassword = new frm_ChangePassword(_StudentNo);
            frm_ChangePassword.TopLevel = false;
            this.panel_Destop.Controls.Clear();
            this.panel_Destop.Controls.Add(frm_ChangePassword);
            frm_ChangePassword.Show();
        }
    }
}

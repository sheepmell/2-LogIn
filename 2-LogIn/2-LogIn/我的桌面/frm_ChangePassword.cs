using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;

namespace _2_LogIn
{
    public partial class frm_ChangePassword : Form
    {
        private string _StudentNo;
        public frm_ChangePassword()
        {
            InitializeComponent();
            this.FormClosed += Frm_ChangePassword_FormClosed;
        }

        private void Frm_ChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        public frm_ChangePassword(string studentNo) : this()
        {
            this._StudentNo = studentNo;
        }
        private void frm_ChangePassword_Load(object sender, EventArgs e)
        {
            string commandText =
                $@"SELECT * 
                     FROM dbo.tb_Student AS S 
                     WHERE S.No='{this._StudentNo}';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            if (sqlHelper.HasRecord)
            {
                this.txt_No.Text = sqlHelper["No"].ToString();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_ExPassword.Text == "")
            {
                MessageBox.Show("旧密码不得为空！");
                txt_ExPassword.Text = "";
                txt_NewPassword.Text = "";
                txt_NewPassword2.Text = "";
                return;
            }

            if (txt_NewPassword.Text == "")
            {
                MessageBox.Show("新密码不得为空！");
                txt_ExPassword.Text = "";
                txt_NewPassword.Text = "";
                txt_NewPassword2.Text = "";
                return;
            }

            if (txt_NewPassword2.Text == "")
            {
                MessageBox.Show("确认新密码不得为空！");
                txt_ExPassword.Text = "";
                txt_NewPassword.Text = "";
                txt_NewPassword2.Text = "";
                return;
            }

            if (txt_NewPassword.Text != txt_NewPassword2.Text)
            {
                MessageBox.Show("两次密码不一致！");
                txt_ExPassword.Text = "";
                txt_NewPassword.Text = "";
                txt_NewPassword2.Text = "";
                return;
            }

            if (txt_NewPassword.Text.Length < 8)
            {
                MessageBox.Show("新密码不足8位！请重试！");
                txt_ExPassword.Text = "";
                txt_NewPassword.Text = "";
                txt_NewPassword2.Text = "";
                return;
            }

            Regex regex = new Regex("^(?!([a-zA-Z]+|\\d+)$)[a-zA-Z\\d]{6,20}$");
            Match match = regex.Match(txt_NewPassword.Text);
            if (match.Success)
            {
                string commandText =
                    $@"Update tb_Student 
                           SET Password='{txt_NewPassword.Text}'
                         Where No='{txt_No.Text}';";
                SqlHelper sqlHelper = new SqlHelper();
                int result = sqlHelper.QuickReturn<int>(commandText);
                if (result == 0)
                {
                    MessageBox.Show("更改成功！");
                    txt_ExPassword.Text = "";
                    txt_NewPassword.Text = "";
                    txt_NewPassword2.Text = "";
                }
                else
                {
                    MessageBox.Show("更改失败！");
                    txt_ExPassword.Text = "";
                    txt_NewPassword.Text = "";
                    txt_NewPassword2.Text = "";
                }

            }
            else
            {
                MessageBox.Show("新密码不合规则！请重试！");
                txt_ExPassword.Text = "";
                txt_NewPassword.Text = "";
                txt_NewPassword2.Text = "";
            }

        }

        private void btn_Replace_Click(object sender, EventArgs e)
        {
            txt_ExPassword.Text = "";
            txt_NewPassword.Text = "";
            txt_NewPassword2.Text = "";
        }
    }

            
        }

        
    


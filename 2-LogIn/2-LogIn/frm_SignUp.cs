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
    public partial class frm_SignUp : Form
    {
        public frm_SignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosed += Frm_SignUp_FormClosed;
        }

        private void Frm_SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (this.txt_Password.Text == "")
            {
                MessageBox.Show("请输入密码！");
                return;
            }
            string commandText =
                $@"INSERT tb_Student (No,Password)
                   VALUES('{this.txt_No.Text}','{this.txt_Password.Text}');";
            SqlHelper sqlHelper = new SqlHelper();
            int rowAffected = sqlHelper.QuickSubmit(commandText);

            if (rowAffected == 1)
            {
                MessageBox.Show("注册成功！");
            }
            else
            {
                MessageBox.Show("该用户已存在！注册失败！");
            }

            txt_No.Text = "";
            txt_Password.Text = "";
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            if (txt_No.Text != "")
            {
                btn_SignUp.Enabled = true;
            }
        }

        private void frm_SignUp_Load(object sender, EventArgs e)
        {
            btn_SignUp.Enabled = false;
        }
    }
}

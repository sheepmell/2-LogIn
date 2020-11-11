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
    public partial class frm_LogIn : Form
    {
        public frm_LogIn()
        {
            InitializeComponent();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (this.txt_Password.Text=="")
            {
                MessageBox.Show("请输入密码！");
                return;
            }
            string commandText =
                $@"SELECT 1
                   FROM tb_Student AS S
	               WHERE S.No = '{this.txt_No.Text}' 
                         AND S.Password = '{this.txt_Password.Text}';";

            SqlHelper sqlHelper = new SqlHelper();
            int result = sqlHelper.QuickReturn<int>(commandText);
            if (result==1)
            {
                MessageBox.Show("登陆成功！");
                frm_StudentInfo frm_StudentInfo = new frm_StudentInfo(this.txt_No.Text);
                frm_StudentInfo.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("登陆失败！");
            }

            this.txt_No.Text = "";
            this.txt_Password.Text = "";
        }

        private void frm_LogIn_Load(object sender, EventArgs e)
        {
            this.btn_LogIn.Enabled = false;
        }

        private void txt_No_TextChanged(object sender, EventArgs e)
        {
            this.btn_LogIn.Enabled = this.txt_No.Text != "";
        }
    }
}

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
    public partial class frm_FacultyLogin : Form
    {
        public frm_FacultyLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosed += Frm_FacultyLogin_FormClosed;
        }

        private void Frm_FacultyLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (this.txt_Password.Text == "")
            {
                MessageBox.Show("密码不可为空！");
                return;
            }
            string commandText =
                $@"SELECT 1
                   FROM tb_Faculty AS F
	               WHERE F.No = '{this.txt_No.Text}' 
                         AND F.Password = '{this.txt_Password.Text}';";

            SqlHelper sqlHelper = new SqlHelper();
            int result = sqlHelper.QuickReturn<int>(commandText);
            if (result == 1)
            {
                MessageBox.Show("登陆成功！");
                frm_FacultyHomepage frm_FacultyHomepage = new frm_FacultyHomepage(txt_No.Text);
                frm_FacultyHomepage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("登陆失败！");
            }

            this.txt_Password.Text = "";
            this.txt_No.Text = "";
        }
    }
}

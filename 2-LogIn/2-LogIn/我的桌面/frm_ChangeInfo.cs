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
    public partial class frm_ChangeInfo : Form
    {
        private string _StudentNo;
        public frm_ChangeInfo()
        {
            InitializeComponent();
        }
        public frm_ChangeInfo(string studentNo) : this()
        {
            this._StudentNo = studentNo;
        }
        private void frm_ChangeInfo_Load(object sender, EventArgs e)
        {
            string commandText = $@"Select * 
                                  From tb_StudentPersonal AS SP 
                                  Where SP.No='{this._StudentNo}';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            if (sqlHelper.HasRecord)
            {
                this.txt_No.Text = sqlHelper["No"].ToString();
                this.txt_Name.Text = sqlHelper["Name"].ToString();
                this.txt_Question1.Text = sqlHelper["Question1"].ToString();
                this.txt_Answer1.Text = sqlHelper["Answer1"].ToString();
                this.txt_Question2.Text = sqlHelper["Question2"].ToString();
                this.txt_Answer2.Text = sqlHelper["Answer2"].ToString();
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text=="")
            {
                MessageBox.Show("姓名不可为空！");
                return;
            }
            string commandText = $@"Update tb_StudentPersonal SET Name='{txt_Name.Text}',
                                    Question1='{txt_Question1.Text}',Answer1='{txt_Answer1.Text}',
                                    Question2='{txt_Question2.Text}',Answer2='{txt_Answer2.Text}' 
                                    Where No='{txt_No}';";
            SqlHelper sqlHelper = new SqlHelper();
            int result = sqlHelper.QuickReturn<int>(commandText);
            if (result == 0)
            {
                MessageBox.Show("更改成功！");
            }
            else
            {
                MessageBox.Show("更改失败！");
            }
        }

        private void btn_Replace_Click(object sender, EventArgs e)
        {
            txt_Name.Text = "";
            txt_Question1.Text = "";
            txt_Question2.Text = "";
            txt_Answer1.Text = "";
            txt_Answer2.Text = "";
        }
    }
}

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
    public partial class frm_StudentInfo : Form
    {
        private string _StudentNo;
        public frm_StudentInfo()
        {
            InitializeComponent();
            this.FormClosed += Frm_StudentInfo_FormClosed;
        }
        public frm_StudentInfo(string studentNo):this()
        {
            this._StudentNo = studentNo;
        }
        private void Frm_StudentInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void frm_StudentInfo_Load(object sender, EventArgs e)
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
                this.txt_Name.Text = sqlHelper["Name"].ToString();
                this.txt_BirthDate.Text = ((DateTime)sqlHelper["BirthDate"]).ToShortDateString();
                this.txt_Gender.Text = sqlHelper["Gender"].ToString();
                this.txt_Class.Text = sqlHelper["Class"].ToString();
                this.txt_PhoneNumber.Text = sqlHelper["PhoneNumber"].ToString();
            }
            
            
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string commandText=
                $@"UPDATE tb_Student SET 
                     NO='{this.txt_No.Text}',NAME='{this.txt_Name.Text}',
                     Gender='{this.txt_Gender.Text}',BirthDate='{this.txt_BirthDate.Text}',
                     Class='{this.txt_Class.Text}',PhoneNumber='{this.txt_PhoneNumber.Text}'
                     WHERE No = '{this.txt_No.Text}'; ";
            SqlHelper sqlHelper = new SqlHelper();
            int result = sqlHelper.QuickReturn<int>(commandText);
            if (result==0)
            {
                MessageBox.Show("更改成功！");
            }
            else
            {
                MessageBox.Show("更改失败！");
            }
        }

        private void btn_Homepage_Click(object sender, EventArgs e)
        {
            frm_Homepage frm_Homepage = new frm_Homepage(this.txt_No.Text);
            frm_Homepage.Show();
            this.Close();
        }
    }
}

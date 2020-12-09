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
    
    public partial class frm_StudentStatusCard : Form
    {

        private string _StudentNo;
        public frm_StudentStatusCard()
        {
            InitializeComponent();
            this.FormClosed += Frm_StudentStatusCard_FormClosed;
            this.LoadClasses();
        }

        private void Frm_StudentStatusCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        public frm_StudentStatusCard(string studentNo) : this()
        {
            this._StudentNo = studentNo;
        }
        //加载班级
        private void LoadClasses()
        {
            string commandText = "SELECT Name FROM tb_Class;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cmb_Class.Items.Add(sqlHelper["Name"]);
            }
        }
        //更改性别
        private bool ChangeGender()
        {
            bool Gender;
            if (this.rdb_Male.Checked)
            {
                Gender = true;
            }
            else
            {
                Gender = false;
            }
            return Gender;
        }
        private void frm_StudentStatusCard_Load(object sender, EventArgs e)
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
                this.rdb_Male.Checked = (bool)sqlHelper["Gender"];
                this.rdb_Female.Checked = !(bool)sqlHelper["Gender"];
                this.dtp_BirthDate.Value = ((DateTime)sqlHelper["BirthDate"]);
                this.cmb_Class.SelectedItem = sqlHelper["Class"].ToString();
                this.txt_PhoneNumber.Text = sqlHelper["PhoneNumber"].ToString();
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string commandText = $@"UPDATE tb_Student SET 
                     NO='{this.txt_No.Text}',NAME='{this.txt_Name.Text}',
                     Gender='{this.ChangeGender()}',BirthDate='{this.dtp_BirthDate.Value}',
                     Class='{this.cmb_Class.SelectedItem.ToString()}',PhoneNumber='{this.txt_PhoneNumber.Text}'
                     WHERE No = '{this.txt_No.Text}'; ";
            SqlHelper sqlHelper = new SqlHelper();
            int result = sqlHelper.QuickSubmit(commandText);

            if (result==1)
            {
                MessageBox.Show("更改成功！");
            }
            else
            {
                MessageBox.Show("更改失败！");
            }
        }
    }
}

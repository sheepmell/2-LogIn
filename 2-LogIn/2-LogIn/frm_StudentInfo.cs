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
    }
}

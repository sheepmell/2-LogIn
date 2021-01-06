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
    public partial class frm_Evaluation : Form
    {
        private string _StudentNo;
        private string _FacultyNo;
        public frm_Evaluation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frm_Evaluation(string studentno,string facultyno) : this()
        {
            this._StudentNo = studentno;
            this._FacultyNo = facultyno;
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string _score = this.txt_Evaluate.Text.ToString();
            string _message = this.txt_Message.Text.ToString();

            SqlHelper sqlHelper = new SqlHelper();
            string commantText = $@"INSERT tb_StudentEvaluation (StudentNo,FacultyNo,Score,Message) 
                                        VALUES ('{this._StudentNo}','{this._FacultyNo}','{_score}','{_message}')";

            int result = sqlHelper.QuickSubmit(commantText);

            if (result == 1)
            {
                MessageBox.Show("评教成功！");
            }
            if (result == 0)
            {
                MessageBox.Show("评教失败！");
            }

            this.Close();
        }
        
    }
}

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
    public partial class frm_StudentEvaluation : Form
    {
        private string _StudentNo;
        public frm_StudentEvaluation()
        {
            InitializeComponent();
        }
        public frm_StudentEvaluation(string studentno):this()
        {
            this._StudentNo = studentno;
            this.LoadEvaluation();
        }
        //载入评教
        private void LoadEvaluation()
        {
            SqlHelper sqlHelper = new SqlHelper();
            string commantText = $@"SELECT F.No AS 教师编号,F.Name AS 教师姓名,
                                C.Name AS 课程名,'已评教' AS Status ,C.EvaluationLimit AS 截止时间
						FROM tb_Faculty AS F JOIN tb_StudentEvaluation AS SE ON F.No=SE.FacultyNo 
                           JOIN tb_Course AS C ON C.No = F.CourseNo
						WHERE SE.StudentNo='{this._StudentNo}'
					UNION
					SELECT F.No AS 教师编号,F.Name AS 教师姓名,
                        C.Name AS 课程名,'未评教' AS Status ,C.EvaluationLimit AS 截止时间
						FROM tb_Faculty AS F JOIN tb_Course AS C ON C.No = F.CourseNo
						WHERE F.No NOT IN
							(SELECT SE.FacultyNo
								FROM tb_StudentEvaluation AS SE
								WHERE SE.StudentNo='{this._StudentNo}');";
            sqlHelper.QuickFill(commantText, gv_Evaluation);
            commantText = $@"SELECT F.No AS 教师编号,F.Name AS 教师姓名,
                                C.Name AS 课程名,'已评教' AS Status ,C.EvaluationLimit AS 截止时间
						FROM tb_Faculty AS F JOIN tb_StudentEvaluation AS SE ON F.No=SE.FacultyNo 
                        JOIN tb_Course AS C ON C.No = F.CourseNo
						WHERE SE.StudentNo={this._StudentNo}";
            sqlHelper.QuickFill(commantText, gv_EvaluationScore);
        }
        private void btn_Evaluate_Click(object sender, EventArgs e)
        {
            string _FacultyNo = this.gv_Evaluation.CurrentRow.Cells["教师编号"].Value.ToString();
            string status = this.gv_Evaluation.CurrentRow.Cells["Status"].Value.ToString();
            if (status == "已评教")
            {
                MessageBox.Show("请勿重复评教！");
                return;
            }

            DateTime deadline = Convert.ToDateTime(this.gv_Evaluation.CurrentRow.Cells["截止时间"].Value);

            if (DateTime.Now < deadline)
            {
                frm_Evaluation frm_Evaluation = new frm_Evaluation(this._StudentNo, _FacultyNo);
                frm_Evaluation.Show();
                this.LoadEvaluation();
            }
            else
            {
                MessageBox.Show("已过评教截止时间！评教失败！");
                return;
            }

            this.LoadEvaluation();
            
        }
    }
}

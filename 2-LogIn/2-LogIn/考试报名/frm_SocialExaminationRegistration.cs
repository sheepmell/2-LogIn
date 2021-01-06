using SmartLinli.DatabaseDevelopement;
using System;
using System.Windows.Forms;

namespace _2_LogIn
{
    public partial class frm_SocialExaminationRegistration : Form
    {
        private string _StudentNo;
        public frm_SocialExaminationRegistration()
        {
            InitializeComponent();
            
        }
        public frm_SocialExaminationRegistration(string studentno) : this()
        {
            this._StudentNo = studentno;
            this.LoadExams();
        }
        //载入考试
        private void LoadExams()
        {
            SqlHelper sqlHelper = new SqlHelper();
            string commantText =
                $@"SELECT S.*,'已选' AS Status 
						FROM dbo.tb_SocialExam AS S JOIN dbo.tb_StudentSocialExam AS SS ON S.No = SS.SocialExamNo
						WHERE SS.StudentNo='{this._StudentNo}'
					UNION
					SELECT S.*,'未选'
						FROM dbo.tb_SocialExam AS S
						WHERE S.No NOT IN
							(SELECT SS.SocialExamNo
								FROM dbo.tb_StudentSocialExam AS SS
								WHERE SS.StudentNo='{this._StudentNo}');";
            sqlHelper.QuickFill(commantText, this.dgv_AllExams);
            commantText =
                $@"SELECT S.*,IIF(SS.Score IS NULL,'可退选','不可退') AS Status 
                        FROM dbo.tb_StudentSocialExam AS SS JOIN dbo.tb_SocialExam AS S ON SS.SocialExamNo = S.No
                        WHERE SS.StudentNo='{this._StudentNo}';";
            sqlHelper.QuickFill(commantText, this.dgv_SelectedExams);
        }
        //选考
        private void btn_Select_Click(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper();
            string status = this.dgv_AllExams.CurrentRow.Cells["Status"].Value.ToString();
            if (status == "已选")
            {
                MessageBox.Show("该考试已选！请勿重复选修！");
                return;
            }
            DateTime deadline = Convert.ToDateTime(this.dgv_AllExams.CurrentRow.Cells["Deadline"].Value);

            if (DateTime.Now < deadline)
            {
                string currentExamNo = this.dgv_AllExams.CurrentRow.Cells["No"].Value.ToString();
                sqlHelper.QuickSubmit($"INSERT dbo.tb_StudentSocialExam(StudentNo,SocialExamNo)VALUES('{this._StudentNo}','{currentExamNo}')");
                MessageBox.Show("报名成功！");
            }
            else
            {
                MessageBox.Show("已过报名期限！报名失败！");
                return;
            }
            this.LoadExams();
        }
        //退考
        private void btn_Reject_Click(object sender, EventArgs e)
        {
            string status = this.dgv_SelectedExams.CurrentRow.Cells["Status"].Value.ToString();
            if (status == "不可退")
            {
                MessageBox.Show("该课已有成绩！不可退选！");
                return;
            }
            SqlHelper sqlHelper = new SqlHelper();
            string currentExamNo = this.dgv_SelectedExams.CurrentRow.Cells["No"].Value.ToString();
            sqlHelper.QuickSubmit($"DELETE dbo.tb_StudentSocialExam WHERE StudentNo='{_StudentNo}' AND CourseNo='{currentExamNo}';");
            this.LoadExams();
        }
    }
}

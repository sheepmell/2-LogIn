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
    public partial class frm_StudentCoursSelectionCenter : Form
    {
        private string _StudentNo;
        public frm_StudentCoursSelectionCenter()
        {
            InitializeComponent();
            this.LoadCourses();
        }
        public frm_StudentCoursSelectionCenter(string studentno) : this()
        {
            this._StudentNo = studentno;
        }
        //载入课程
        private void LoadCourses()
        {
            SqlHelper sqlHelper = new SqlHelper();
            string commantText =
                $@"SELECT C.*,'已选' AS Status 
						FROM tb_Course AS C JOIN tb_StudentScore AS SS ON C.No=SS.CourseNo
						WHERE SS.StudentNo='{_StudentNo}'
					UNION
					SELECT C.*,'未选'
						FROM tb_Course AS C
						WHERE C.No NOT IN
							(SELECT SS.CourseNo
								FROM tb_StudentScore AS SS
								WHERE SS.StudentNo='{_StudentNo}');";
            sqlHelper.QuickFill(commantText, this.dgv_AllCourses);
            commantText =
                $@"SELECT C.*,IIF(SS.Score IS NULL,'可退选','不可退') AS Status 
                        FROM tb_StudentScore AS SS JOIN tb_Course AS C ON SS.CourseNo=C.No 
                        WHERE SS.StudentNo='{_StudentNo}';";
            sqlHelper.QuickFill(commantText, this.dgv_SelectedCourses);
        }
        //选课
        private void btn_Select_Click(object sender, EventArgs e)
        {
            string status = this.dgv_AllCourses.CurrentRow.Cells["Status"].Value.ToString();
            if (status == "已选")
            {
                MessageBox.Show("该课已选！请勿重复选修！");
                return;
            }
            SqlHelper sqlHelper = new SqlHelper();
            string currentCourseNo = this.dgv_AllCourses.CurrentRow.Cells["No"].Value.ToString();
            sqlHelper.QuickSubmit($"INSERT tb_StudentScore(StudentNo,CourseNo) VALUES('{_StudentNo}','{currentCourseNo}');");
            this.LoadCourses();
        }
        //退选
        private void btn_Reject_Click(object sender, EventArgs e)
        {
            string status = this.dgv_SelectedCourses.CurrentRow.Cells["Status"].Value.ToString();
            if (status == "不可退")
            {
                MessageBox.Show("该课已有成绩！不可退选！");
                return;
            }
            SqlHelper sqlHelper = new SqlHelper();
            string currentCourseNo = this.dgv_SelectedCourses.CurrentRow.Cells["No"].Value.ToString();
            sqlHelper.QuickSubmit($"DELETE tb_StudentScore WHERE StudentNo='{_StudentNo}' AND CourseNo='{currentCourseNo}';");
            this.LoadCourses();
        }
    }
}

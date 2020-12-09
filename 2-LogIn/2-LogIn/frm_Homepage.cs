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
    public partial class frm_Homepage : Form
    {
        private string _StudentNo;
        public frm_Homepage()
        {
            InitializeComponent();
            this.FormClosed += Frm_Homepage_FormClosed;
        }
        public frm_Homepage(string studentNo) : this()
        {
            this._StudentNo = studentNo;
        }
        private void Frm_Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
        //已收公告
        private void lkl_Notice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Notice frm_Notice = new frm_Notice(this._StudentNo);
            frm_Notice.TopLevel = false;
            this.panel_Destop.Controls.Clear();
            this.panel_Destop.Controls.Add(frm_Notice);
            frm_Notice.Show();
        }
        //已收留言
        private void lkl_Message_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Message frm_Message = new frm_Message(this._StudentNo);
            frm_Message.TopLevel = false;
            this.panel_Destop.Controls.Clear();
            this.panel_Destop.Controls.Add(frm_Message);
            frm_Message.Show();
        }
        //修改个人信息
        private void lkl_ChangeInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_ChangeInfo frm_ChangeInfo = new frm_ChangeInfo(_StudentNo);
            frm_ChangeInfo.TopLevel = false;
            this.panel_Destop.Controls.Clear();
            this.panel_Destop.Controls.Add(frm_ChangeInfo);
            frm_ChangeInfo.Show();
        }
        
        private void frm_Homepage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        //修改密码
        private void lkl_ChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_ChangePassword frm_ChangePassword = new frm_ChangePassword(_StudentNo);
            frm_ChangePassword.TopLevel = false;
            this.panel_Destop.Controls.Clear();
            this.panel_Destop.Controls.Add(frm_ChangePassword);
            frm_ChangePassword.Show();
        }
        //学籍卡片
        private void lkl_StudentStatusCard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_StudentStatusCard frm_StudentStatusCard = new frm_StudentStatusCard(_StudentNo);
            frm_StudentStatusCard.TopLevel = false;
            this.panel_StudentStatus.Controls.Clear();
            this.panel_StudentStatus.Controls.Add(frm_StudentStatusCard);
            frm_StudentStatusCard.Show();
        }
        //学籍信息管理
        private void lkl_StatusInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_StatusInfo frm_StatusInfo = new frm_StatusInfo();
            frm_StatusInfo.TopLevel = false;
            this.panel_StudentStatus.Controls.Clear();
            this.panel_StudentStatus.Controls.Add(frm_StatusInfo);
            frm_StatusInfo.Show();
        }
        //学籍预警管理
        private void lkl_StatusAlarm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_StatusAlarm frm_StatusAlarm = new frm_StatusAlarm();
            frm_StatusAlarm.TopLevel = false;
            this.panel_StudentStatus.Controls.Clear();
            this.panel_StudentStatus.Controls.Add(frm_StatusAlarm);
            frm_StatusAlarm.Show();
        }
        //学籍异动管理
        private void lkl_StatusError_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_StatusError frm_StatusError = new frm_StatusError();
            frm_StatusError.TopLevel = false;
            this.panel_StudentStatus.Controls.Clear();
            this.panel_StudentStatus.Controls.Add(frm_StatusError);
            frm_StatusError.Show();
        }
        //专业分流
        private void lkl_ProfessionalDiversion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_ProfessionalDiversion frm_ProfessionalDiversion = new frm_ProfessionalDiversion();
            frm_ProfessionalDiversion.TopLevel = false;
            this.panel_StudentStatus.Controls.Clear();
            this.panel_StudentStatus.Controls.Add(frm_ProfessionalDiversion);
            frm_ProfessionalDiversion.Show();
        }
        //申请交换生
        private void lkl_ApplyExchangeStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_ApplyExchangeStudent frm_ApplyExchangeStudent = new frm_ApplyExchangeStudent();
            frm_ApplyExchangeStudent.TopLevel = false;
            this.panel_StudentStatus.Controls.Clear();
            this.panel_StudentStatus.Controls.Add(frm_ApplyExchangeStudent);
            frm_ApplyExchangeStudent.Show();
        }
        //交换生成绩
        private void lkl_ResultsExchangeStudents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_ResultsExchangeStudents frm_ResultsExchangeStudents = new frm_ResultsExchangeStudents();
            frm_ResultsExchangeStudents.TopLevel = false;
            this.panel_StudentStatus.Controls.Clear();
            this.panel_StudentStatus.Controls.Add(frm_ResultsExchangeStudents);
            frm_ResultsExchangeStudents.Show();
        }
        //交换生选课
        private void lkl_SelectionExchangeStudents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_SelectionExchangeStudents frm_SelectionExchangeStudents = new frm_SelectionExchangeStudents(this._StudentNo);
            frm_SelectionExchangeStudents.TopLevel = false;
            this.panel_StudentStatus.Controls.Clear();
            this.panel_StudentStatus.Controls.Add(frm_SelectionExchangeStudents);
            frm_SelectionExchangeStudents.Show();
        }
        //课程成绩查询
        private void lkl_CourseScore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_CourseScore frm_CourseScore = new frm_CourseScore(_StudentNo);
            frm_CourseScore.TopLevel = false;
            this.panel_StudentStatus.Controls.Clear();
            this.panel_StudentStatus.Controls.Add(frm_CourseScore);
            frm_CourseScore.Show();
        }
        //等级考试查询
        private void lkl_GradeExamination_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_GradeExamination frm_GradeExamination = new frm_GradeExamination(_StudentNo);
            frm_GradeExamination.TopLevel = false;
            this.panel_StudentStatus.Controls.Clear();
            this.panel_StudentStatus.Controls.Add(frm_GradeExamination);
            frm_GradeExamination.Show();
        }
        //学生选课中心
        private void lkl_StudentCoursSelectionCenter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_StudentCoursSelectionCenter frm_StudentCoursSelectionCenter = new frm_StudentCoursSelectionCenter(_StudentNo);
            frm_StudentCoursSelectionCenter.TopLevel = false;
            this.panel_TrainingManagement.Controls.Clear();
            this.panel_TrainingManagement.Controls.Add(frm_StudentCoursSelectionCenter);
            frm_StudentCoursSelectionCenter.Show();
        }
        //教室借用申请
        private void lkl_ClassroomBorrowingApplication_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_ClassroomBorrowingApplication frm_ClassroomBorrowingApplication = new frm_ClassroomBorrowingApplication();
            frm_ClassroomBorrowingApplication.TopLevel = false;
            this.panel_TrainingManagement.Controls.Clear();
            this.panel_TrainingManagement.Controls.Add(frm_ClassroomBorrowingApplication);
            frm_ClassroomBorrowingApplication.Show();
        }
        //社会考试报名
        private void lkl_SocialExaminationRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_SocialExaminationRegistration frm_SocialExaminationRegistration = new frm_SocialExaminationRegistration(this._StudentNo);
            frm_SocialExaminationRegistration.TopLevel = false;
            this.panel_ExaminationRegistration.Controls.Clear();
            this.panel_ExaminationRegistration.Controls.Add(frm_SocialExaminationRegistration);
            frm_SocialExaminationRegistration.Show();
        }
    }
}

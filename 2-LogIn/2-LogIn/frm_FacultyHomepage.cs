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
    
    public partial class frm_FacultyHomepage : Form
    {
        private string _FacultyNo;
        public frm_FacultyHomepage()
        {
            InitializeComponent();
        }
        public frm_FacultyHomepage(string facultyno) : this()
        {
            this._FacultyNo = facultyno;
            this.LoadTerms();
            this.LoadCourse();
            this.LoadClass();
        }
        //加载学期
        private void LoadTerms()
        {
            string commandText = "SELECT Term FROM Tb_Term;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cmb_Term.Items.Add(sqlHelper["Term"]);
            }
        }
        //加载课程
        private void LoadCourse()
        {
            string commandText = "SELECT Name FROM tb_Course;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cmb_Course.Items.Add(sqlHelper["Name"]);
            }
        }
        //加载班级
        private void LoadClass()
        {
            string commandText = "SELECT Name FROM tb_Class;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cmb_Class.Items.Add(sqlHelper["Name"]);
            }
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            string _Term = this.cmb_Term.SelectedItem.ToString();
            string _Course = this.cmb_Course.SelectedItem.ToString();
            string _Class = this.cmb_Class.SelectedItem.ToString();

            string commandText = $@"SELECT SE.Score AS 得分, SE.Message AS 评价
                                     FROM
	                              tb_TeachingTask AS TT
		                          JOIN tb_Term AS T ON T.No = TT.TermNo
	                              JOIN tb_Faculty AS F ON F.No = TT.FacultyNo
	                              JOIN tb_Course AS C ON C.No = TT.CourseNo
	                              JOIN tb_Class AS C2 ON C2.No = TT.ClassNo
	                              JOIN tb_StudentEvaluation AS SE ON SE.FacultyNo = F.No
	                                WHERE
	                              T.Term = '{_Term}' AND C.Name = '{_Course}'
                                  AND F.No = '{this._FacultyNo}' AND C2.Name = '{_Class}'";

            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickFill(commandText, gv_Evaluation);
        }
    }
}

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
    public partial class frm_ClassroomBorrowingApplication : Form
    {
        public frm_ClassroomBorrowingApplication()
        {
            InitializeComponent();
            this.LoadTerms();
            this.LoadCampus();
            this.LoadTeachingArea();
            this.LoadBuilding();
            this.LoadDepartment();
            this.LoadWeeks();
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
        //加载校区
        private void LoadCampus()
        {
            string commandText = "SELECT Campus FROM Tb_Campus;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cmb_Campus.Items.Add(sqlHelper["Campus"]);
            }
        }
        //加载教学区
        private void LoadTeachingArea()
        {
            string commandText = "SELECT TeachingArea FROM tb_TeachingArea;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cmb_TeachingArea.Items.Add(sqlHelper["TeachingArea"]);
            }
        }
        //加载教学楼
        private void LoadBuilding()
        {
            string commandText = "SELECT Building FROM tb_Building;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cmb_Building.Items.Add(sqlHelper["Building"]);
            }
        }
        //private void cmb_Building_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cmb_Classroom.Items.Clear();
        //    //加载班级
        //    string commandText = 
        //        $@"SELECT C.Classroom FROM TB_ClassRoom AS C 
        //            WHERE C.Building='{cmb_Building.SelectedItem.ToString()}'";
        //    SqlHelper sqlHelper = new SqlHelper();
        //    sqlHelper.QuickRead(commandText);
        //    while (sqlHelper.HasRecord)
        //    {
        //        this.cmb_Classroom.Items.Add(sqlHelper["Classroom"]);
        //    }
        //}
        //加载院系
        private void LoadDepartment()
        {
            string commandText = "SELECT Department FROM TB_Department;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cmb_Department.Items.Add(sqlHelper["Department"]);
            }
        }
        //加载周次
        private void LoadWeeks()
        {
            string commandText = "SELECT Week FROM tb_Week;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cmb_Weeks1.Items.Add(sqlHelper["Week"]);
                this.cmb_Weeks2.Items.Add(sqlHelper["Week"]);
            }
        }
        //查询
        private void btn_Query_Click(object sender, EventArgs e)
        {
            string commandText = $@"SELECT C.Campus,C.Building,C.ClassRoom,C.Status FROM tb_Classroom AS C
                                     WHERE C.Campus='{this.cmb_Campus.SelectedItem.ToString()}' 
                                     AND C.Building='{this.cmb_Building.SelectedItem.ToString()}'";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickFill(commandText, this.dgv_Classroom);
        }
        //借用
        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper();
            string classroom = this.dgv_Classroom.CurrentRow.Cells["Classroom"].Value.ToString();
            string status = this.dgv_Classroom.CurrentRow.Cells["Status"].Value.ToString();

            if (status == "空闲中")
            {
                string commandText1 = $@"UPDATE tb_Classroom
                                       SET Status='已被借用',
                                          Department='{this.cmb_Department.SelectedItem.ToString()}',
                                          StudentNumber='{this.txb_People.Text.ToString()}',
                                          Week='{this.cmb_Weeks1.SelectedItem.ToString()}',
                                          Weekday='{this.cmb_Week1.SelectedItem.ToString()}',
                                          Term='{this.cmb_Term.SelectedItem.ToString()}'
                                      WHERE Classroom='{classroom}'";
                sqlHelper.QuickSubmit(commandText1);
                string commandText2 = $"SELECT * FROM tb_Classroom AS C WHERE C.Classroom='{classroom}'AND Status='已被借用'";
                sqlHelper.QuickFill(commandText2, dgv_Classroom);
                sqlHelper.QuickRead(commandText2);
                if (sqlHelper.HasRecord)
                {
                    MessageBox.Show("您已成功借用该教室！");
                }
                else
                {
                    MessageBox.Show("借用教室不成功！请重新操作！");
                }
            }
            else
            {
                MessageBox.Show("该教室在该时间段内已被借用！借用失败！");
            }
        }
    }
}

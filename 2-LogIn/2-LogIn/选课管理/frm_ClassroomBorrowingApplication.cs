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
        private void cmb_Building_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Classroom.Items.Clear();
            //加载班级
            string commandText = 
                $@"SELECT C.Classroom FROM TB_ClassRoom AS C 
                    WHERE C.Building='{cmb_Building.SelectedItem.ToString()}'";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cmb_Classroom.Items.Add(sqlHelper["Classroom"]);
            }
        }
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
    }
}

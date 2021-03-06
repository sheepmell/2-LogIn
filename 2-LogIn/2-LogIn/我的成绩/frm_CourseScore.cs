﻿using System;
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
    public partial class frm_CourseScore : Form
    {
        private string _StudentNo;
        public frm_CourseScore()
        {
            InitializeComponent();
        }

        public frm_CourseScore(string studentNo) : this()
        {
            this._StudentNo = studentNo;
            this.LoadCourse();
        }
        private void LoadCourse()
        {
            string commandText = $@"SELECT C.Name , C.Credit ,F.Name ,C.EvaluationLimit 
                                    FROM tb_StudentScore AS SS
                                        JOIN tb_Course AS C ON C.No = SS.CourseNo
                                        JOIN tb_Faculty AS F ON F.No = SS.FacultyNo
                                    WHERE
                                        SS.StudentNo = '{this._StudentNo}'";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickFill(commandText, gv_CourseMessage);
        }
        private void btn_Query_Click(object sender, EventArgs e)
        {
            DateTime deadline = Convert.ToDateTime(this.gv_CourseMessage.CurrentRow.Cells["EvaluationLimit"].Value);

        }
    }
}

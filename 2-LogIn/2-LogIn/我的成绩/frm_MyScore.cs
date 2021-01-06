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
    public partial class frm_MyScore : Form
    {
        private string _StudentNo;
        public frm_MyScore()
        {
            InitializeComponent();
        }
        public frm_MyScore(string studentno) : this()
        {
            this._StudentNo = studentno;
            this.LoadScore();
        }
        private void LoadScore()
        {
            

            SqlHelper sqlHelper = new SqlHelper();
            string commandText = $@"SELECT C.Name , C.Credit ,F.Name ,SS.BasicScore ,
                                             SS.FinalScore ,SS.TotalScore
                                    FROM tb_StudentScore AS SS
                                        JOIN tb_Course AS C ON C.No = SS.CourseNo
                                        JOIN tb_Faculty AS F ON F.No = SS.FacultyNo
                                    WHERE
                                        SS.StudentNo = '{this._StudentNo}'";
            sqlHelper.QuickFill(commandText, gv_Score);
        }
    }
}

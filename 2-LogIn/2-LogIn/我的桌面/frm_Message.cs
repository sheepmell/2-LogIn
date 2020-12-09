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
    public partial class frm_Message : Form
    {
        private string _StudentNo;
        public frm_Message()
        {
            InitializeComponent();
            this.LoadMessage();
        }
        public frm_Message(string studentno):this()
        {
            this._StudentNo = studentno;
        }
        private void LoadMessage()
        {
            SqlHelper sqlHelper = new SqlHelper();
            string commantText =
                $@"SELECT M.*,'已读' AS Status 
                     FROM dbo.tb_Messege AS M 
		                  JOIN dbo.tb_StuMessage AS SM ON M.No = SM.MessageNo
		             WHERE SM.StudentNo='3190707001'
	                 UNION
	                 SELECT M.* ,'未读'
	                 FROM dbo.tb_Messege AS M
	                 WHERE M.No NOT IN
	                 (SELECT SM.MessageNo
				      FROM dbo.tb_StuMessage AS SM
				    	WHERE SM.StudentNo='3190707001');";
            sqlHelper.QuickFill(commantText, gv_Message);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Detail = gv_Message.Rows[e.RowIndex].Cells["Detail"].Value.ToString();
            MessageBox.Show($"{Detail}");
            var status = gv_Message.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            if (status=="未读")
            {
                SqlHelper sqlHelper = new SqlHelper();
                var messageNo = gv_Message.Rows[e.RowIndex].Cells["No"].Value.ToString();
                sqlHelper.QuickSubmit($"INSERT tb_StuMessage(StudentNo,MessageNo) VALUES('{_StudentNo}','{messageNo}');");
            }
            this.LoadMessage();

        }
    }
}

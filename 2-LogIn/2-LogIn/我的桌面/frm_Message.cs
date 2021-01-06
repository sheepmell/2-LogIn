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
        }
        public frm_Message(string studentno):this()
        {
            this._StudentNo = studentno;
            this.LoadMessage();
        }
        private void LoadMessage()
        {
            SqlHelper sqlHelper = new SqlHelper();
            string commantText =
                $@"SELECT M.*,'已读' AS Status 
                     FROM dbo.tb_Messege AS M 
		                  JOIN dbo.tb_StuMessage AS SM ON M.No = SM.MessageNo
		             WHERE SM.StudentNo='{_StudentNo}'
	                 UNION
	                 SELECT M.* ,'未读'
	                 FROM dbo.tb_Messege AS M
	                 WHERE M.No NOT IN
	                 (SELECT SM.MessageNo
				      FROM dbo.tb_StuMessage AS SM
				    	WHERE SM.StudentNo='{_StudentNo}');";
            sqlHelper.QuickFill(commantText, gv_Message);

            string commentText2 = $@"SELECT M.NO,M.TITLE,SM.REPLY
                                  FROM tb_Messege AS M
	                                JOIN tb_StuMessage AS SM ON M.NO = SM.MessageNo
	                                  WHERE SM.StudentNo =  {this._StudentNo}";
            sqlHelper.QuickFill(commentText2, gv_MessageReply);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Detail = gv_Message.Rows[e.RowIndex].Cells["Detail"].Value.ToString();
            var status = gv_Message.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            string _messageNo = gv_Message.Rows[e.RowIndex].Cells["No"].Value.ToString();
            
            DialogResult MsgBoxResult;
            MsgBoxResult = MessageBox.Show($"{Detail}"+"\r\n"+"是否要回复？","详情", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);
            if (MsgBoxResult == DialogResult.Yes)
            {
                frm_MessageReply frm_MessageReply = new frm_MessageReply(_StudentNo,_messageNo);
                frm_MessageReply.Show();
            }

            if (status == "未读")
            {
                SqlHelper sqlHelper = new SqlHelper();
                sqlHelper.QuickSubmit($"INSERT tb_StuMessage(StudentNo,MessageNo) VALUES('{_StudentNo}','{_messageNo}');");
            }
            this.LoadMessage();
        }
    }
}

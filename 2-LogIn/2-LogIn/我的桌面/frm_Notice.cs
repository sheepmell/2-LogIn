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
    public partial class frm_Notice : Form
    {
        private string _StudentNo;
        public frm_Notice()
        {
            InitializeComponent();
            
        }
        public frm_Notice(string studentno) : this()
        {
            this._StudentNo = studentno;
            this.LoadNotice();
        }
        private void LoadNotice()
        {
            SqlHelper sqlHelper = new SqlHelper();
            string commantText =
                $@"SELECT N.*,'已读' AS Status 
                     FROM dbo.tb_Notice AS N 
		                  JOIN dbo.tb_StuNotice AS SN ON N.No = SN.NoticeNo
		             WHERE SN.StudentNo='{this._StudentNo}'
	                 UNION
	                 SELECT N.* ,'未读'
	                 FROM dbo.tb_Notice AS N
	                 WHERE N.No NOT IN
	                 (SELECT SN.NoticeNo
				      FROM dbo.tb_StuNotice AS SN
				    	WHERE SN.StudentNo='{this._StudentNo}');";
            sqlHelper.QuickFill(commantText, gv_Notice);

            string commentText2 = $@"SELECT N.NO,N.TITLE,SN.REPLY
                                       FROM TB_Notice AS N
		                                 JOIN TB_STUNOTICE AS SN ON N.NO = SN.NOTICENO
	                                       WHERE
	                                         SN.STUDENTNO = {this._StudentNo}";
            sqlHelper.QuickFill(commentText2, gv_NoticeReply);
        }
        private void gv_Notice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Detail = gv_Notice.Rows[e.RowIndex].Cells["Detail"].Value.ToString();
            var status = gv_Notice.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            string _NoticeNo = gv_Notice.Rows[e.RowIndex].Cells["No"].Value.ToString();

            if (status == "未读")
            {
                SqlHelper sqlHelper = new SqlHelper();
                var noticeNo = gv_Notice.Rows[e.RowIndex].Cells["No"].Value.ToString();
                sqlHelper.QuickSubmit($"INSERT tb_StuNotice(StudentNo,NoticeNo) VALUES('{_StudentNo}','{noticeNo}');");
            }

            DialogResult MsgBoxResult;
            MsgBoxResult = MessageBox.Show($"{Detail}" + "\r\n" + "是否要回复？", "详情", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (MsgBoxResult == DialogResult.Yes)
            {
                frm_NoticeReply frm_NoticeReply = new frm_NoticeReply(_StudentNo, _NoticeNo);
                frm_NoticeReply.Show();
            }


            this.LoadNotice();
        }
    }
}

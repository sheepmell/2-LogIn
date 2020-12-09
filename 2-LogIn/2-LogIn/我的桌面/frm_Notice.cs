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
            this.LoadNotice();
        }
        public frm_Notice(string studentno) : this()
        {
            this._StudentNo = studentno;
        }
        private void LoadNotice()
        {
            SqlHelper sqlHelper = new SqlHelper();
            string commantText =
                $@"SELECT N.*,'已读' AS Status 
                     FROM dbo.tb_Notice AS N 
		                  JOIN dbo.tb_StuNotice AS SN ON N.No = SN.NoticeNo
		             WHERE SN.StudentNo='3190707001'
	                 UNION
	                 SELECT N.* ,'未读'
	                 FROM dbo.tb_Notice AS N
	                 WHERE N.No NOT IN
	                 (SELECT SN.NoticeNo
				      FROM dbo.tb_StuNotice AS SN
				    	WHERE SN.StudentNo='3190707001');";
            sqlHelper.QuickFill(commantText, gv_Notice);
        }

        private void gv_Notice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Detail = gv_Notice.Rows[e.RowIndex].Cells["Detail"].Value.ToString();
            MessageBox.Show($"{Detail}");
            var status = gv_Notice.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            if (status == "未读")
            {
                SqlHelper sqlHelper = new SqlHelper();
                var noticeNo = gv_Notice.Rows[e.RowIndex].Cells["No"].Value.ToString();
                sqlHelper.QuickSubmit($"INSERT tb_StuNotice(StudentNo,NoticeNo) VALUES('{_StudentNo}','{noticeNo}');");
            }
            this.LoadNotice();
        }
    }
}

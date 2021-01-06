using SmartLinli.DatabaseDevelopement;
using System;
using System.Windows.Forms;

namespace _2_LogIn
{
    public partial class frm_NoticeReply : Form
    {
        private string _StudentNo;
        private string _NoticeNo;
        public frm_NoticeReply()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frm_NoticeReply(string studentno, string noticeno) : this()
        {
            this._StudentNo = studentno;
            this._NoticeNo = noticeno;
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string _reply = this.txt_Reply.Text.ToString();
            SqlHelper sqlHelper = new SqlHelper();
            string commandText = $@"UPDATE dbo.tb_StuNotice
                                    SET Reply='{_reply}' 
                                    WHERE StudentNo ='{this._StudentNo}' AND NoticeNo = '{this._NoticeNo}';";
            int result = sqlHelper.QuickSubmit(commandText);

            if (result == 1)
            {
                MessageBox.Show("回复成功！");
            }
            else
            {
                MessageBox.Show("回复失败！");
            }
            this.Close();
        }
        
    }
}

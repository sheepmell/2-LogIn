using System;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;

namespace _2_LogIn
{
    public partial class frm_MessageReply : Form
    {
        private string _StudentNo;
        private string _MessageNo;
        public frm_MessageReply()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public frm_MessageReply(string studentno,string messageno) : this()
        {
            this._StudentNo = studentno;
            this._MessageNo = messageno;
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string _reply = this.txt_Reply.Text.ToString();
            SqlHelper sqlHelper = new SqlHelper();
            string commandText = $@"UPDATE dbo.tb_StuMessage 
                                    SET Reply='{_reply}' 
                                    WHERE StudentNo ='{this._StudentNo}' AND MessageNo = '{this._MessageNo}';";
            int result = sqlHelper.QuickSubmit(commandText);

            if (result == 1)
            {
                MessageBox.Show("回复成功！");
            }
            if (result == 0)
            {
                MessageBox.Show("回复失败！");
            }

            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_LogIn
{
    public partial class frm_Message : Form
    {
        public frm_Message()
        {
            InitializeComponent();
        }

        private void frm_Message_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“messageData.tb_Messege”中。您可以根据需要移动或删除它。
            this.tb_MessegeTableAdapter.Fill(this.messageData.tb_Messege);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Message = gv_Message.Rows[e.RowIndex].Cells["Detail"].Value.ToString();
            MessageBox.Show(Message);
            gv_Message.Rows[e.RowIndex].Cells["Status"].Value = "已读";
        }
    }
}

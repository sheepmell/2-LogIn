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
    public partial class frm_Notice : Form
    {
        public frm_Notice()
        {
            InitializeComponent();
        }

        private void frm_Notice_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“noticeData.tb_Notice”中。您可以根据需要移动或删除它。
            this.tb_NoticeTableAdapter.Fill(this.noticeData.tb_Notice);

        }

        private void gv_Notice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Detail = gv_Notice.Rows[e.RowIndex].Cells["Detail"].Value.ToString();
            MessageBox.Show($"{Detail}");
            gv_Notice.Rows[e.RowIndex].Cells["Status"].Value = "已读";
        }
    }
}

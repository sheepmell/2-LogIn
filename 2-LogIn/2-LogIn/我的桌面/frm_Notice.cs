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
        public frm_Notice()
        {
            InitializeComponent();
            this.FormClosed += Frm_Notice_FormClosed;
        }

        private void Frm_Notice_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void frm_Notice_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“educationalSystemDataSet.tb_Notice”中。您可以根据需要移动或删除它。
            this.tb_NoticeTableAdapter.Fill(this.educationalSystemDataSet.tb_Notice);
        }

        private void gv_Notice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Noitce = gv_Notice.Rows[e.RowIndex].Cells["Detail"].Value.ToString();
            MessageBox.Show(Noitce);
            gv_Notice.Rows[e.RowIndex].Cells["Status"].Value = "已读";
        }
    }
}

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
        public frm_Message()
        {
            InitializeComponent();
            this.FormClosed += Frm_Message_FormClosed;
        }

        private void Frm_Message_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void frm_Message_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“educationalSystemDataSet1.tb_Messege”中。您可以根据需要移动或删除它。
            this.tb_MessegeTableAdapter.Fill(this.educationalSystemDataSet1.tb_Messege);

        }

        private void gv_Notice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Noitce = gv_Notice.Rows[e.RowIndex].Cells["Detail"].Value.ToString();
            MessageBox.Show(Noitce);
            gv_Notice.Rows[e.RowIndex].Cells["Status"].Value = "已读";
        }
    }
    
}

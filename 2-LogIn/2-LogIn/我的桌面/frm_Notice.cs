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
        }

        private void frm_Notice_Load(object sender, EventArgs e)
        {
            string CommandText = $@"Select * From tb_Notice;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(CommandText);
            if (sqlHelper.HasRecord)
            {
                int index = this.gv_Notice.Rows.Add();
                this.gv_Notice.Rows[index].Cells[0].Value = sqlHelper["No"].ToString();
                this.gv_Notice.Rows[index].Cells[1].Value = sqlHelper["Title"].ToString();
                this.gv_Notice.Rows[index].Cells[2].Value = sqlHelper["Category"].ToString();
                this.gv_Notice.Rows[index].Cells[3].Value = sqlHelper["Sender"].ToString();
                this.gv_Notice.Rows[index].Cells[4].Value = sqlHelper["SendTime"].ToString();
                this.gv_Notice.Rows[index].Cells[5].Value = sqlHelper["Operation"].ToString();
            }
        }
    }
}

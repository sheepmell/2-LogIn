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
    public partial class frm_SelectionExchangeStudents : Form
    {
        private string _StudentNo;
        public frm_SelectionExchangeStudents()
        {
            InitializeComponent();
        }
        public frm_SelectionExchangeStudents(string studentno) : this()
        {
            this._StudentNo = studentno;
        }
        private void btn_Query_Click(object sender, EventArgs e)
        {
        }
    }
}

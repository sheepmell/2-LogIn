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
    public partial class frm_StudentStatusCard : Form
    {
        private string _StudentNo;
        public frm_StudentStatusCard()
        {
            InitializeComponent();
        }
        public frm_StudentStatusCard(string studentNo) : this()
        {
            this._StudentNo = studentNo;
        }
    }
}

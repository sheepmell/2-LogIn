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
    public partial class frm_GradeExamination : Form
    {
        private string _StudentNo;
        public frm_GradeExamination()
        {
            InitializeComponent();
        }

        public frm_GradeExamination(string studentNo) : this()
        {
            this._StudentNo = studentNo;
        }
    }
}

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
    public partial class frm_BookSelection : Form
    {
        private string _StudentNo;
        public frm_BookSelection()
        {
            InitializeComponent();
        }
        public frm_BookSelection(string studentno) : this()
        {
            this._StudentNo = studentno;
            this.LoadTerm();
        }
        //载入学期
        private void LoadTerm()
        {
            string commandText = "SELECT Term FROM Tb_Term;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cmb_Term.Items.Add(sqlHelper["Term"]);
            }
        }
        //查询
        private void btn_Query_Click(object sender, EventArgs e)
        {
            string commandText = $@"SELECT C.NAME AS 课程 ,B.NAME AS 教材名 ,
                                           B.ISBN,B.AUTHOR,B.PRESS,B.PRICE
                                   FROM TB_BOOK AS B
	                                   JOIN TB_TERM AS T ON T.NO = B.TERMNO
		                               JOIN TB_COURSE AS C ON C.NO = B.COURSENO
	                               WHERE T.TERM = '{this.cmb_Term.SelectedItem.ToString()}'";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickFill(commandText, gv_Books);
        }
    }
}

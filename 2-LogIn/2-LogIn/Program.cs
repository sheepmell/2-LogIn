using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_LogIn
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frm_LogIn frm_LogIn = new frm_LogIn();
            frm_LogIn.Show();
            //frm_Homepage frm_Homepage = new frm_Homepage();
            //frm_Homepage.Show();
            Application.Run();
        }
    }
}

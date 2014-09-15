using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Data.SqlClient;

namespace 客户端
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>+         
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           Login Login1 = new Login();
            if (Login1.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Mainfunction());
             }
            Application.Run(new Statement());
        }
    }
}

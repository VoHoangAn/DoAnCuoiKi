using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ThongKeTheoNgay());
            //LoginForm log = new LoginForm();
            //log.StartPosition = FormStartPosition.CenterScreen;

            //if (log.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(log.cvForm);
            //}
            //else
            //{
            //    Application.EnableVisualStyles();
            //    Application.Exit();
            //}

        }
    }
}

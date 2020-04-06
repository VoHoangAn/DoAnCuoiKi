﻿using System;
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
       //     Application.Run(new LoginForm());
            LoginForm flogin = new LoginForm();
            if (flogin.ShowDialog() == DialogResult.OK)
            { Application.Run(new MainForm()); }
            else
            { Application.Exit(); }
        }
    }
}
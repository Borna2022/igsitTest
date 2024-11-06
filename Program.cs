using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace igsit
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2TestDataset());
            ///////////////////////////////////////////////////بعد از تحویل

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //// نمایش فرم لاگین
            //Login loginForm = new Login();
            //if (loginForm.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new Form1());
            //}
            //else
            //{
            //    Application.Exit();
            //}
        }
    }
}

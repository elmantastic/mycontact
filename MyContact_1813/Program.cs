using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContact_1813
{
    static class Program
    {
        public static LoginForm loginForm;
        public static MyContactList mylist;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mylist = new MyContactList();
            Application.Run(loginForm = new LoginForm());

        }
        
    }
}

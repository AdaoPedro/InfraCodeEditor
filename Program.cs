using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
namespace InfraCodeEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            if (args != null && args.Length > 0)
            {
                String[] files = args;

                //Application.Run(new Splash ());

                Principal mf = new Principal();
                mf.IsArgumentNull = false;
                mf.OpenAssociatedFiles_WhenApplicationStarts(files);
                Application.EnableVisualStyles();
                Application.Run(mf);
            }
            else
            {
                //Application.Run(new Splash());

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Principal());
            }
        }
    }
}

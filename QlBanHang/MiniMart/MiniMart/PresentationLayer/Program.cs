using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMart
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
            Application.Run(new LoginForm());
            //application.run(new minimart.presentationlayer.forms.formnhanvien());
            //Application.Run(new MiniMart.PresentationLayer.Forms.FromKeToan());
        }
    }
}

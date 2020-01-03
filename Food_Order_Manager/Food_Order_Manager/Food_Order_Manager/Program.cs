using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Food_Order_Manager
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

<<<<<<< HEAD
            Application.Run(new Login_Form());
=======
            Application.Run(new ManageEmploy_Form());
>>>>>>> b82d5593988f2a6a4cc968dc589884a4179d8d07
        }
    }
}
